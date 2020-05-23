using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using TSuite;

namespace OrderSuite
{
    public partial class OrderControl : MetroForm
    {
        private POSTools client;
        private Dictionary<string, object> _Data;
        private bool Rebounce_Add = false, Rebounce_Dec = false;
        private float H_fs = 18, C_fs = 16;
        private int Selected_ID = 0, Selected_Price = 0;
        private string Selected_Name = "";
        private Dictionary<int, int> OrderList = new Dictionary<int, int>(); //ID, amount
        private Dictionary<int, Bitmap> ImgList;

        public OrderControl(POSTools pos_cli, Dictionary<string, object> pos_data)
        {
            client = pos_cli;
            _Data = pos_data;
            object d_img;
            _Data.TryGetValue("ProductImages", out d_img);
            ImgList = (Dictionary<int, Bitmap>)d_img;
            InitializeComponent();
            ChangeGridFontSize(14, 12);
            /*
            DataGridViewColumn P_Name = new DataGridViewColumn(), P_ID = new DataGridViewColumn(), P_Price = new DataGridViewColumn(), P_Type = new DataGridViewColumn();
            P_Name.HeaderText = "Product Name";
            P_ID.HeaderText = "Product ID";
            P_Price.HeaderText = "Price";
            P_Type.HeaderText = "Product Type";
            Grid_Menu.Columns.AddRange(P_Name, P_Type, P_Price, P_ID);
            */
            Grid_Menu.DataSource = SetTable("", "", "", "");
            foreach(DataGridViewColumn c in Grid_Menu.Columns)
            {
                switch (c.HeaderText)
                {
                    case "Product Name":
                        c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;
                }
            }
            Grid_Order.DataSource = UpdateOrderList(out int T_Price);
            TextBox_TotalPrice.Text = T_Price.ToString();
            foreach (DataGridViewColumn c in Grid_Order.Columns)
            {
                switch (c.HeaderText)
                {
                    case "Product Name":
                        c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;
                }
            }
        }
        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(Keys key);
        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(int key);
        /// <summary>
        /// Creates a notification with a 3000ms duration.
        /// </summary>
        /// <param name="notification">The notification to be shown.</param>
        public void Notify(string notification)
        {
            Timer_Notif.Stop();
            Timer_Notif.Start();
            Label_Notification.Text = notification;
            Label_Notification.Visible = true;
        }
        /// <summary>
        /// Creates a notification with a specified duration.
        /// </summary>
        /// <param name="notification">The notification to be shown.</param>
        /// <param name="duration">The duration in milliseconds.</param>
        public void Notify(string notification, int duration)
        {
            Timer_Notif.Stop();
            Timer_Notif.Interval = duration;
            Timer_Notif.Start();
            Label_Notification.Text = notification;
            Label_Notification.Visible = true;
        }
        /// <summary>
        /// Creates a data table with rows that match the filter specified.
        /// </summary>
        /// <param name="FilterType">The string that the "Product Type" should contain.</param>
        /// <param name="FilterName">The string that the "Product Name" should contain.</param>
        /// <param name="FilterPrice">The string that contains the operator and numerical value to filter rows with.</param>
        /// <param name="FilterID">The number that the "Product ID" should contain.</param>
        /// <returns>Returns a data table that matches the filter.</returns>
        public DataTable SetTable(string FilterType, string FilterName, string FilterPrice, string FilterID)
        {
            //Initializes a data table.
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Product Name", typeof(string));
            tbl.Columns.Add("Product Type", typeof(string));
            tbl.Columns.Add("Price", typeof(int));
            tbl.Columns.Add("Product ID", typeof(int));
            //Retrieve data to check filters
            object on = new Dictionary<int, string>(), ot = new Dictionary<int, string>(), op = new Dictionary<int, int>();
            _Data.TryGetValue("ProductNames", out on);
            _Data.TryGetValue("ProductTypes", out ot);
            _Data.TryGetValue("ProductPrices", out op);
            Dictionary<int, string> p_name = (Dictionary<int, string>)on, p_type = (Dictionary<int, string>)ot;
            Dictionary<int, int> p_price = (Dictionary<int, int>)op;
            //Check if filters are valid, skip if not.
            bool SkipType = (FilterType == string.Empty), SkipName = (FilterName == string.Empty);
            bool SkipPrice = (FilterType == string.Empty) && !(FilterPrice.Contains(">") || FilterPrice.Contains("<") || FilterPrice.Contains("=")) || FilterPrice.Length < 2;
            bool SkipID = (Regex.Replace(FilterID, @"[^\d]", "") == string.Empty);
            int PFilter = -1, IFilter = -1;
            //Convert numerical strings to integers
            try
            {
                PFilter = Convert.ToInt32(Regex.Replace(FilterPrice, @"[^\d]", ""));
            } catch
            {
                SkipPrice = true;
            }
            try
            {
                IFilter = Convert.ToInt32(Regex.Replace(FilterID, @"[^\d]", ""));
            }
            catch
            {
                SkipID = true;
            }
            //iterate through data
            for (int i = 0; i < p_name.Count; i++)
            {
                string name = "null", type = "null";
                int price = 0;
                //Update Vars
                p_name.TryGetValue(i, out name);
                p_type.TryGetValue(i, out type);
                p_price.TryGetValue(i, out price);
                //check if data contains the name, type, and id. Skips if filter is empty.
                if ((SkipName || name.ToLower().Contains(FilterName.ToLower())) && (SkipType || type.ToLower().Contains(FilterType.ToLower())) && (SkipID || (i+1).ToString().Contains(IFilter.ToString())))
                {
                    //Check if price filter is empty and needs to be skipped.
                    if (SkipPrice)
                    {
                        DataRow dr = tbl.NewRow();
                        object[] src = new object[4] { name, type, price, i+1 };
                        dr.ItemArray = src;
                        tbl.Rows.Add(dr);
                    } else
                    {
                        //Check if the filter is equal or greater than zero.
                        if (PFilter >= 0)
                        {
                            //Get operator and filter accordingly.
                            if (FilterPrice.StartsWith(">="))
                            {
                                if (price >= PFilter)
                                {
                                    DataRow dr = tbl.NewRow();
                                    object[] src = new object[4] { name, type, price, i + 1 };
                                    dr.ItemArray = src;
                                    tbl.Rows.Add(dr);
                                }
                            }
                            else if (FilterPrice.StartsWith("<="))
                            {
                                if (price <= PFilter)
                                {
                                    DataRow dr = tbl.NewRow();
                                    object[] src = new object[4] { name, type, price, i + 1 };
                                    dr.ItemArray = src;
                                    tbl.Rows.Add(dr);
                                }
                            }
                            else if (FilterPrice.StartsWith("="))
                            {
                                if (price == PFilter)
                                {
                                    DataRow dr = tbl.NewRow();
                                    object[] src = new object[4] { name, type, price, i + 1 };
                                    dr.ItemArray = src;
                                    tbl.Rows.Add(dr);
                                }
                            }
                            else if (FilterPrice.StartsWith(">"))
                            {
                                if (price > PFilter)
                                {
                                    DataRow dr = tbl.NewRow();
                                    object[] src = new object[4] { name, type, price, i + 1 };
                                    dr.ItemArray = src;
                                    tbl.Rows.Add(dr);
                                }
                            }
                            else if (FilterPrice.StartsWith("<"))
                            {
                                if (price < PFilter)
                                {
                                    DataRow dr = tbl.NewRow();
                                    object[] src = new object[4] { name, type, price, i + 1 };
                                    dr.ItemArray = src;
                                    tbl.Rows.Add(dr);
                                }
                            } else
                            {
                                if (price == PFilter || price.ToString().Contains(PFilter.ToString()))
                                {
                                    DataRow dr = tbl.NewRow();
                                    object[] src = new object[4] { name, type, price, i + 1 };
                                    dr.ItemArray = src;
                                    tbl.Rows.Add(dr);
                                }
                            }
                        }
                    }
                }
            }
            //Return filtered data table.
            return tbl;
        }
        /// <summary>
        /// Retrieves menu data from the server and updates its own copy of the data.
        /// </summary>
        public void UpdateData()
        {
            Dictionary<string, object> data = new Dictionary<string, object>();
            Dictionary<int, string> ProductName = new Dictionary<int, string>(), ProductType = new Dictionary<int, string>();
            Dictionary<string, int> ProductID = new Dictionary<string, int>();
            Dictionary<int, int> ProductPrice = new Dictionary<int, int>();
            Dictionary<int, Bitmap> ProductImages = new Dictionary<int, Bitmap>();
            try
            {
                string[] p = client.GetProductList();
                string[] pt = client.GetTypeList();
                int[] price = client.GetProductPrices();
                for (int i = 0; i < p.Length; i++)
                {
                    ProductName.Add(i, p[i]);
                    ProductType.Add(i, pt[i]);
                    ProductID.Add(p[i], i);
                    ProductPrice.Add(i, price[i]);
                    try
                    {
                        ProductImages.Add(i + 1, Toolbox.GetBitmapFromURL($@"http://{client.GetHostIP()}:32547/{i + 1}.png"));
                    }
                    catch
                    {
                        ProductImages.Add(i + 1, null);
                    }
                }
            }
            catch (POSException)
            {
                //throw new Exception("Error updating data.");
                try
                {
                    client.Reconnect(5);
                    Console.WriteLine("Connection was lost, successfully reconnected!");
                }
                catch
                {
                    MetroMessageBox.Show(this, "Connection to server was lost. Application will now force close...", "Network Error (Code: 200)", MessageBoxButtons.OK, MessageBoxIcon.Hand, 128);
                    Environment.Exit(200);
                }
            }
            data.Add("ProductNames", ProductName);
            data.Add("ProductPrices", ProductPrice);
            data.Add("ProductTypes", ProductType);
            data.Add("ProductIDs", ProductID);
            ImgList = ProductImages;
            _Data.Clear();
            _Data = data;
        }
        public OrderControl()
        {
            InitializeComponent();
        }
        private void OrderControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(-1);
        }

        private void Toolbar_CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult check = MetroMessageBox.Show(this, "Are you sure that you want to exit OrderSuite?", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Information, 180);
            if (check == DialogResult.Yes)
            {
                //Close
            } else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Changes the FontSizes used by the Grid_Menu
        /// </summary>
        /// <param name="HeaderSize">The fontsize of the header cells.</param>
        /// <param name="CellSize">The fontsize of the default cells.</param>
        private void ChangeGridFontSize(float HeaderSize, float CellSize)
        {
            Grid_Menu.ColumnHeadersDefaultCellStyle.Font = new Font(Grid_Menu.ColumnHeadersDefaultCellStyle.Font.FontFamily, HeaderSize);
            Grid_Menu.DefaultCellStyle.Font = new Font(Grid_Menu.DefaultCellStyle.Font.FontFamily, CellSize);
            Grid_Menu.ColumnHeadersHeight = Toolbox.Clamp(4, (int)Math.Floor(HeaderSize / 4), 200);
            Grid_Menu.RowTemplate.Height = Grid_Menu.DefaultCellStyle.Font.Height + 12;
        }

        private void ToolBar_RefreshButton_Click(object sender, EventArgs e)
        {
            UpdateData();
            Grid_Menu.DataSource = SetTable(TextBox_FilterType.Text, TextBox_FilterName.Text, TextBox_FilterPrice.Text, TextBox_FilterID.Text);
            Notify("Successfully Refreshed Data!", 1500);
        }

        private void TextBox_Filter_TextChanged(object sender, EventArgs e)
        {
            Grid_Menu.DataSource = SetTable(TextBox_FilterType.Text, TextBox_FilterName.Text, TextBox_FilterPrice.Text, TextBox_FilterID.Text);
        }

        private void TimeOut_Tick(object sender, EventArgs e)
        {
            try
            {
                client.SendTimeoutResetPacket();
            }
            catch
            {
                try 
                {
                    client.Reconnect(5);
                } catch (POSException)
                {
                    TimeOut.Stop();
                    MetroMessageBox.Show(this, "Connection to server was lost. Could not reconnect.\nApplication will now force close...", "Network Error (Code: 200)", MessageBoxButtons.OK, MessageBoxIcon.Hand, 128);
                    Environment.Exit(200);
                }
                TimeOut_Tick(sender, e);
            }
        }

        private void Timer_FS_Change_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("minus: {0}, equals: {1}", GetAsyncKeyState(187), GetAsyncKeyState(188));

            try
            {
                int amt = int.Parse(TextBox_AmountAdd.Text);
                Button_AddToList.Enabled = true;
            }
            catch
            {
                Button_AddToList.Enabled = false;
            }
            Button_DeleteItem.Enabled = (Grid_Order.SelectedRows.Count > 0);
            Button_ProcessOrderList.Enabled = (OrderList.Count > 0);
            Button_ClearList.Enabled = (OrderList.Count > 0);
            if (GetAsyncKeyState(Keys.ControlKey) != 0)
            {
                if (GetAsyncKeyState(187) != 0)
                {
                    //Notify("Ctrl+", 100);
                    if (!Rebounce_Add)
                    {
                        if (H_fs < 25)
                        {
                            H_fs += 2;
                        }
                        if (C_fs < 23)
                        {
                            C_fs += 2;
                        }
                    }
                    Rebounce_Add = true;
                }
                else
                {
                    Rebounce_Add = false;
                    if ((GetAsyncKeyState(Keys.OemMinus) != 0) || (GetAsyncKeyState(188) != 0))
                    {
                        //Notify("Ctrl-", 100);
                        if (!Rebounce_Dec)
                        {
                            if (H_fs > 13)
                            {
                                H_fs -= 2;
                            }
                            if (C_fs > 11)
                            {
                                C_fs -= 2;
                            }
                        }
                        Rebounce_Dec = true;
                    }
                    else
                    {
                        Rebounce_Dec = false;
                        //Notify("Ctrl",100);
                    }
                }
                
            } else
            {
                Rebounce_Add = false;
                Rebounce_Dec = false;
            }
            if (H_fs != GetFontSizeHeader() && C_fs != GetFontSizeCell())
            {
                ChangeGridFontSize(H_fs, C_fs);
                TextBox_Filter_TextChanged(null, new EventArgs());
            }
        }
        private DataTable UpdateOrderList(out int Total)
        {
            DataTable data = new DataTable();
            Total = 0;
            data.Columns.Add("Product Name", typeof(string));
            data.Columns.Add("Amount", typeof(int));
            data.Columns.Add("Total Price", typeof(int));
            DataRow dr;

            object on = new Dictionary<int, string>(), op = new Dictionary<int, int>();
            _Data.TryGetValue("ProductNames", out on);
            _Data.TryGetValue("ProductPrices", out op);
            Dictionary<int, string> p_name = (Dictionary<int, string>)on;
            Dictionary<int, int> p_price = (Dictionary<int, int>)op;

            foreach (KeyValuePair<int, int> kp in OrderList)
            {
                dr = data.NewRow();
                string name;
                int price, amt = kp.Value;
                p_name.TryGetValue(kp.Key - 1, out name);
                p_price.TryGetValue(kp.Key - 1, out price);
                int total = price * amt;
                Total += total;
                dr.ItemArray = new object[3]{ name, amt, total };
                data.Rows.Add(dr);
            }
            return data;

        }
        private float GetFontSizeHeader()
        {
            return Grid_Menu.ColumnHeadersDefaultCellStyle.Font.Size;
        }
        private float GetFontSizeCell()
        {
            return Grid_Menu.DefaultCellStyle.Font.Size;
        }

        private void TextBox_FilterType_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void Grid_Order_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox_AmountAdd_Click(object sender, EventArgs e)
        {

        }

        private void Button_AddToList_Click(object sender, EventArgs e)
        {
            try
            {
                if (Grid_Menu.SelectedRows.Count > 0)
                {
                    if (OrderList.ContainsKey(Selected_ID))
                    {
                        OrderList.TryGetValue(Selected_ID, out int old_amt);
                        OrderList.Remove(Selected_ID);
                        OrderList.Add(Selected_ID, Toolbox.ConvertToInt32(TextBox_AmountAdd.Text) + old_amt);
                    }
                    else
                    {
                        OrderList.Add(Selected_ID, Toolbox.ConvertToInt32(TextBox_AmountAdd.Text));
                    }
                }
            }
            catch
            {
                Notify("Adding error.", 350);
            }
            Grid_Order.DataSource = UpdateOrderList(out int t_p);
            TextBox_TotalPrice.Text = t_p.ToString();
        }

        private void Button_DeleteItem_Click(object sender, EventArgs e)
        {
            _Data.TryGetValue("ProductIDs", out object op_id);
            Dictionary<string, int> pid = (Dictionary<string, int>)op_id;
            pid.TryGetValue((string)Grid_Order.SelectedRows[0].Cells["Product Name"].Value, out int id);
            OrderList.Remove(id + 1);
            Grid_Order.DataSource = UpdateOrderList(out int T);
            TextBox_TotalPrice.Text = T.ToString();
        }

        private void Button_ClearList_Click(object sender, EventArgs e)
        {
            OrderList.Clear();
            Grid_Order.DataSource = UpdateOrderList(out int t);
            TextBox_TotalPrice.Text = t.ToString();
        }

        private void Grid_Menu_SelectionChanged(object sender, EventArgs e)
        {
            if (Grid_Menu.SelectedRows.Count > 0)
            {
                try
                {
                    Selected_ID = (int)Grid_Menu.SelectedRows[0].Cells["Product ID"].Value;
                    Selected_Name = (string)Grid_Menu.SelectedRows[0].Cells["Product Name"].Value;
                    Selected_Price = (int)Grid_Menu.SelectedRows[0].Cells["Price"].Value;
                    TextBox_DisplayName.Text = Selected_Name;
                    TextBox_DisplayPrice.Text = Selected_Price.ToString();
                    try
                    {
                        /*
                        //Requires fast connection, try getting all images to remove overhead.
                        Bitmap img = Toolbox.GetBitmapFromURL($@"http://{client.GetHostIP()}:32547/{Selected_ID}.png");
                        */
                        Bitmap img;
                        ImgList.TryGetValue(Selected_ID, out img);
                        PictureBox_DisplayProduct.BackgroundImage = img;
                        if (img.Width > PictureBox_DisplayProduct.Width && img.Height > PictureBox_DisplayProduct.Height)
                        {
                            PictureBox_DisplayProduct.BackgroundImageLayout = ImageLayout.Center;
                        } else
                        {
                            PictureBox_DisplayProduct.BackgroundImageLayout = ImageLayout.Zoom;
                        }
                    }
                    catch (Exception)
                    {
                        PictureBox_DisplayProduct.BackgroundImage = null;
                        //MessageBox.Show(ex.Message);
                    }
                }
                catch
                {
                    //MetroMessageBox.Show(this, "Selection parse error.");
                }
            }
        }

        private void TextBox_FilterID_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Notif_Tick(object sender, EventArgs e)
        {
            Label_Notification.Visible = false;
            Label_Notification.Text = "";
            Timer_Notif.Stop();
            Timer_Notif.Interval = 3000;
        }
    }
}
