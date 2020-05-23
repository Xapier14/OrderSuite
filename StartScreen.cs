using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using IniParser.Model;
using IniParser;
using System.IO;
using System.Threading;
using System.Net.Sockets;
using System.Media;
using TSuite;
using System.Collections.Generic;
using System.Drawing;

namespace OrderSuite
{
    public partial class StartScreen : MetroForm
    {
        private static int AC_Max = 10; //Seconds
        private static int AutoConnectTimer = AC_Max;
        private static bool AutoConnecting = false;
        private static string ip;
        private static ushort port;
        private static bool Initialized = false, Connecting = false, ErrorConnect = false, HideForm = false, Exc = false;
        private static string PEx = "";
        private static uint ConnectionStage = 0;
        private static POSTools pp;
        private static Dictionary<string, object> PassData;
        public StartScreen()
        {
            InitializeComponent();
            ProgBar_Status.Maximum = 3;
            //Check for settings
            if (File.Exists(Environment.CurrentDirectory + @"\host.ini"))
            {
                //Retreive settings, check if valid file(Initialized = true if valid);
                Initialized = INI.GetSavedInfo(out ip, out port);
            }
            if (!Initialized)
            {
                //Settings not loaded, do not autoconnect
                AutoConnecting = false;
            } else
            {
                //Settings loaded and valid keep autoconnect
                TextBox_Status.Text = $"Auto-Connecting in {AC_Max}...";
                TextBox_Hostname.Text = ip;
                TextBox_Port.Text = port.ToString();
                AutoConnecting = true;
            }
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }

        private void UITimer_Tick(object sender, EventArgs e)
        {
            //Update variables if text changed.
            if (TextBox_Hostname.Text.Length > 0) ip = TextBox_Hostname.Text;
            if (Toolbox.ConvertToInt32(TextBox_Port.Text) > 0 && Toolbox.ConvertToInt32(TextBox_Port.Text) < 65536) port = Convert.ToUInt16(Toolbox.ConvertToInt32(TextBox_Port.Text));
            //Enable button if text fields are valid.
            Button_Save.Enabled = (TextBox_Hostname.Text.Length > 0) && (Toolbox.ConvertToInt32(TextBox_Port.Text) > 0 && Toolbox.ConvertToInt32(TextBox_Port.Text) < 65536);
            
            if (!Connecting)
            {
                ConnectionStage = 0;
                Button_Connect.Enabled = Button_Save.Enabled;
                //If the client encountered a general error after connection attempt.
                if (ErrorConnect)
                {
                    
                    TextBox_Status.Text = "Error connecting to host.";
                    TextBox_Hostname.Enabled = true;
                    TextBox_Port.Enabled = true;
                    ErrorConnect = false;
                }
                //If the client encountered an exception after connection attempt
                if (Exc)
                {
                    TextBox_Status.Text = PEx;
                    TextBox_Hostname.Enabled = true;
                    TextBox_Port.Enabled = true;
                    Exc = false;
                }
            } else if (ConnectionStage > 0)
            {
                //Set the text on what stage of the connection the client is at.
                switch (ConnectionStage)
                {
                    case 1:
                        TextBox_Status.Text = "Connection Established. Retreiving data...";
                        break;
                    case 2:
                        TextBox_Status.Text = "Retreived data. Launching control panel.";
                        break;
                    case 3:
                        TextBox_Status.Text = "Control panel launched.";
                        break;
                }
                if (HideForm)
                {
                    //Display control panel after successfull connection.
                    Visible = false;
                    Hide();
                    OrderControl oc = new OrderControl(pp, PassData);
                    oc.Visible = true;
                    oc.Parent = null;
                    oc.Show();
                    HideForm = false;
                }
            }
            ProgBar_Status.Value = (int)ConnectionStage;
        }

        private void StartTimer_Tick(object sender, EventArgs e)
        {
            //If client has enabled autoconnect
            if (AutoConnecting)
            {
                //Timer not 0
                if (AutoConnectTimer > 0)
                {
                    //Update Timer
                    AutoConnectTimer--;
                    TextBox_Status.Text = $"Auto-Connecting in {AutoConnectTimer}...";
                } else
                {
                    //Timer ran out, attempt connection.
                    Button_Connect_Click(null, new EventArgs());
                    AutoConnectTimer = AC_Max;
                    AutoConnecting = false;
                    StartTimer.Enabled = false;
                }
            }
        }

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            //If the client is in the middle of a connection attempt, return void.
            if (Connecting) return;
            //If the autoconnect timer is enabled end still running.
            if (AutoConnecting)
            {
                //Disable and reset the timer.
                AutoConnecting = false;
                AutoConnectTimer = AC_Max;
            }
            //Update variables and UI
            TextBox_Status.Text = "Connecting to host...";
            TextBox_Hostname.Enabled = false;
            TextBox_Port.Enabled = false;
            Connecting = true;
            Button_Connect.Enabled = false;

            //Create connection thread so that UI will not be blocked.
            new Thread(new ThreadStart(ClientConnect)).Start();
        }
        private void ClientConnect()
        {
            //Create TCPClient object
            TcpClient cli = new TcpClient();
            try
            {
                //Try connecting to host
                cli.Connect(ip, port);
                ConnectionStage++;
                //Create an instance of POSTools from client
                POSTools pos = new POSTools(cli, ip, port);
                pp = pos;
                //Retreive Data
                Dictionary<string, object> data = new Dictionary<string, object>();
                Dictionary<int, string> ProductName = new Dictionary<int, string>(), ProductType = new Dictionary<int, string>();
                Dictionary<string, int> ProductID = new Dictionary<string, int>();
                Dictionary<int, int> ProductPrice = new Dictionary<int, int>();
                Dictionary<int, Bitmap> ProductImages = new Dictionary<int, Bitmap>();
                //Try parsing data.
                try
                {
                    string[] p = pos.GetProductList();
                    string[] pt = pos.GetTypeList();
                    int[] price = pos.GetProductPrices();
                    for (int i = 0; i < p.Length; i++)
                    {
                        //Add parsed data to the dictionaries that will be passed to the Control Panel Instance.
                        ProductName.Add(i, p[i]);
                        ProductType.Add(i, pt[i]);
                        ProductID.Add(p[i], i);
                        ProductPrice.Add(i, price[i]);
                        try
                        {
                            ProductImages.Add(i + 1, Toolbox.GetBitmapFromURL($@"http://{pp.GetHostIP()}:32547/{i + 1}.png"));
                        }
                        catch
                        {
                            ProductImages.Add(i + 1, null);
                        }
                    }
                } catch (Exception ex)
                {
                    //If a data parse problem occurs, stop connection attempt and raise excemption flag so that the UI will be updated.
                    Exc = true;
                    if (!ex.Message.Contains("System"))
                    {
                        PEx = ex.Message;
                    } else
                    {
                        PEx = "Data parse error. Could not connect.";
                    }
                    Connecting = false;
                    ConnectionStage = 0;
                    cli.Close();
                    SystemSounds.Hand.Play();
                    return;
                }
                //Package the dictionaries into one object.
                data.Add("ProductNames", ProductName);
                data.Add("ProductPrices", ProductPrice);
                data.Add("ProductTypes", ProductType);
                data.Add("ProductIDs", ProductID);
                data.Add("ProductImages", ProductImages);
                ConnectionStage++;
                //Show Control Window
                PassData = data;
                HideForm = true;
                ConnectionStage++;
            } catch (SocketException)
            {
                //General Connection Failure, stop attempt and raise flag.
                ErrorConnect = true;
                Connecting = false;
                SystemSounds.Hand.Play();
                return;
            }
        }

        private void TextBox_ServerInfo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Check if the enter key is pressed in the ip and port text fields and simulate connect button press.
            if (Button_Connect.Enabled && Toolbox.GetCharFromKey(System.Windows.Input.Key.Enter) == e.KeyChar) Button_Connect_Click(sender, new EventArgs());
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            //Save connection info to settings file.
            INI.SetSavedInfo(ip, port);
        }

        private void ScreenForm_Closed(object sender, FormClosedEventArgs e)
        {
            //Force close if the connection thread is still running.
            if (Connecting)
            {
                Environment.Exit(0);
            }
        }

        private void TextBox_Hostname_TextChanged(object sender, EventArgs e)
        {
            //Abort auto connect if user changes connection info
            if (AutoConnecting)
            {
                AutoConnecting = false;
                AutoConnectTimer = AC_Max;
                TextBox_Status.Text = "Auto-Connect aborted.";
            }
        }

        private void TextBox_Port_TextChanged(object sender, EventArgs e)
        {
            TextBox_Hostname_TextChanged(sender, e);
        }
    }
    public class INI
    {
        public static void SetSavedInfo(string host, ushort port)
        {
            if (host != string.Empty && port > 0)
            {
                if (File.Exists(Environment.CurrentDirectory + @"\host.ini")) File.Delete(Environment.CurrentDirectory + @"\host.ini");
                IniData id = new IniData();
                SectionData sd = new SectionData("Host Info");
                sd.Keys.AddKey("Hostname", host);
                sd.Keys.AddKey("Port", port.ToString());
                id.Sections.Add(sd);
                FileIniDataParser fini = new FileIniDataParser();
                fini.WriteFile(Environment.CurrentDirectory + @"\host.ini", id);
            }
            else throw new Exception("Hostname/Port fields are invalid.");
        }
        public static bool GetSavedInfo(out string host, out ushort port)
        {
            host = "";
            port = 0;
            FileIniDataParser parser = new FileIniDataParser();
            if (!File.Exists(Environment.CurrentDirectory + @"\host.ini"))
            {
                return false;
            }
            IniData id = parser.ReadFile(Environment.CurrentDirectory + @"\host.ini");
            foreach(SectionData sd in id.Sections)
            {
                if (sd.SectionName == "Host Info")
                {
                    foreach (KeyData kd in sd.Keys)
                    {
                        if (kd.KeyName == "Hostname")
                        {
                            host = kd.Value;
                        }
                        if (kd.KeyName == "Port")
                        {
                            port = Convert.ToUInt16(kd.Value);
                        }
                    }
                }
            }
            if (host != "" && port > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
