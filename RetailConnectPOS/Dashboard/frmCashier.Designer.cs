namespace RetailConnectPOS.Dashboard
{
    partial class frmCashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCashier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnAppClose = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtBarcodeReaderBox = new System.Windows.Forms.TextBox();
            this.btnQuanIncrease = new System.Windows.Forms.Button();
            this.btnQuantityDecrease = new System.Windows.Forms.Button();
            this.lblReso = new System.Windows.Forms.Label();
            this.panelBottom1 = new System.Windows.Forms.Panel();
            this.lblStoreCode = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lalbelDateTime = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelGridShow = new System.Windows.Forms.Panel();
            this.gridItemMaster = new System.Windows.Forms.DataGridView();
            this.panelPay = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPanelPayHide = new System.Windows.Forms.Button();
            this.btnPanelPayShow = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblItemUntiPrice = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panelBottom2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCancelOrder = new RetailConnect.Classes.CurveButton();
            this.btnPay = new RetailConnect.Classes.CurveButton();
            this.btnChnagePrice = new RetailConnect.Classes.CurveButton();
            this.btnCash = new RetailConnect.Classes.CurveButton();
            this.btnReprintInvoice = new RetailConnect.Classes.CurveButton();
            this.btnCreditSales = new RetailConnect.Classes.CurveButton();
            this.btnPWP = new RetailConnect.Classes.CurveButton();
            this.btnCheckPrice = new RetailConnect.Classes.CurveButton();
            this.btnPOSReport = new RetailConnect.Classes.CurveButton();
            this.btnOpenDrawer = new RetailConnect.Classes.CurveButton();
            this.btnTotal = new RetailConnect.Classes.CurveButton();
            this.btnSKU = new RetailConnect.Classes.CurveButton();
            this.btnSalesReturn = new RetailConnect.Classes.CurveButton();
            this.btnCancelItem = new RetailConnect.Classes.CurveButton();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panelBottom1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelGridShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridItemMaster)).BeginInit();
            this.panelPay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panelBottom2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.lblStoreName);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.btnAppClose);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 42);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.ForeColor = System.Drawing.Color.White;
            this.lblStoreName.Location = new System.Drawing.Point(46, 9);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(97, 23);
            this.lblStoreName.TabIndex = 5;
            this.lblStoreName.Text = "Store Name";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(564, 10);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(45, 23);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "User";
            // 
            // btnAppClose
            // 
            this.btnAppClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAppClose.BackgroundImage")));
            this.btnAppClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAppClose.FlatAppearance.BorderSize = 0;
            this.btnAppClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAppClose.Location = new System.Drawing.Point(757, 4);
            this.btnAppClose.Name = "btnAppClose";
            this.btnAppClose.Size = new System.Drawing.Size(40, 35);
            this.btnAppClose.TabIndex = 0;
            this.btnAppClose.UseVisualStyleBackColor = false;
            this.btnAppClose.Click += new System.EventHandler(this.btnAppClose_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(3, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(40, 35);
            this.button9.TabIndex = 0;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(579, 8);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(0, 28);
            this.txtUsername.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Controls.Add(this.panel3);
            this.panel10.Controls.Add(this.btnCancelOrder);
            this.panel10.Controls.Add(this.btnPay);
            this.panel10.Controls.Add(this.txtQuantity);
            this.panel10.Controls.Add(this.txtBarcodeReaderBox);
            this.panel10.Controls.Add(this.btnQuanIncrease);
            this.panel10.Controls.Add(this.btnQuantityDecrease);
            this.panel10.Controls.Add(this.panel5);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 42);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(800, 74);
            this.panel10.TabIndex = 2;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.ForeColor = System.Drawing.Color.White;
            this.lblAddress2.Location = new System.Drawing.Point(85, 5);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(50, 23);
            this.lblAddress2.TabIndex = 32;
            this.lblAddress2.Text = "Add2";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.ForeColor = System.Drawing.Color.White;
            this.lblAddress1.Location = new System.Drawing.Point(12, 5);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(50, 23);
            this.lblAddress1.TabIndex = 32;
            this.lblAddress1.Text = "Add1";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(50, 40);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(42, 29);
            this.txtQuantity.TabIndex = 26;
            this.txtQuantity.Text = "1";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBarcodeReaderBox
            // 
            this.txtBarcodeReaderBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarcodeReaderBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcodeReaderBox.ForeColor = System.Drawing.Color.Black;
            this.txtBarcodeReaderBox.Location = new System.Drawing.Point(141, 38);
            this.txtBarcodeReaderBox.Name = "txtBarcodeReaderBox";
            this.txtBarcodeReaderBox.Size = new System.Drawing.Size(440, 29);
            this.txtBarcodeReaderBox.TabIndex = 5;
            this.txtBarcodeReaderBox.TextChanged += new System.EventHandler(this.txtBarcodeReaderBox_TextChanged);
            this.txtBarcodeReaderBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcodeReaderBox_KeyPress);
            // 
            // btnQuanIncrease
            // 
            this.btnQuanIncrease.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnQuanIncrease.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuanIncrease.BackgroundImage")));
            this.btnQuanIncrease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuanIncrease.FlatAppearance.BorderSize = 0;
            this.btnQuanIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanIncrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanIncrease.ForeColor = System.Drawing.Color.White;
            this.btnQuanIncrease.Location = new System.Drawing.Point(8, 39);
            this.btnQuanIncrease.Name = "btnQuanIncrease";
            this.btnQuanIncrease.Size = new System.Drawing.Size(40, 30);
            this.btnQuanIncrease.TabIndex = 1;
            this.btnQuanIncrease.UseVisualStyleBackColor = false;
            this.btnQuanIncrease.Click += new System.EventHandler(this.btnQuanIncrease_Click);
            // 
            // btnQuantityDecrease
            // 
            this.btnQuantityDecrease.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnQuantityDecrease.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQuantityDecrease.BackgroundImage")));
            this.btnQuantityDecrease.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnQuantityDecrease.FlatAppearance.BorderSize = 0;
            this.btnQuantityDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuantityDecrease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuantityDecrease.ForeColor = System.Drawing.Color.White;
            this.btnQuantityDecrease.Location = new System.Drawing.Point(95, 39);
            this.btnQuantityDecrease.Name = "btnQuantityDecrease";
            this.btnQuantityDecrease.Size = new System.Drawing.Size(40, 30);
            this.btnQuantityDecrease.TabIndex = 2;
            this.btnQuantityDecrease.UseVisualStyleBackColor = false;
            this.btnQuantityDecrease.Click += new System.EventHandler(this.btnQuantityDecrease_Click);
            // 
            // lblReso
            // 
            this.lblReso.AutoSize = true;
            this.lblReso.BackColor = System.Drawing.Color.SteelBlue;
            this.lblReso.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReso.ForeColor = System.Drawing.Color.White;
            this.lblReso.Location = new System.Drawing.Point(113, 2);
            this.lblReso.Name = "lblReso";
            this.lblReso.Size = new System.Drawing.Size(76, 23);
            this.lblReso.TabIndex = 10;
            this.lblReso.Text = "**** X ****";
            // 
            // panelBottom1
            // 
            this.panelBottom1.BackColor = System.Drawing.Color.SteelBlue;
            this.panelBottom1.Controls.Add(this.lblStoreCode);
            this.panelBottom1.Controls.Add(this.panel4);
            this.panelBottom1.Controls.Add(this.panel2);
            this.panelBottom1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom1.Location = new System.Drawing.Point(0, 572);
            this.panelBottom1.Name = "panelBottom1";
            this.panelBottom1.Size = new System.Drawing.Size(800, 28);
            this.panelBottom1.TabIndex = 6;
            // 
            // lblStoreCode
            // 
            this.lblStoreCode.AutoSize = true;
            this.lblStoreCode.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreCode.ForeColor = System.Drawing.Color.White;
            this.lblStoreCode.Location = new System.Drawing.Point(39, 5);
            this.lblStoreCode.Name = "lblStoreCode";
            this.lblStoreCode.Size = new System.Drawing.Size(46, 20);
            this.lblStoreCode.TabIndex = 3;
            this.lblStoreCode.Text = "label1";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lalbelDateTime);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(560, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 28);
            this.panel4.TabIndex = 2;
            // 
            // lalbelDateTime
            // 
            this.lalbelDateTime.AutoSize = true;
            this.lalbelDateTime.BackColor = System.Drawing.Color.SteelBlue;
            this.lalbelDateTime.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lalbelDateTime.ForeColor = System.Drawing.Color.White;
            this.lalbelDateTime.Location = new System.Drawing.Point(74, 2);
            this.lalbelDateTime.Name = "lalbelDateTime";
            this.lalbelDateTime.Size = new System.Drawing.Size(142, 23);
            this.lalbelDateTime.TabIndex = 10;
            this.lalbelDateTime.Text = "00-00-00 00:00:00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.SteelBlue;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 23);
            this.label11.TabIndex = 7;
            this.label11.Text = "Time:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblReso);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(33, 28);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Resolution:";
            // 
            // panelGridShow
            // 
            this.panelGridShow.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelGridShow.Controls.Add(this.gridItemMaster);
            this.panelGridShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGridShow.Location = new System.Drawing.Point(0, 116);
            this.panelGridShow.Name = "panelGridShow";
            this.panelGridShow.Size = new System.Drawing.Size(800, 307);
            this.panelGridShow.TabIndex = 7;
            // 
            // gridItemMaster
            // 
            this.gridItemMaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridItemMaster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridItemMaster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gridItemMaster.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItemMaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridItemMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItemMaster.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridItemMaster.EnableHeadersVisualStyles = false;
            this.gridItemMaster.Location = new System.Drawing.Point(7, 6);
            this.gridItemMaster.Name = "gridItemMaster";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItemMaster.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridItemMaster.RowHeadersVisible = false;
            this.gridItemMaster.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItemMaster.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridItemMaster.RowTemplate.DividerHeight = 2;
            this.gridItemMaster.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gridItemMaster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItemMaster.Size = new System.Drawing.Size(786, 295);
            this.gridItemMaster.TabIndex = 0;
            // 
            // panelPay
            // 
            this.panelPay.BackColor = System.Drawing.Color.White;
            this.panelPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPay.Controls.Add(this.pictureBox1);
            this.panelPay.Controls.Add(this.btnPanelPayHide);
            this.panelPay.Controls.Add(this.btnPanelPayShow);
            this.panelPay.Controls.Add(this.panel8);
            this.panelPay.Controls.Add(this.panel7);
            this.panelPay.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPay.Location = new System.Drawing.Point(428, 0);
            this.panelPay.Name = "panelPay";
            this.panelPay.Size = new System.Drawing.Size(372, 149);
            this.panelPay.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnPanelPayHide
            // 
            this.btnPanelPayHide.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPanelPayHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPanelPayHide.BackgroundImage")));
            this.btnPanelPayHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPanelPayHide.FlatAppearance.BorderSize = 0;
            this.btnPanelPayHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelPayHide.Location = new System.Drawing.Point(8, 4);
            this.btnPanelPayHide.Name = "btnPanelPayHide";
            this.btnPanelPayHide.Size = new System.Drawing.Size(35, 136);
            this.btnPanelPayHide.TabIndex = 6;
            this.btnPanelPayHide.UseVisualStyleBackColor = false;
            this.btnPanelPayHide.Click += new System.EventHandler(this.btnPanelPayHide_Click);
            // 
            // btnPanelPayShow
            // 
            this.btnPanelPayShow.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPanelPayShow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPanelPayShow.BackgroundImage")));
            this.btnPanelPayShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPanelPayShow.FlatAppearance.BorderSize = 0;
            this.btnPanelPayShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPanelPayShow.Location = new System.Drawing.Point(5, 4);
            this.btnPanelPayShow.Name = "btnPanelPayShow";
            this.btnPanelPayShow.Size = new System.Drawing.Size(35, 136);
            this.btnPanelPayShow.TabIndex = 5;
            this.btnPanelPayShow.UseVisualStyleBackColor = false;
            this.btnPanelPayShow.Click += new System.EventHandler(this.btnPanelPayShow_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label16);
            this.panel8.Controls.Add(this.label20);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Controls.Add(this.lblTotal);
            this.panel8.Location = new System.Drawing.Point(259, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(110, 136);
            this.panel8.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(7, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 24);
            this.label16.TabIndex = 0;
            this.label16.Text = "Total";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Maroon;
            this.label20.Location = new System.Drawing.Point(7, 104);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(51, 29);
            this.label20.TabIndex = 0;
            this.label20.Text = "0.00";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(7, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 24);
            this.label17.TabIndex = 0;
            this.label17.Text = "RIEL";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotal.Location = new System.Drawing.Point(7, 38);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(51, 29);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0.00";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblItemUntiPrice);
            this.panel7.Controls.Add(this.label23);
            this.panel7.Controls.Add(this.lblqty);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Location = new System.Drawing.Point(47, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 136);
            this.panel7.TabIndex = 1;
            // 
            // lblItemUntiPrice
            // 
            this.lblItemUntiPrice.AutoSize = true;
            this.lblItemUntiPrice.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemUntiPrice.ForeColor = System.Drawing.Color.Maroon;
            this.lblItemUntiPrice.Location = new System.Drawing.Point(106, 98);
            this.lblItemUntiPrice.Name = "lblItemUntiPrice";
            this.lblItemUntiPrice.Size = new System.Drawing.Size(51, 29);
            this.lblItemUntiPrice.TabIndex = 0;
            this.lblItemUntiPrice.Text = "0.00";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Maroon;
            this.label23.Location = new System.Drawing.Point(106, 52);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 29);
            this.label23.TabIndex = 0;
            this.label23.Text = "00";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.ForeColor = System.Drawing.Color.Maroon;
            this.lblqty.Location = new System.Drawing.Point(106, 12);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(35, 29);
            this.lblqty.TabIndex = 0;
            this.lblqty.Text = "00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(4, 98);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 24);
            this.label15.TabIndex = 0;
            this.label15.Text = "Unit Price:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(4, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "Discount:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(4, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "Quantity:";
            // 
            // panelBottom2
            // 
            this.panelBottom2.BackColor = System.Drawing.Color.White;
            this.panelBottom2.Controls.Add(this.panelPay);
            this.panelBottom2.Controls.Add(this.btnChnagePrice);
            this.panelBottom2.Controls.Add(this.btnCash);
            this.panelBottom2.Controls.Add(this.btnReprintInvoice);
            this.panelBottom2.Controls.Add(this.btnCreditSales);
            this.panelBottom2.Controls.Add(this.btnPWP);
            this.panelBottom2.Controls.Add(this.btnCheckPrice);
            this.panelBottom2.Controls.Add(this.btnPOSReport);
            this.panelBottom2.Controls.Add(this.btnOpenDrawer);
            this.panelBottom2.Controls.Add(this.btnTotal);
            this.panelBottom2.Controls.Add(this.btnSKU);
            this.panelBottom2.Controls.Add(this.btnSalesReturn);
            this.panelBottom2.Controls.Add(this.btnCancelItem);
            this.panelBottom2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom2.Location = new System.Drawing.Point(0, 423);
            this.panelBottom2.Name = "panelBottom2";
            this.panelBottom2.Size = new System.Drawing.Size(800, 149);
            this.panelBottom2.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Controls.Add(this.lblAddress2);
            this.panel3.Controls.Add(this.lblAddress1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 32);
            this.panel3.TabIndex = 32;
            this.panel3.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(584, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(216, 74);
            this.panel5.TabIndex = 33;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelOrder.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancelOrder.FlatAppearance.BorderSize = 0;
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOrder.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.Location = new System.Drawing.Point(693, 7);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(100, 60);
            this.btnCancelOrder.TabIndex = 31;
            this.btnCancelOrder.Text = "Cancel Order";
            this.btnCancelOrder.UseVisualStyleBackColor = false;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click);
            this.btnCancelOrder.MouseEnter += new System.EventHandler(this.btnCancelOrder_MouseEnter);
            this.btnCancelOrder.MouseLeave += new System.EventHandler(this.btnCancelOrder_MouseLeave);
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPay.FlatAppearance.BorderSize = 0;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(587, 7);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(100, 60);
            this.btnPay.TabIndex = 31;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            this.btnPay.MouseEnter += new System.EventHandler(this.btnPay_MouseEnter);
            this.btnPay.MouseLeave += new System.EventHandler(this.btnPay_MouseLeave);
            // 
            // btnChnagePrice
            // 
            this.btnChnagePrice.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnChnagePrice.FlatAppearance.BorderSize = 0;
            this.btnChnagePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChnagePrice.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChnagePrice.Location = new System.Drawing.Point(217, 79);
            this.btnChnagePrice.Name = "btnChnagePrice";
            this.btnChnagePrice.Size = new System.Drawing.Size(100, 60);
            this.btnChnagePrice.TabIndex = 1;
            this.btnChnagePrice.Text = "Change \r\nPrice";
            this.btnChnagePrice.UseVisualStyleBackColor = false;
            this.btnChnagePrice.Click += new System.EventHandler(this.btnChnagePrice_Click);
            this.btnChnagePrice.MouseEnter += new System.EventHandler(this.btnChnagePrice_MouseEnter);
            this.btnChnagePrice.MouseLeave += new System.EventHandler(this.btnChnagePrice_MouseLeave);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCash.FlatAppearance.BorderSize = 0;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCash.Location = new System.Drawing.Point(533, 79);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(100, 60);
            this.btnCash.TabIndex = 1;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            this.btnCash.MouseEnter += new System.EventHandler(this.btnCash_MouseEnter);
            this.btnCash.MouseLeave += new System.EventHandler(this.btnCash_MouseLeave);
            // 
            // btnReprintInvoice
            // 
            this.btnReprintInvoice.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnReprintInvoice.FlatAppearance.BorderSize = 0;
            this.btnReprintInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReprintInvoice.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReprintInvoice.Location = new System.Drawing.Point(427, 79);
            this.btnReprintInvoice.Name = "btnReprintInvoice";
            this.btnReprintInvoice.Size = new System.Drawing.Size(100, 60);
            this.btnReprintInvoice.TabIndex = 1;
            this.btnReprintInvoice.Text = "Reprint\r\nInvoice";
            this.btnReprintInvoice.UseVisualStyleBackColor = false;
            this.btnReprintInvoice.Click += new System.EventHandler(this.btnReprintInvoice_Click);
            this.btnReprintInvoice.MouseEnter += new System.EventHandler(this.btnReprintInvoice_MouseEnter);
            this.btnReprintInvoice.MouseLeave += new System.EventHandler(this.btnReprintInvoice_MouseLeave);
            // 
            // btnCreditSales
            // 
            this.btnCreditSales.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCreditSales.FlatAppearance.BorderSize = 0;
            this.btnCreditSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreditSales.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditSales.Location = new System.Drawing.Point(322, 79);
            this.btnCreditSales.Name = "btnCreditSales";
            this.btnCreditSales.Size = new System.Drawing.Size(100, 60);
            this.btnCreditSales.TabIndex = 1;
            this.btnCreditSales.Text = "Credit\r\nSales";
            this.btnCreditSales.UseVisualStyleBackColor = false;
            this.btnCreditSales.Click += new System.EventHandler(this.btnCreditSales_Click);
            this.btnCreditSales.MouseEnter += new System.EventHandler(this.btnCreditSales_MouseEnter);
            this.btnCreditSales.MouseLeave += new System.EventHandler(this.btnCreditSales_MouseLeave);
            // 
            // btnPWP
            // 
            this.btnPWP.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPWP.FlatAppearance.BorderSize = 0;
            this.btnPWP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPWP.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPWP.Location = new System.Drawing.Point(7, 79);
            this.btnPWP.Name = "btnPWP";
            this.btnPWP.Size = new System.Drawing.Size(100, 60);
            this.btnPWP.TabIndex = 1;
            this.btnPWP.Text = "PWP";
            this.btnPWP.UseVisualStyleBackColor = false;
            this.btnPWP.Click += new System.EventHandler(this.btnPWP_Click);
            this.btnPWP.MouseEnter += new System.EventHandler(this.btnPWP_MouseEnter);
            this.btnPWP.MouseLeave += new System.EventHandler(this.btnPWP_MouseLeave);
            // 
            // btnCheckPrice
            // 
            this.btnCheckPrice.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCheckPrice.FlatAppearance.BorderSize = 0;
            this.btnCheckPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckPrice.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckPrice.Location = new System.Drawing.Point(217, 8);
            this.btnCheckPrice.Name = "btnCheckPrice";
            this.btnCheckPrice.Size = new System.Drawing.Size(100, 60);
            this.btnCheckPrice.TabIndex = 1;
            this.btnCheckPrice.Text = "Check\r\nPrice";
            this.btnCheckPrice.UseVisualStyleBackColor = false;
            this.btnCheckPrice.Click += new System.EventHandler(this.btnCheckPrice_Click);
            this.btnCheckPrice.MouseEnter += new System.EventHandler(this.btnCheckPrice_MouseEnter);
            this.btnCheckPrice.MouseLeave += new System.EventHandler(this.btnCheckPrice_MouseLeave);
            // 
            // btnPOSReport
            // 
            this.btnPOSReport.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnPOSReport.FlatAppearance.BorderSize = 0;
            this.btnPOSReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOSReport.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPOSReport.Location = new System.Drawing.Point(112, 8);
            this.btnPOSReport.Name = "btnPOSReport";
            this.btnPOSReport.Size = new System.Drawing.Size(100, 60);
            this.btnPOSReport.TabIndex = 1;
            this.btnPOSReport.Text = "POS\r\nReport";
            this.btnPOSReport.UseVisualStyleBackColor = false;
            this.btnPOSReport.Click += new System.EventHandler(this.btnPOSReport_Click);
            this.btnPOSReport.MouseEnter += new System.EventHandler(this.btnPOSReport_MouseEnter);
            this.btnPOSReport.MouseLeave += new System.EventHandler(this.btnPOSReport_MouseLeave);
            // 
            // btnOpenDrawer
            // 
            this.btnOpenDrawer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOpenDrawer.FlatAppearance.BorderSize = 0;
            this.btnOpenDrawer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDrawer.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDrawer.Location = new System.Drawing.Point(427, 8);
            this.btnOpenDrawer.Name = "btnOpenDrawer";
            this.btnOpenDrawer.Size = new System.Drawing.Size(100, 60);
            this.btnOpenDrawer.TabIndex = 1;
            this.btnOpenDrawer.Text = "Open\r\nDrawer";
            this.btnOpenDrawer.UseVisualStyleBackColor = false;
            this.btnOpenDrawer.Click += new System.EventHandler(this.btnOpenDrawer_Click);
            this.btnOpenDrawer.MouseEnter += new System.EventHandler(this.btnOpenDrawer_MouseEnter);
            this.btnOpenDrawer.MouseLeave += new System.EventHandler(this.btnOpenDrawer_MouseLeave);
            // 
            // btnTotal
            // 
            this.btnTotal.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTotal.FlatAppearance.BorderSize = 0;
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(322, 8);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(100, 60);
            this.btnTotal.TabIndex = 1;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            this.btnTotal.MouseEnter += new System.EventHandler(this.btnTotal_MouseEnter);
            this.btnTotal.MouseLeave += new System.EventHandler(this.btnTotal_MouseLeave);
            // 
            // btnSKU
            // 
            this.btnSKU.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSKU.FlatAppearance.BorderSize = 0;
            this.btnSKU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSKU.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSKU.Location = new System.Drawing.Point(7, 8);
            this.btnSKU.Name = "btnSKU";
            this.btnSKU.Size = new System.Drawing.Size(100, 60);
            this.btnSKU.TabIndex = 1;
            this.btnSKU.Text = "SKU";
            this.btnSKU.UseVisualStyleBackColor = false;
            this.btnSKU.Click += new System.EventHandler(this.btnSKU_Click);
            this.btnSKU.MouseEnter += new System.EventHandler(this.btnSKU_MouseEnter);
            this.btnSKU.MouseLeave += new System.EventHandler(this.btnSKU_MouseLeave);
            // 
            // btnSalesReturn
            // 
            this.btnSalesReturn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSalesReturn.FlatAppearance.BorderSize = 0;
            this.btnSalesReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReturn.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalesReturn.Location = new System.Drawing.Point(532, 8);
            this.btnSalesReturn.Name = "btnSalesReturn";
            this.btnSalesReturn.Size = new System.Drawing.Size(100, 60);
            this.btnSalesReturn.TabIndex = 2;
            this.btnSalesReturn.Text = "Sales \r\nReturn";
            this.btnSalesReturn.UseVisualStyleBackColor = false;
            this.btnSalesReturn.Click += new System.EventHandler(this.btnSalesReturn_Click);
            this.btnSalesReturn.MouseEnter += new System.EventHandler(this.btnSalesReturn_MouseEnter);
            this.btnSalesReturn.MouseLeave += new System.EventHandler(this.btnSalesReturn_MouseLeave);
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCancelItem.FlatAppearance.BorderSize = 0;
            this.btnCancelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelItem.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelItem.ForeColor = System.Drawing.Color.Black;
            this.btnCancelItem.Location = new System.Drawing.Point(111, 79);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(100, 60);
            this.btnCancelItem.TabIndex = 28;
            this.btnCancelItem.Text = "Cancel Item";
            this.btnCancelItem.UseVisualStyleBackColor = false;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            this.btnCancelItem.MouseEnter += new System.EventHandler(this.btnCancelItem_MouseEnter);
            this.btnCancelItem.MouseLeave += new System.EventHandler(this.btnCancelItem_MouseLeave);
            // 
            // frmCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelGridShow);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panelBottom2);
            this.Controls.Add(this.panelBottom1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmCashier";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCashier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panelBottom1.ResumeLayout(false);
            this.panelBottom1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelGridShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridItemMaster)).EndInit();
            this.panelPay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panelBottom2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAppClose;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel panel10;
      
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtBarcodeReaderBox;
        private System.Windows.Forms.Button btnQuanIncrease;
        private System.Windows.Forms.Button btnQuantityDecrease;
        private System.Windows.Forms.Panel panelBottom1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelGridShow;
        private RetailConnect.Classes.CurveButton btnSKU;
        private RetailConnect.Classes.CurveButton btnOpenDrawer;
        private RetailConnect.Classes.CurveButton btnTotal;
        private RetailConnect.Classes.CurveButton btnPOSReport;
        private RetailConnect.Classes.CurveButton btnCheckPrice;
        private RetailConnect.Classes.CurveButton btnPWP;
        private RetailConnect.Classes.CurveButton btnCreditSales;
        private RetailConnect.Classes.CurveButton btnReprintInvoice;
        private RetailConnect.Classes.CurveButton btnCash;
        private RetailConnect.Classes.CurveButton btnChnagePrice;
        private System.Windows.Forms.Panel panelPay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPanelPayHide;
        private System.Windows.Forms.Button btnPanelPayShow;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblItemUntiPrice;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.Panel panelBottom2;
        private System.Windows.Forms.Label lblReso;
        private System.Windows.Forms.Label lalbelDateTime;
        private System.Windows.Forms.Timer timer1;
        private RetailConnect.Classes.CurveButton btnSalesReturn;
        private System.Windows.Forms.DataGridView gridItemMaster;
        private RetailConnect.Classes.CurveButton btnCancelItem;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Label lblUsername;
        
        private RetailConnect.Classes.CurveButton btnCancelOrder;
        private RetailConnect.Classes.CurveButton btnPay;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblStoreCode;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        }
}