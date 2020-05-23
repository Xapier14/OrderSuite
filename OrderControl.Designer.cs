namespace OrderSuite
{
    partial class OrderControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Toolbar_Panel = new MetroFramework.Controls.MetroPanel();
            this.Label_Notification = new MetroFramework.Controls.MetroLabel();
            this.ToolBar_RefreshButton = new MetroFramework.Controls.MetroTile();
            this.Toolbar_CloseButton = new MetroFramework.Controls.MetroTile();
            this.Toolbar_Title = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.Grid_Menu = new MetroFramework.Controls.MetroGrid();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.Button_DeleteItem = new MetroFramework.Controls.MetroButton();
            this.Button_ClearList = new MetroFramework.Controls.MetroButton();
            this.Button_ProcessOrderList = new MetroFramework.Controls.MetroButton();
            this.TextBox_TotalPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.Button_AddToList = new MetroFramework.Controls.MetroButton();
            this.TextBox_AmountAdd = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel8 = new MetroFramework.Controls.MetroPanel();
            this.Grid_Order = new MetroFramework.Controls.MetroGrid();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.TextBox_DisplayPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.TextBox_DisplayName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.PictureBox_DisplayProduct = new System.Windows.Forms.PictureBox();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.TextBox_FilterID = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_FilterPrice = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_FilterType = new MetroFramework.Controls.MetroTextBox();
            this.TextBox_FilterName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TimeOut = new System.Windows.Forms.Timer(this.components);
            this.Timer_Notif = new System.Windows.Forms.Timer(this.components);
            this.Timer_FS_Change = new System.Windows.Forms.Timer(this.components);
            this.Toolbar_Panel.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Menu)).BeginInit();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_DisplayProduct)).BeginInit();
            this.metroPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Toolbar_Panel
            // 
            this.Toolbar_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Toolbar_Panel.Controls.Add(this.Label_Notification);
            this.Toolbar_Panel.Controls.Add(this.ToolBar_RefreshButton);
            this.Toolbar_Panel.Controls.Add(this.Toolbar_CloseButton);
            this.Toolbar_Panel.Controls.Add(this.Toolbar_Title);
            this.Toolbar_Panel.HorizontalScrollbarBarColor = true;
            this.Toolbar_Panel.HorizontalScrollbarHighlightOnWheel = false;
            this.Toolbar_Panel.HorizontalScrollbarSize = 10;
            this.Toolbar_Panel.Location = new System.Drawing.Point(0, 6);
            this.Toolbar_Panel.Name = "Toolbar_Panel";
            this.Toolbar_Panel.Size = new System.Drawing.Size(1100, 60);
            this.Toolbar_Panel.Style = MetroFramework.MetroColorStyle.Purple;
            this.Toolbar_Panel.TabIndex = 0;
            this.Toolbar_Panel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Toolbar_Panel.UseStyleColors = true;
            this.Toolbar_Panel.VerticalScrollbarBarColor = true;
            this.Toolbar_Panel.VerticalScrollbarHighlightOnWheel = false;
            this.Toolbar_Panel.VerticalScrollbarSize = 10;
            // 
            // Label_Notification
            // 
            this.Label_Notification.AutoSize = true;
            this.Label_Notification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.Label_Notification.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Label_Notification.ForeColor = System.Drawing.Color.White;
            this.Label_Notification.Location = new System.Drawing.Point(369, 24);
            this.Label_Notification.Name = "Label_Notification";
            this.Label_Notification.Size = new System.Drawing.Size(103, 25);
            this.Label_Notification.Style = MetroFramework.MetroColorStyle.Purple;
            this.Label_Notification.TabIndex = 5;
            this.Label_Notification.Text = "Notification";
            this.Label_Notification.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Label_Notification.UseCustomBackColor = true;
            this.Label_Notification.UseCustomForeColor = true;
            this.Label_Notification.Visible = false;
            // 
            // ToolBar_RefreshButton
            // 
            this.ToolBar_RefreshButton.ActiveControl = null;
            this.ToolBar_RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolBar_RefreshButton.Location = new System.Drawing.Point(731, 17);
            this.ToolBar_RefreshButton.Name = "ToolBar_RefreshButton";
            this.ToolBar_RefreshButton.Size = new System.Drawing.Size(180, 40);
            this.ToolBar_RefreshButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.ToolBar_RefreshButton.TabIndex = 4;
            this.ToolBar_RefreshButton.Text = "Refresh Data";
            this.ToolBar_RefreshButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ToolBar_RefreshButton.UseSelectable = true;
            this.ToolBar_RefreshButton.Click += new System.EventHandler(this.ToolBar_RefreshButton_Click);
            // 
            // Toolbar_CloseButton
            // 
            this.Toolbar_CloseButton.ActiveControl = null;
            this.Toolbar_CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Toolbar_CloseButton.Location = new System.Drawing.Point(917, 17);
            this.Toolbar_CloseButton.Name = "Toolbar_CloseButton";
            this.Toolbar_CloseButton.Size = new System.Drawing.Size(180, 40);
            this.Toolbar_CloseButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.Toolbar_CloseButton.TabIndex = 3;
            this.Toolbar_CloseButton.Text = "Close";
            this.Toolbar_CloseButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Toolbar_CloseButton.UseSelectable = true;
            this.Toolbar_CloseButton.Click += new System.EventHandler(this.Toolbar_CloseButton_Click);
            // 
            // Toolbar_Title
            // 
            this.Toolbar_Title.AutoSize = true;
            this.Toolbar_Title.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Toolbar_Title.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Toolbar_Title.Location = new System.Drawing.Point(13, 24);
            this.Toolbar_Title.Name = "Toolbar_Title";
            this.Toolbar_Title.Size = new System.Drawing.Size(350, 25);
            this.Toolbar_Title.Style = MetroFramework.MetroColorStyle.Purple;
            this.Toolbar_Title.TabIndex = 2;
            this.Toolbar_Title.Text = "OrderSuite - Order Management System";
            this.Toolbar_Title.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.Controls.Add(this.Grid_Menu);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 72);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(650, 599);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // Grid_Menu
            // 
            this.Grid_Menu.AllowUserToAddRows = false;
            this.Grid_Menu.AllowUserToDeleteRows = false;
            this.Grid_Menu.AllowUserToResizeColumns = false;
            this.Grid_Menu.AllowUserToResizeRows = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Grid_Menu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle8;
            this.Grid_Menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Menu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid_Menu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Grid_Menu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_Menu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid_Menu.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Grid_Menu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Menu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.Grid_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Menu.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Menu.DefaultCellStyle = dataGridViewCellStyle10;
            this.Grid_Menu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Grid_Menu.EnableHeadersVisualStyles = false;
            this.Grid_Menu.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Grid_Menu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Grid_Menu.Location = new System.Drawing.Point(3, 3);
            this.Grid_Menu.MultiSelect = false;
            this.Grid_Menu.Name = "Grid_Menu";
            this.Grid_Menu.ReadOnly = true;
            this.Grid_Menu.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Menu.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.Grid_Menu.RowHeadersWidth = 51;
            this.Grid_Menu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid_Menu.RowTemplate.Height = 24;
            this.Grid_Menu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid_Menu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Menu.ShowCellErrors = false;
            this.Grid_Menu.ShowCellToolTips = false;
            this.Grid_Menu.ShowEditingIcon = false;
            this.Grid_Menu.ShowRowErrors = false;
            this.Grid_Menu.Size = new System.Drawing.Size(647, 596);
            this.Grid_Menu.Style = MetroFramework.MetroColorStyle.Purple;
            this.Grid_Menu.TabIndex = 2;
            this.Grid_Menu.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Grid_Menu.UseCustomBackColor = true;
            this.Grid_Menu.SelectionChanged += new System.EventHandler(this.Grid_Menu_SelectionChanged);
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel3.Controls.Add(this.Button_DeleteItem);
            this.metroPanel3.Controls.Add(this.Button_ClearList);
            this.metroPanel3.Controls.Add(this.Button_ProcessOrderList);
            this.metroPanel3.Controls.Add(this.TextBox_TotalPrice);
            this.metroPanel3.Controls.Add(this.metroLabel7);
            this.metroPanel3.Controls.Add(this.Button_AddToList);
            this.metroPanel3.Controls.Add(this.TextBox_AmountAdd);
            this.metroPanel3.Controls.Add(this.metroLabel6);
            this.metroPanel3.Controls.Add(this.metroPanel8);
            this.metroPanel3.Controls.Add(this.Grid_Order);
            this.metroPanel3.Controls.Add(this.metroLabel5);
            this.metroPanel3.Controls.Add(this.metroPanel7);
            this.metroPanel3.Controls.Add(this.TextBox_DisplayPrice);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.TextBox_DisplayName);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Controls.Add(this.metroPanel6);
            this.metroPanel3.Controls.Add(this.PictureBox_DisplayProduct);
            this.metroPanel3.Controls.Add(this.metroPanel5);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(656, 72);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(444, 725);
            this.metroPanel3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel3.UseStyleColors = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // Button_DeleteItem
            // 
            this.Button_DeleteItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_DeleteItem.Enabled = false;
            this.Button_DeleteItem.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Button_DeleteItem.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Button_DeleteItem.Location = new System.Drawing.Point(329, 416);
            this.Button_DeleteItem.Name = "Button_DeleteItem";
            this.Button_DeleteItem.Size = new System.Drawing.Size(92, 27);
            this.Button_DeleteItem.Style = MetroFramework.MetroColorStyle.Red;
            this.Button_DeleteItem.TabIndex = 20;
            this.Button_DeleteItem.Text = "Delete Item";
            this.Button_DeleteItem.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_DeleteItem.UseSelectable = true;
            this.Button_DeleteItem.UseStyleColors = true;
            this.Button_DeleteItem.Click += new System.EventHandler(this.Button_DeleteItem_Click);
            // 
            // Button_ClearList
            // 
            this.Button_ClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Button_ClearList.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Button_ClearList.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Button_ClearList.Location = new System.Drawing.Point(19, 687);
            this.Button_ClearList.Name = "Button_ClearList";
            this.Button_ClearList.Size = new System.Drawing.Size(75, 27);
            this.Button_ClearList.Style = MetroFramework.MetroColorStyle.Red;
            this.Button_ClearList.TabIndex = 19;
            this.Button_ClearList.Text = "Clear List";
            this.Button_ClearList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_ClearList.UseSelectable = true;
            this.Button_ClearList.UseStyleColors = true;
            this.Button_ClearList.Click += new System.EventHandler(this.Button_ClearList_Click);
            // 
            // Button_ProcessOrderList
            // 
            this.Button_ProcessOrderList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_ProcessOrderList.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Button_ProcessOrderList.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Button_ProcessOrderList.Location = new System.Drawing.Point(100, 687);
            this.Button_ProcessOrderList.Name = "Button_ProcessOrderList";
            this.Button_ProcessOrderList.Size = new System.Drawing.Size(321, 27);
            this.Button_ProcessOrderList.Style = MetroFramework.MetroColorStyle.Purple;
            this.Button_ProcessOrderList.TabIndex = 18;
            this.Button_ProcessOrderList.Text = "Process Order List";
            this.Button_ProcessOrderList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_ProcessOrderList.UseSelectable = true;
            this.Button_ProcessOrderList.UseStyleColors = true;
            // 
            // TextBox_TotalPrice
            // 
            this.TextBox_TotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBox_TotalPrice.CustomButton.Image = null;
            this.TextBox_TotalPrice.CustomButton.Location = new System.Drawing.Point(269, 1);
            this.TextBox_TotalPrice.CustomButton.Name = "";
            this.TextBox_TotalPrice.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TextBox_TotalPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_TotalPrice.CustomButton.TabIndex = 1;
            this.TextBox_TotalPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_TotalPrice.CustomButton.UseSelectable = true;
            this.TextBox_TotalPrice.CustomButton.Visible = false;
            this.TextBox_TotalPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBox_TotalPrice.Lines = new string[0];
            this.TextBox_TotalPrice.Location = new System.Drawing.Point(126, 658);
            this.TextBox_TotalPrice.MaxLength = 32767;
            this.TextBox_TotalPrice.Name = "TextBox_TotalPrice";
            this.TextBox_TotalPrice.PasswordChar = '\0';
            this.TextBox_TotalPrice.PromptText = "List is empty.";
            this.TextBox_TotalPrice.ReadOnly = true;
            this.TextBox_TotalPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_TotalPrice.SelectedText = "";
            this.TextBox_TotalPrice.SelectionLength = 0;
            this.TextBox_TotalPrice.SelectionStart = 0;
            this.TextBox_TotalPrice.ShortcutsEnabled = true;
            this.TextBox_TotalPrice.Size = new System.Drawing.Size(295, 27);
            this.TextBox_TotalPrice.Style = MetroFramework.MetroColorStyle.Purple;
            this.TextBox_TotalPrice.TabIndex = 17;
            this.TextBox_TotalPrice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_TotalPrice.UseSelectable = true;
            this.TextBox_TotalPrice.WaterMark = "List is empty.";
            this.TextBox_TotalPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_TotalPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(19, 659);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(101, 25);
            this.metroLabel7.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel7.TabIndex = 16;
            this.metroLabel7.Text = "Total Price: ";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseStyleColors = true;
            // 
            // Button_AddToList
            // 
            this.Button_AddToList.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Button_AddToList.Enabled = false;
            this.Button_AddToList.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.Button_AddToList.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.Button_AddToList.Location = new System.Drawing.Point(334, 625);
            this.Button_AddToList.Name = "Button_AddToList";
            this.Button_AddToList.Size = new System.Drawing.Size(87, 27);
            this.Button_AddToList.Style = MetroFramework.MetroColorStyle.Purple;
            this.Button_AddToList.TabIndex = 15;
            this.Button_AddToList.Text = "Add to list";
            this.Button_AddToList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Button_AddToList.UseSelectable = true;
            this.Button_AddToList.UseStyleColors = true;
            this.Button_AddToList.Click += new System.EventHandler(this.Button_AddToList_Click);
            // 
            // TextBox_AmountAdd
            // 
            this.TextBox_AmountAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBox_AmountAdd.CustomButton.Image = null;
            this.TextBox_AmountAdd.CustomButton.Location = new System.Drawing.Point(176, 1);
            this.TextBox_AmountAdd.CustomButton.Name = "";
            this.TextBox_AmountAdd.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TextBox_AmountAdd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_AmountAdd.CustomButton.TabIndex = 1;
            this.TextBox_AmountAdd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_AmountAdd.CustomButton.UseSelectable = true;
            this.TextBox_AmountAdd.CustomButton.Visible = false;
            this.TextBox_AmountAdd.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBox_AmountAdd.Lines = new string[0];
            this.TextBox_AmountAdd.Location = new System.Drawing.Point(126, 625);
            this.TextBox_AmountAdd.MaxLength = 32767;
            this.TextBox_AmountAdd.Name = "TextBox_AmountAdd";
            this.TextBox_AmountAdd.PasswordChar = '\0';
            this.TextBox_AmountAdd.PromptText = "Amount to add";
            this.TextBox_AmountAdd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_AmountAdd.SelectedText = "";
            this.TextBox_AmountAdd.SelectionLength = 0;
            this.TextBox_AmountAdd.SelectionStart = 0;
            this.TextBox_AmountAdd.ShortcutsEnabled = true;
            this.TextBox_AmountAdd.Size = new System.Drawing.Size(202, 27);
            this.TextBox_AmountAdd.Style = MetroFramework.MetroColorStyle.Purple;
            this.TextBox_AmountAdd.TabIndex = 14;
            this.TextBox_AmountAdd.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_AmountAdd.UseSelectable = true;
            this.TextBox_AmountAdd.WaterMark = "Amount to add";
            this.TextBox_AmountAdd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_AmountAdd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBox_AmountAdd.Click += new System.EventHandler(this.TextBox_AmountAdd_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(34, 626);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(86, 25);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Amount: ";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroPanel8
            // 
            this.metroPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(71)))), ((int)(((byte)(159)))));
            this.metroPanel8.HorizontalScrollbarBarColor = true;
            this.metroPanel8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel8.HorizontalScrollbarSize = 10;
            this.metroPanel8.Location = new System.Drawing.Point(6, 614);
            this.metroPanel8.Name = "metroPanel8";
            this.metroPanel8.Size = new System.Drawing.Size(449, 4);
            this.metroPanel8.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroPanel8.TabIndex = 12;
            this.metroPanel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel8.UseCustomBackColor = true;
            this.metroPanel8.VerticalScrollbarBarColor = true;
            this.metroPanel8.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel8.VerticalScrollbarSize = 10;
            // 
            // Grid_Order
            // 
            this.Grid_Order.AllowUserToAddRows = false;
            this.Grid_Order.AllowUserToDeleteRows = false;
            this.Grid_Order.AllowUserToResizeColumns = false;
            this.Grid_Order.AllowUserToResizeRows = false;
            this.Grid_Order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Order.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Grid_Order.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid_Order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.Grid_Order.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.Grid_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid_Order.DefaultCellStyle = dataGridViewCellStyle13;
            this.Grid_Order.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Grid_Order.EnableHeadersVisualStyles = false;
            this.Grid_Order.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Grid_Order.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Grid_Order.Location = new System.Drawing.Point(29, 449);
            this.Grid_Order.Name = "Grid_Order";
            this.Grid_Order.ReadOnly = true;
            this.Grid_Order.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(73)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid_Order.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.Grid_Order.RowHeadersWidth = 51;
            this.Grid_Order.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid_Order.RowTemplate.Height = 24;
            this.Grid_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Order.ShowRowErrors = false;
            this.Grid_Order.Size = new System.Drawing.Size(392, 150);
            this.Grid_Order.Style = MetroFramework.MetroColorStyle.Purple;
            this.Grid_Order.TabIndex = 11;
            this.Grid_Order.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Grid_Order.UseStyleColors = true;
            this.Grid_Order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Order_CellContentClick);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(29, 415);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(94, 25);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = "Order List";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroPanel7
            // 
            this.metroPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(71)))), ((int)(((byte)(159)))));
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(6, 399);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(449, 4);
            this.metroPanel7.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroPanel7.TabIndex = 6;
            this.metroPanel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel7.UseCustomBackColor = true;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            // 
            // TextBox_DisplayPrice
            // 
            this.TextBox_DisplayPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBox_DisplayPrice.CustomButton.Image = null;
            this.TextBox_DisplayPrice.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.TextBox_DisplayPrice.CustomButton.Name = "";
            this.TextBox_DisplayPrice.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TextBox_DisplayPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_DisplayPrice.CustomButton.TabIndex = 1;
            this.TextBox_DisplayPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_DisplayPrice.CustomButton.UseSelectable = true;
            this.TextBox_DisplayPrice.CustomButton.Visible = false;
            this.TextBox_DisplayPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBox_DisplayPrice.Lines = new string[0];
            this.TextBox_DisplayPrice.Location = new System.Drawing.Point(156, 366);
            this.TextBox_DisplayPrice.MaxLength = 32767;
            this.TextBox_DisplayPrice.Name = "TextBox_DisplayPrice";
            this.TextBox_DisplayPrice.PasswordChar = '\0';
            this.TextBox_DisplayPrice.PromptText = "None";
            this.TextBox_DisplayPrice.ReadOnly = true;
            this.TextBox_DisplayPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_DisplayPrice.SelectedText = "";
            this.TextBox_DisplayPrice.SelectionLength = 0;
            this.TextBox_DisplayPrice.SelectionStart = 0;
            this.TextBox_DisplayPrice.ShortcutsEnabled = true;
            this.TextBox_DisplayPrice.Size = new System.Drawing.Size(265, 27);
            this.TextBox_DisplayPrice.Style = MetroFramework.MetroColorStyle.Purple;
            this.TextBox_DisplayPrice.TabIndex = 9;
            this.TextBox_DisplayPrice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_DisplayPrice.UseSelectable = true;
            this.TextBox_DisplayPrice.WaterMark = "None";
            this.TextBox_DisplayPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_DisplayPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(29, 368);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(121, 25);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Product Price:";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = true;
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // TextBox_DisplayName
            // 
            this.TextBox_DisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBox_DisplayName.CustomButton.Image = null;
            this.TextBox_DisplayName.CustomButton.Location = new System.Drawing.Point(239, 1);
            this.TextBox_DisplayName.CustomButton.Name = "";
            this.TextBox_DisplayName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.TextBox_DisplayName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_DisplayName.CustomButton.TabIndex = 1;
            this.TextBox_DisplayName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_DisplayName.CustomButton.UseSelectable = true;
            this.TextBox_DisplayName.CustomButton.Visible = false;
            this.TextBox_DisplayName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBox_DisplayName.Lines = new string[0];
            this.TextBox_DisplayName.Location = new System.Drawing.Point(156, 333);
            this.TextBox_DisplayName.MaxLength = 32767;
            this.TextBox_DisplayName.Name = "TextBox_DisplayName";
            this.TextBox_DisplayName.PasswordChar = '\0';
            this.TextBox_DisplayName.PromptText = "None";
            this.TextBox_DisplayName.ReadOnly = true;
            this.TextBox_DisplayName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_DisplayName.SelectedText = "";
            this.TextBox_DisplayName.SelectionLength = 0;
            this.TextBox_DisplayName.SelectionStart = 0;
            this.TextBox_DisplayName.ShortcutsEnabled = true;
            this.TextBox_DisplayName.Size = new System.Drawing.Size(265, 27);
            this.TextBox_DisplayName.Style = MetroFramework.MetroColorStyle.Purple;
            this.TextBox_DisplayName.TabIndex = 7;
            this.TextBox_DisplayName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_DisplayName.UseSelectable = true;
            this.TextBox_DisplayName.WaterMark = "None";
            this.TextBox_DisplayName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_DisplayName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(19, 334);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(131, 25);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Product Name:";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroPanel6
            // 
            this.metroPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(71)))), ((int)(((byte)(159)))));
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(19, 318);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(420, 4);
            this.metroPanel6.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroPanel6.TabIndex = 5;
            this.metroPanel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel6.UseCustomBackColor = true;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // PictureBox_DisplayProduct
            // 
            this.PictureBox_DisplayProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox_DisplayProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.PictureBox_DisplayProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox_DisplayProduct.Location = new System.Drawing.Point(19, 3);
            this.PictureBox_DisplayProduct.Name = "PictureBox_DisplayProduct";
            this.PictureBox_DisplayProduct.Size = new System.Drawing.Size(420, 315);
            this.PictureBox_DisplayProduct.TabIndex = 4;
            this.PictureBox_DisplayProduct.TabStop = false;
            // 
            // metroPanel5
            // 
            this.metroPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(3, 3);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(10, 724);
            this.metroPanel5.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroPanel5.TabIndex = 3;
            this.metroPanel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel5.UseCustomBackColor = true;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel4.Controls.Add(this.TextBox_FilterID);
            this.metroPanel4.Controls.Add(this.TextBox_FilterPrice);
            this.metroPanel4.Controls.Add(this.TextBox_FilterType);
            this.metroPanel4.Controls.Add(this.TextBox_FilterName);
            this.metroPanel4.Controls.Add(this.metroLabel2);
            this.metroPanel4.Controls.Add(this.metroPanel1);
            this.metroPanel4.Controls.Add(this.metroLabel1);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 677);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(650, 120);
            this.metroPanel4.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroPanel4.TabIndex = 3;
            this.metroPanel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // TextBox_FilterID
            // 
            this.TextBox_FilterID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBox_FilterID.CustomButton.Image = null;
            this.TextBox_FilterID.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.TextBox_FilterID.CustomButton.Name = "";
            this.TextBox_FilterID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_FilterID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_FilterID.CustomButton.TabIndex = 1;
            this.TextBox_FilterID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_FilterID.CustomButton.UseSelectable = true;
            this.TextBox_FilterID.CustomButton.Visible = false;
            this.TextBox_FilterID.Lines = new string[0];
            this.TextBox_FilterID.Location = new System.Drawing.Point(250, 77);
            this.TextBox_FilterID.MaxLength = 32767;
            this.TextBox_FilterID.Name = "TextBox_FilterID";
            this.TextBox_FilterID.PasswordChar = '\0';
            this.TextBox_FilterID.PromptText = "Product ID";
            this.TextBox_FilterID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_FilterID.SelectedText = "";
            this.TextBox_FilterID.SelectionLength = 0;
            this.TextBox_FilterID.SelectionStart = 0;
            this.TextBox_FilterID.ShortcutsEnabled = true;
            this.TextBox_FilterID.Size = new System.Drawing.Size(180, 23);
            this.TextBox_FilterID.Style = MetroFramework.MetroColorStyle.Purple;
            this.TextBox_FilterID.TabIndex = 7;
            this.TextBox_FilterID.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_FilterID.UseSelectable = true;
            this.TextBox_FilterID.UseStyleColors = true;
            this.TextBox_FilterID.WaterMark = "Product ID";
            this.TextBox_FilterID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_FilterID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBox_FilterID.TextChanged += new System.EventHandler(this.TextBox_Filter_TextChanged);
            this.TextBox_FilterID.Click += new System.EventHandler(this.TextBox_FilterID_Click);
            // 
            // TextBox_FilterPrice
            // 
            this.TextBox_FilterPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBox_FilterPrice.CustomButton.Image = null;
            this.TextBox_FilterPrice.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.TextBox_FilterPrice.CustomButton.Name = "";
            this.TextBox_FilterPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_FilterPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_FilterPrice.CustomButton.TabIndex = 1;
            this.TextBox_FilterPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_FilterPrice.CustomButton.UseSelectable = true;
            this.TextBox_FilterPrice.CustomButton.Visible = false;
            this.TextBox_FilterPrice.Lines = new string[0];
            this.TextBox_FilterPrice.Location = new System.Drawing.Point(436, 77);
            this.TextBox_FilterPrice.MaxLength = 32767;
            this.TextBox_FilterPrice.Name = "TextBox_FilterPrice";
            this.TextBox_FilterPrice.PasswordChar = '\0';
            this.TextBox_FilterPrice.PromptText = "Price (Operators: >, >=, <, <=, =)";
            this.TextBox_FilterPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_FilterPrice.SelectedText = "";
            this.TextBox_FilterPrice.SelectionLength = 0;
            this.TextBox_FilterPrice.SelectionStart = 0;
            this.TextBox_FilterPrice.ShortcutsEnabled = true;
            this.TextBox_FilterPrice.Size = new System.Drawing.Size(211, 23);
            this.TextBox_FilterPrice.Style = MetroFramework.MetroColorStyle.Purple;
            this.TextBox_FilterPrice.TabIndex = 8;
            this.TextBox_FilterPrice.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_FilterPrice.UseSelectable = true;
            this.TextBox_FilterPrice.UseStyleColors = true;
            this.TextBox_FilterPrice.WaterMark = "Price (Operators: >, >=, <, <=, =)";
            this.TextBox_FilterPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_FilterPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBox_FilterPrice.TextChanged += new System.EventHandler(this.TextBox_Filter_TextChanged);
            // 
            // TextBox_FilterType
            // 
            this.TextBox_FilterType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBox_FilterType.CustomButton.Image = null;
            this.TextBox_FilterType.CustomButton.Location = new System.Drawing.Point(158, 1);
            this.TextBox_FilterType.CustomButton.Name = "";
            this.TextBox_FilterType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_FilterType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_FilterType.CustomButton.TabIndex = 1;
            this.TextBox_FilterType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_FilterType.CustomButton.UseSelectable = true;
            this.TextBox_FilterType.CustomButton.Visible = false;
            this.TextBox_FilterType.Lines = new string[0];
            this.TextBox_FilterType.Location = new System.Drawing.Point(64, 77);
            this.TextBox_FilterType.MaxLength = 32767;
            this.TextBox_FilterType.Name = "TextBox_FilterType";
            this.TextBox_FilterType.PasswordChar = '\0';
            this.TextBox_FilterType.PromptText = "Product Type";
            this.TextBox_FilterType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_FilterType.SelectedText = "";
            this.TextBox_FilterType.SelectionLength = 0;
            this.TextBox_FilterType.SelectionStart = 0;
            this.TextBox_FilterType.ShortcutsEnabled = true;
            this.TextBox_FilterType.Size = new System.Drawing.Size(180, 23);
            this.TextBox_FilterType.Style = MetroFramework.MetroColorStyle.Purple;
            this.TextBox_FilterType.TabIndex = 6;
            this.TextBox_FilterType.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_FilterType.UseSelectable = true;
            this.TextBox_FilterType.UseStyleColors = true;
            this.TextBox_FilterType.WaterMark = "Product Type";
            this.TextBox_FilterType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_FilterType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBox_FilterType.TextChanged += new System.EventHandler(this.TextBox_Filter_TextChanged);
            this.TextBox_FilterType.Click += new System.EventHandler(this.TextBox_FilterType_Click);
            // 
            // TextBox_FilterName
            // 
            this.TextBox_FilterName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.TextBox_FilterName.CustomButton.Image = null;
            this.TextBox_FilterName.CustomButton.Location = new System.Drawing.Point(23, 1);
            this.TextBox_FilterName.CustomButton.Name = "";
            this.TextBox_FilterName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TextBox_FilterName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBox_FilterName.CustomButton.TabIndex = 1;
            this.TextBox_FilterName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBox_FilterName.CustomButton.UseSelectable = true;
            this.TextBox_FilterName.CustomButton.Visible = false;
            this.TextBox_FilterName.Lines = new string[0];
            this.TextBox_FilterName.Location = new System.Drawing.Point(13, 77);
            this.TextBox_FilterName.MaxLength = 32767;
            this.TextBox_FilterName.Name = "TextBox_FilterName";
            this.TextBox_FilterName.PasswordChar = '\0';
            this.TextBox_FilterName.PromptText = "Product Name";
            this.TextBox_FilterName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox_FilterName.SelectedText = "";
            this.TextBox_FilterName.SelectionLength = 0;
            this.TextBox_FilterName.SelectionStart = 0;
            this.TextBox_FilterName.ShortcutsEnabled = true;
            this.TextBox_FilterName.Size = new System.Drawing.Size(45, 23);
            this.TextBox_FilterName.Style = MetroFramework.MetroColorStyle.Purple;
            this.TextBox_FilterName.TabIndex = 5;
            this.TextBox_FilterName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TextBox_FilterName.UseSelectable = true;
            this.TextBox_FilterName.UseStyleColors = true;
            this.TextBox_FilterName.WaterMark = "Product Name";
            this.TextBox_FilterName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TextBox_FilterName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TextBox_FilterName.TextChanged += new System.EventHandler(this.TextBox_Filter_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(13, 50);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 20);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Filters";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(65)))), ((int)(((byte)(153)))));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 37);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(650, 10);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(13, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Menu Table";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseStyleColors = true;
            // 
            // TimeOut
            // 
            this.TimeOut.Enabled = true;
            this.TimeOut.Interval = 2500;
            this.TimeOut.Tick += new System.EventHandler(this.TimeOut_Tick);
            // 
            // Timer_Notif
            // 
            this.Timer_Notif.Interval = 3000;
            this.Timer_Notif.Tick += new System.EventHandler(this.Timer_Notif_Tick);
            // 
            // Timer_FS_Change
            // 
            this.Timer_FS_Change.Enabled = true;
            this.Timer_FS_Change.Interval = 25;
            this.Timer_FS_Change.Tick += new System.EventHandler(this.Timer_FS_Change_Tick);
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 800);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.Toolbar_Panel);
            this.DisplayHeader = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderControl";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "OrderSuite Operations Panel";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderControl_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderControl_FormClosed);
            this.Toolbar_Panel.ResumeLayout(false);
            this.Toolbar_Panel.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Menu)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_DisplayProduct)).EndInit();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel Toolbar_Panel;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroTile ToolBar_RefreshButton;
        private MetroFramework.Controls.MetroTile Toolbar_CloseButton;
        private MetroFramework.Controls.MetroLabel Toolbar_Title;
        private MetroFramework.Controls.MetroGrid Grid_Menu;
        private MetroFramework.Controls.MetroTextBox TextBox_FilterPrice;
        private MetroFramework.Controls.MetroTextBox TextBox_FilterType;
        private MetroFramework.Controls.MetroTextBox TextBox_FilterName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Timer TimeOut;
        private MetroFramework.Controls.MetroTextBox TextBox_FilterID;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroLabel Label_Notification;
        private System.Windows.Forms.Timer Timer_Notif;
        private System.Windows.Forms.Timer Timer_FS_Change;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private System.Windows.Forms.PictureBox PictureBox_DisplayProduct;
        private MetroFramework.Controls.MetroTextBox TextBox_DisplayPrice;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TextBox_DisplayName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private MetroFramework.Controls.MetroButton Button_ClearList;
        private MetroFramework.Controls.MetroButton Button_ProcessOrderList;
        private MetroFramework.Controls.MetroTextBox TextBox_TotalPrice;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton Button_AddToList;
        private MetroFramework.Controls.MetroTextBox TextBox_AmountAdd;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroPanel metroPanel8;
        private MetroFramework.Controls.MetroGrid Grid_Order;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton Button_DeleteItem;
    }
}