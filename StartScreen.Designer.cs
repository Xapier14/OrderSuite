namespace OrderSuite
{
    partial class StartScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TextBox_Hostname = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_Port = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.TextBox_Status = new MetroFramework.Controls.MetroTextBox();
            this.ProgBar_Status = new MetroFramework.Controls.MetroProgressBar();
            this.Button_Connect = new MetroFramework.Controls.MetroButton();
            this.Button_Save = new MetroFramework.Controls.MetroButton();
            this.StartTimer = new System.Windows.Forms.Timer(this.components);
            this.UITimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 71);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 20);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Host Server: ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TextBox_Hostname
            // 
            // 
            // 
            // 
            this.TextBox_Hostname.CustomButton.Image = null;
            this.TextBox_Hostname.CustomButton.Location = new System.Drawing.Point(187, 2);
            this.TextBox_Hostname.CustomButton.Name = "";
            this.TextBox_Hostname.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.TextBox_Hostname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Hostname.CustomButton.TabIndex = 1;
            this.TextBox_Hostname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Hostname.CustomButton.UseSelectable = true;
            this.TextBox_Hostname.CustomButton.Visible = false;
            this.TextBox_Hostname.Lines = new string[0];
            this.TextBox_Hostname.Location = new System.Drawing.Point(119, 69);
            this.TextBox_Hostname.MaxLength = 32767;
            this.TextBox_Hostname.Name = "TextBox_Hostname";
            this.TextBox_Hostname.PasswordChar = '\0';
            this.TextBox_Hostname.PromptText = "Hostname";
            this.TextBox_Hostname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Hostname.SelectedText = "";
            this.TextBox_Hostname.SelectionLength = 0;
            this.TextBox_Hostname.SelectionStart = 0;
            this.TextBox_Hostname.ShortcutsEnabled = true;
            this.TextBox_Hostname.Size = new System.Drawing.Size(209, 24);
            this.TextBox_Hostname.TabIndex = 1;
            this.TextBox_Hostname.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Hostname.UseSelectable = true;
            this.TextBox_Hostname.WaterMark = "Hostname";
            this.TextBox_Hostname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Hostname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBox_Hostname.TextChanged += new System.EventHandler(this.TextBox_Hostname_TextChanged);
            this.TextBox_Hostname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_ServerInfo_KeyPress);
            // 
            // TextBox_Port
            // 
            // 
            // 
            // 
            this.TextBox_Port.CustomButton.Image = null;
            this.TextBox_Port.CustomButton.Location = new System.Drawing.Point(43, 2);
            this.TextBox_Port.CustomButton.Name = "";
            this.TextBox_Port.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.TextBox_Port.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Port.CustomButton.TabIndex = 1;
            this.TextBox_Port.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Port.CustomButton.UseSelectable = true;
            this.TextBox_Port.CustomButton.Visible = false;
            this.TextBox_Port.Lines = new string[0];
            this.TextBox_Port.Location = new System.Drawing.Point(334, 69);
            this.TextBox_Port.MaxLength = 32767;
            this.TextBox_Port.Name = "TextBox_Port";
            this.TextBox_Port.PasswordChar = '\0';
            this.TextBox_Port.PromptText = "Port";
            this.TextBox_Port.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Port.SelectedText = "";
            this.TextBox_Port.SelectionLength = 0;
            this.TextBox_Port.SelectionStart = 0;
            this.TextBox_Port.ShortcutsEnabled = true;
            this.TextBox_Port.Size = new System.Drawing.Size(65, 24);
            this.TextBox_Port.TabIndex = 2;
            this.TextBox_Port.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Port.UseSelectable = true;
            this.TextBox_Port.WaterMark = "Port";
            this.TextBox_Port.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Port.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBox_Port.TextChanged += new System.EventHandler(this.TextBox_Port_TextChanged);
            this.TextBox_Port.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_ServerInfo_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 100);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(127, 20);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Connection Status: ";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // TextBox_Status
            // 
            // 
            // 
            // 
            this.TextBox_Status.CustomButton.Image = null;
            this.TextBox_Status.CustomButton.Location = new System.Drawing.Point(221, 2);
            this.TextBox_Status.CustomButton.Name = "";
            this.TextBox_Status.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.TextBox_Status.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_Status.CustomButton.TabIndex = 1;
            this.TextBox_Status.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_Status.CustomButton.UseSelectable = true;
            this.TextBox_Status.CustomButton.Visible = false;
            this.TextBox_Status.Lines = new string[] {
        "Idle."};
            this.TextBox_Status.Location = new System.Drawing.Point(156, 96);
            this.TextBox_Status.MaxLength = 32767;
            this.TextBox_Status.Name = "TextBox_Status";
            this.TextBox_Status.PasswordChar = '\0';
            this.TextBox_Status.ReadOnly = true;
            this.TextBox_Status.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_Status.SelectedText = "";
            this.TextBox_Status.SelectionLength = 0;
            this.TextBox_Status.SelectionStart = 0;
            this.TextBox_Status.ShortcutsEnabled = true;
            this.TextBox_Status.Size = new System.Drawing.Size(243, 24);
            this.TextBox_Status.TabIndex = 4;
            this.TextBox_Status.Text = "Idle.";
            this.TextBox_Status.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_Status.UseSelectable = true;
            this.TextBox_Status.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_Status.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ProgBar_Status
            // 
            this.ProgBar_Status.Location = new System.Drawing.Point(156, 118);
            this.ProgBar_Status.Name = "ProgBar_Status";
            this.ProgBar_Status.Size = new System.Drawing.Size(243, 4);
            this.ProgBar_Status.Style = MetroFramework.MetroColorStyle.Purple;
            this.ProgBar_Status.TabIndex = 5;
            this.ProgBar_Status.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ProgBar_Status.Value = 80;
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(178, 126);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(221, 23);
            this.Button_Connect.Style = MetroFramework.MetroColorStyle.Purple;
            this.Button_Connect.TabIndex = 6;
            this.Button_Connect.Text = "Connect to Host";
            this.Button_Connect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_Connect.UseSelectable = true;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Enabled = false;
            this.Button_Save.Location = new System.Drawing.Point(23, 126);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(149, 23);
            this.Button_Save.Style = MetroFramework.MetroColorStyle.Purple;
            this.Button_Save.TabIndex = 7;
            this.Button_Save.Text = "Save Connection Info";
            this.Button_Save.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_Save.UseSelectable = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // StartTimer
            // 
            this.StartTimer.Enabled = true;
            this.StartTimer.Interval = 1000;
            this.StartTimer.Tick += new System.EventHandler(this.StartTimer_Tick);
            // 
            // UITimer
            // 
            this.UITimer.Enabled = true;
            this.UITimer.Interval = 10;
            this.UITimer.Tick += new System.EventHandler(this.UITimer_Tick);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 173);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Connect);
            this.Controls.Add(this.ProgBar_Status);
            this.Controls.Add(this.TextBox_Status);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TextBox_Port);
            this.Controls.Add(this.TextBox_Hostname);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "StartScreen";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "OrderSuite Launchpad";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScreenForm_Closed);
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TextBox_Hostname;
        private MetroFramework.Controls.MetroTextBox TextBox_Port;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox TextBox_Status;
        private MetroFramework.Controls.MetroProgressBar ProgBar_Status;
        private MetroFramework.Controls.MetroButton Button_Connect;
        private MetroFramework.Controls.MetroButton Button_Save;
        private System.Windows.Forms.Timer StartTimer;
        private System.Windows.Forms.Timer UITimer;
    }
}

