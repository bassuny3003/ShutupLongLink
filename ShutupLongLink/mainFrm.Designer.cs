
namespace ShutupLongLink
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.mnuStrp = new System.Windows.Forms.MenuStrip();
            this.statusStrp = new System.Windows.Forms.StatusStrip();
            this.statusLbl01 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLblResponse = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtBxLongURL = new System.Windows.Forms.TextBox();
            this.btnRunShortner = new System.Windows.Forms.Button();
            this.txtBxShortURL = new System.Windows.Forms.TextBox();
            this.cmbBxService = new System.Windows.Forms.ComboBox();
            this.grpBxLongURL = new System.Windows.Forms.GroupBox();
            this.grpBxShortURL = new System.Windows.Forms.GroupBox();
            this.chkBxOnTop = new System.Windows.Forms.CheckBox();
            this.btnOpenLocalDateBase = new System.Windows.Forms.Button();
            this.rbAdType2 = new System.Windows.Forms.RadioButton();
            this.rbAdType1 = new System.Windows.Forms.RadioButton();
            this.lblR7URLAlias = new System.Windows.Forms.Label();
            this.txtBxR7URLAlias = new System.Windows.Forms.TextBox();
            this.imgLst = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCpyShortURL = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstVw = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timrCpyShortURL = new System.Windows.Forms.Timer(this.components);
            this.rightClickLstVw = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditeNotesURL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.CopyWholeRow = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyLongURL = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyShortURL = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyAliasURL = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyNotesURL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.GoToServiceWebSite = new System.Windows.Forms.ToolStripMenuItem();
            this.GoToLongURL = new System.Windows.Forms.ToolStripMenuItem();
            this.GoToShortURL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.DeleteSelectedURL = new System.Windows.Forms.ToolStripMenuItem();
            this.picBxService = new System.Windows.Forms.PictureBox();
            this.mnuItm01 = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuItm01 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItm02 = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuItm03 = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuItm04 = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuItm05 = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuItm06 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.submnuItm07 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItm03 = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuItm08 = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuItm09 = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuItm10 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItm04 = new System.Windows.Forms.ToolStripMenuItem();
            this.submnuItm02 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrp.SuspendLayout();
            this.statusStrp.SuspendLayout();
            this.grpBxLongURL.SuspendLayout();
            this.grpBxShortURL.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightClickLstVw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxService)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStrp
            // 
            this.mnuStrp.BackColor = System.Drawing.SystemColors.Control;
            this.mnuStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItm01,
            this.mnuItm02,
            this.mnuItm03,
            this.mnuItm04});
            this.mnuStrp.Location = new System.Drawing.Point(0, 0);
            this.mnuStrp.Name = "mnuStrp";
            this.mnuStrp.Size = new System.Drawing.Size(490, 24);
            this.mnuStrp.TabIndex = 0;
            this.mnuStrp.Text = "mnuStp";
            // 
            // statusStrp
            // 
            this.statusStrp.GripMargin = new System.Windows.Forms.Padding(0);
            this.statusStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl01,
            this.StatusLblResponse});
            this.statusStrp.Location = new System.Drawing.Point(0, 739);
            this.statusStrp.Name = "statusStrp";
            this.statusStrp.Size = new System.Drawing.Size(490, 22);
            this.statusStrp.SizingGrip = false;
            this.statusStrp.TabIndex = 1;
            this.statusStrp.Text = "statusStrp";
            // 
            // statusLbl01
            // 
            this.statusLbl01.Name = "statusLbl01";
            this.statusLbl01.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusLblResponse
            // 
            this.StatusLblResponse.Name = "StatusLblResponse";
            this.StatusLblResponse.Size = new System.Drawing.Size(0, 17);
            // 
            // txtBxLongURL
            // 
            this.txtBxLongURL.Location = new System.Drawing.Point(6, 19);
            this.txtBxLongURL.Multiline = true;
            this.txtBxLongURL.Name = "txtBxLongURL";
            this.txtBxLongURL.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtBxLongURL.Size = new System.Drawing.Size(448, 155);
            this.txtBxLongURL.TabIndex = 2;
            this.txtBxLongURL.WordWrap = false;
            this.txtBxLongURL.TextChanged += new System.EventHandler(this.txtBxLongURL_TextChanged);
            // 
            // btnRunShortner
            // 
            this.btnRunShortner.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunShortner.Location = new System.Drawing.Point(7, 371);
            this.btnRunShortner.Name = "btnRunShortner";
            this.btnRunShortner.Size = new System.Drawing.Size(460, 50);
            this.btnRunShortner.TabIndex = 3;
            this.btnRunShortner.Text = "Shut Up It";
            this.btnRunShortner.UseVisualStyleBackColor = true;
            this.btnRunShortner.Click += new System.EventHandler(this.btnRunShortner_Click);
            // 
            // txtBxShortURL
            // 
            this.txtBxShortURL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBxShortURL.Location = new System.Drawing.Point(6, 19);
            this.txtBxShortURL.Multiline = true;
            this.txtBxShortURL.Name = "txtBxShortURL";
            this.txtBxShortURL.ReadOnly = true;
            this.txtBxShortURL.Size = new System.Drawing.Size(448, 155);
            this.txtBxShortURL.TabIndex = 4;
            this.txtBxShortURL.WordWrap = false;
            // 
            // cmbBxService
            // 
            this.cmbBxService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBxService.FormattingEnabled = true;
            this.cmbBxService.Location = new System.Drawing.Point(89, 129);
            this.cmbBxService.Name = "cmbBxService";
            this.cmbBxService.Size = new System.Drawing.Size(280, 24);
            this.cmbBxService.TabIndex = 6;
            this.cmbBxService.SelectedIndexChanged += new System.EventHandler(this.cmbBxService_SelectedIndexChanged);
            // 
            // grpBxLongURL
            // 
            this.grpBxLongURL.Controls.Add(this.txtBxLongURL);
            this.grpBxLongURL.Location = new System.Drawing.Point(7, 185);
            this.grpBxLongURL.Name = "grpBxLongURL";
            this.grpBxLongURL.Size = new System.Drawing.Size(460, 180);
            this.grpBxLongURL.TabIndex = 7;
            this.grpBxLongURL.TabStop = false;
            this.grpBxLongURL.Text = "Long URLs";
            // 
            // grpBxShortURL
            // 
            this.grpBxShortURL.Controls.Add(this.txtBxShortURL);
            this.grpBxShortURL.Location = new System.Drawing.Point(7, 427);
            this.grpBxShortURL.Name = "grpBxShortURL";
            this.grpBxShortURL.Size = new System.Drawing.Size(460, 180);
            this.grpBxShortURL.TabIndex = 8;
            this.grpBxShortURL.TabStop = false;
            this.grpBxShortURL.Text = "Short URLs";
            // 
            // chkBxOnTop
            // 
            this.chkBxOnTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBxOnTop.AutoSize = true;
            this.chkBxOnTop.Location = new System.Drawing.Point(380, 7);
            this.chkBxOnTop.Name = "chkBxOnTop";
            this.chkBxOnTop.Size = new System.Drawing.Size(98, 17);
            this.chkBxOnTop.TabIndex = 9;
            this.chkBxOnTop.Text = "Always On Top";
            this.chkBxOnTop.UseVisualStyleBackColor = true;
            this.chkBxOnTop.CheckedChanged += new System.EventHandler(this.chkBxOnTop_CheckedChanged);
            // 
            // btnOpenLocalDateBase
            // 
            this.btnOpenLocalDateBase.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenLocalDateBase.Location = new System.Drawing.Point(7, 676);
            this.btnOpenLocalDateBase.Name = "btnOpenLocalDateBase";
            this.btnOpenLocalDateBase.Size = new System.Drawing.Size(460, 26);
            this.btnOpenLocalDateBase.TabIndex = 11;
            this.btnOpenLocalDateBase.Text = "Open Local Data Base      >>>>>>>>>>";
            this.btnOpenLocalDateBase.UseVisualStyleBackColor = true;
            this.btnOpenLocalDateBase.Click += new System.EventHandler(this.btnOpenLocalDateBase_Click);
            // 
            // rbAdType2
            // 
            this.rbAdType2.AutoSize = true;
            this.rbAdType2.Location = new System.Drawing.Point(225, 159);
            this.rbAdType2.Name = "rbAdType2";
            this.rbAdType2.Size = new System.Drawing.Size(97, 17);
            this.rbAdType2.TabIndex = 26;
            this.rbAdType2.Text = "Framed Banner";
            this.rbAdType2.UseVisualStyleBackColor = true;
            // 
            // rbAdType1
            // 
            this.rbAdType1.AutoSize = true;
            this.rbAdType1.Checked = true;
            this.rbAdType1.Location = new System.Drawing.Point(134, 159);
            this.rbAdType1.Name = "rbAdType1";
            this.rbAdType1.Size = new System.Drawing.Size(85, 17);
            this.rbAdType1.TabIndex = 25;
            this.rbAdType1.TabStop = true;
            this.rbAdType1.Text = "Interstitial Ad";
            this.rbAdType1.UseVisualStyleBackColor = true;
            // 
            // lblR7URLAlias
            // 
            this.lblR7URLAlias.AutoSize = true;
            this.lblR7URLAlias.Location = new System.Drawing.Point(86, 161);
            this.lblR7URLAlias.Name = "lblR7URLAlias";
            this.lblR7URLAlias.Size = new System.Drawing.Size(35, 13);
            this.lblR7URLAlias.TabIndex = 27;
            this.lblR7URLAlias.Text = "Alias :";
            this.lblR7URLAlias.Visible = false;
            // 
            // txtBxR7URLAlias
            // 
            this.txtBxR7URLAlias.Location = new System.Drawing.Point(119, 158);
            this.txtBxR7URLAlias.MaxLength = 30;
            this.txtBxR7URLAlias.Name = "txtBxR7URLAlias";
            this.txtBxR7URLAlias.Size = new System.Drawing.Size(250, 20);
            this.txtBxR7URLAlias.TabIndex = 28;
            this.txtBxR7URLAlias.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBxR7URLAlias.Visible = false;
            // 
            // imgLst
            // 
            this.imgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLst.ImageStream")));
            this.imgLst.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLst.Images.SetKeyName(0, "cancel_20px.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.picBxService);
            this.panel1.Controls.Add(this.txtBxR7URLAlias);
            this.panel1.Controls.Add(this.btnRunShortner);
            this.panel1.Controls.Add(this.lblR7URLAlias);
            this.panel1.Controls.Add(this.cmbBxService);
            this.panel1.Controls.Add(this.rbAdType2);
            this.panel1.Controls.Add(this.grpBxLongURL);
            this.panel1.Controls.Add(this.rbAdType1);
            this.panel1.Controls.Add(this.grpBxShortURL);
            this.panel1.Controls.Add(this.btnOpenLocalDateBase);
            this.panel1.Controls.Add(this.btnCpyShortURL);
            this.panel1.Location = new System.Drawing.Point(8, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 705);
            this.panel1.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCpyShortURL
            // 
            this.btnCpyShortURL.Enabled = false;
            this.btnCpyShortURL.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCpyShortURL.Location = new System.Drawing.Point(7, 613);
            this.btnCpyShortURL.Name = "btnCpyShortURL";
            this.btnCpyShortURL.Size = new System.Drawing.Size(460, 50);
            this.btnCpyShortURL.TabIndex = 10;
            this.btnCpyShortURL.Text = "Copy Short URL";
            this.btnCpyShortURL.UseVisualStyleBackColor = true;
            this.btnCpyShortURL.Click += new System.EventHandler(this.btnCpyShortURL_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstVw);
            this.panel2.Location = new System.Drawing.Point(496, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 705);
            this.panel2.TabIndex = 30;
            // 
            // lstVw
            // 
            this.lstVw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstVw.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstVw.FullRowSelect = true;
            this.lstVw.GridLines = true;
            this.lstVw.HideSelection = false;
            this.lstVw.Location = new System.Drawing.Point(3, 3);
            this.lstVw.MultiSelect = false;
            this.lstVw.Name = "lstVw";
            this.lstVw.ShowGroups = false;
            this.lstVw.Size = new System.Drawing.Size(770, 699);
            this.lstVw.TabIndex = 0;
            this.lstVw.TileSize = new System.Drawing.Size(168, 30);
            this.lstVw.UseCompatibleStateImageBehavior = false;
            this.lstVw.View = System.Windows.Forms.View.Details;
            this.lstVw.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstVw_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Service";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Long URL";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Short URL";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Alias URL";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Notes";
            this.columnHeader6.Width = 75;
            // 
            // timrCpyShortURL
            // 
            this.timrCpyShortURL.Enabled = true;
            this.timrCpyShortURL.Tick += new System.EventHandler(this.timrCpyShortURL_Tick);
            // 
            // rightClickLstVw
            // 
            this.rightClickLstVw.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditeNotesURL,
            this.toolStripSeparator4,
            this.CopyWholeRow,
            this.CopyLongURL,
            this.CopyShortURL,
            this.CopyAliasURL,
            this.CopyNotesURL,
            this.toolStripSeparator2,
            this.GoToServiceWebSite,
            this.GoToLongURL,
            this.GoToShortURL,
            this.toolStripSeparator3,
            this.DeleteSelectedURL});
            this.rightClickLstVw.Name = "rightClickLstVw";
            this.rightClickLstVw.Size = new System.Drawing.Size(191, 242);
            // 
            // EditeNotesURL
            // 
            this.EditeNotesURL.Name = "EditeNotesURL";
            this.EditeNotesURL.Size = new System.Drawing.Size(190, 22);
            this.EditeNotesURL.Text = "Edite Notes URL";
            this.EditeNotesURL.Click += new System.EventHandler(this.EditeNotesURL_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(187, 6);
            // 
            // CopyWholeRow
            // 
            this.CopyWholeRow.Name = "CopyWholeRow";
            this.CopyWholeRow.Size = new System.Drawing.Size(190, 22);
            this.CopyWholeRow.Text = "Copy Whole Row";
            this.CopyWholeRow.Click += new System.EventHandler(this.CopyWholeRow_Click);
            // 
            // CopyLongURL
            // 
            this.CopyLongURL.Name = "CopyLongURL";
            this.CopyLongURL.Size = new System.Drawing.Size(190, 22);
            this.CopyLongURL.Text = "Copy Long URL";
            this.CopyLongURL.Click += new System.EventHandler(this.CopyLongURL_Click);
            // 
            // CopyShortURL
            // 
            this.CopyShortURL.Name = "CopyShortURL";
            this.CopyShortURL.Size = new System.Drawing.Size(190, 22);
            this.CopyShortURL.Text = "Copy Short URL";
            this.CopyShortURL.Click += new System.EventHandler(this.CopyShortURL_Click);
            // 
            // CopyAliasURL
            // 
            this.CopyAliasURL.Name = "CopyAliasURL";
            this.CopyAliasURL.Size = new System.Drawing.Size(190, 22);
            this.CopyAliasURL.Text = "Copy Alias URL";
            this.CopyAliasURL.Click += new System.EventHandler(this.CopyAliasURL_Click);
            // 
            // CopyNotesURL
            // 
            this.CopyNotesURL.Name = "CopyNotesURL";
            this.CopyNotesURL.Size = new System.Drawing.Size(190, 22);
            this.CopyNotesURL.Text = "Copy Notes URL";
            this.CopyNotesURL.Click += new System.EventHandler(this.CopyNotesURL_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // GoToServiceWebSite
            // 
            this.GoToServiceWebSite.Name = "GoToServiceWebSite";
            this.GoToServiceWebSite.Size = new System.Drawing.Size(190, 22);
            this.GoToServiceWebSite.Text = "Go To Service WebSite";
            this.GoToServiceWebSite.Click += new System.EventHandler(this.GoToServiceWebSite_Click);
            // 
            // GoToLongURL
            // 
            this.GoToLongURL.Name = "GoToLongURL";
            this.GoToLongURL.Size = new System.Drawing.Size(190, 22);
            this.GoToLongURL.Text = "Go To Long URL";
            this.GoToLongURL.Click += new System.EventHandler(this.GoToLongURL_Click);
            // 
            // GoToShortURL
            // 
            this.GoToShortURL.Name = "GoToShortURL";
            this.GoToShortURL.Size = new System.Drawing.Size(190, 22);
            this.GoToShortURL.Text = "Go To Short URL";
            this.GoToShortURL.Click += new System.EventHandler(this.GoToShortURL_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // DeleteSelectedURL
            // 
            this.DeleteSelectedURL.Name = "DeleteSelectedURL";
            this.DeleteSelectedURL.Size = new System.Drawing.Size(190, 22);
            this.DeleteSelectedURL.Text = "Delete Selected URL";
            this.DeleteSelectedURL.Click += new System.EventHandler(this.DeleteSelectedURL_Click);
            // 
            // picBxService
            // 
            this.picBxService.Image = global::ShutupLongLink.Properties.Resources.adfly;
            this.picBxService.Location = new System.Drawing.Point(89, 3);
            this.picBxService.Name = "picBxService";
            this.picBxService.Size = new System.Drawing.Size(280, 120);
            this.picBxService.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBxService.TabIndex = 5;
            this.picBxService.TabStop = false;
            // 
            // mnuItm01
            // 
            this.mnuItm01.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submnuItm01});
            this.mnuItm01.Image = global::ShutupLongLink.Properties.Resources.exit_24px;
            this.mnuItm01.Name = "mnuItm01";
            this.mnuItm01.Size = new System.Drawing.Size(53, 20);
            this.mnuItm01.Text = "&File";
            // 
            // submnuItm01
            // 
            this.submnuItm01.Image = global::ShutupLongLink.Properties.Resources.cancel_20px;
            this.submnuItm01.Name = "submnuItm01";
            this.submnuItm01.Size = new System.Drawing.Size(93, 22);
            this.submnuItm01.Text = "&Exit";
            this.submnuItm01.Click += new System.EventHandler(this.submnuItm01_Click);
            // 
            // mnuItm02
            // 
            this.mnuItm02.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submnuItm03,
            this.submnuItm04,
            this.submnuItm05,
            this.submnuItm06,
            this.toolStripSeparator1,
            this.submnuItm07});
            this.mnuItm02.Image = global::ShutupLongLink.Properties.Resources.service_24px;
            this.mnuItm02.Name = "mnuItm02";
            this.mnuItm02.Size = new System.Drawing.Size(77, 20);
            this.mnuItm02.Text = "&Services";
            // 
            // submnuItm03
            // 
            this.submnuItm03.Name = "submnuItm03";
            this.submnuItm03.Size = new System.Drawing.Size(180, 22);
            this.submnuItm03.Text = "Adfly";
            this.submnuItm03.Click += new System.EventHandler(this.submnuItm03_Click);
            // 
            // submnuItm04
            // 
            this.submnuItm04.Name = "submnuItm04";
            this.submnuItm04.Size = new System.Drawing.Size(180, 22);
            this.submnuItm04.Text = "Shortst";
            this.submnuItm04.Click += new System.EventHandler(this.submnuItm04_Click);
            // 
            // submnuItm05
            // 
            this.submnuItm05.Name = "submnuItm05";
            this.submnuItm05.Size = new System.Drawing.Size(180, 22);
            this.submnuItm05.Text = "R7URL";
            this.submnuItm05.Click += new System.EventHandler(this.submnuItm05_Click);
            // 
            // submnuItm06
            // 
            this.submnuItm06.Name = "submnuItm06";
            this.submnuItm06.Size = new System.Drawing.Size(180, 22);
            this.submnuItm06.Text = "TinyURL";
            this.submnuItm06.Click += new System.EventHandler(this.submnuItm06_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // submnuItm07
            // 
            this.submnuItm07.Image = global::ShutupLongLink.Properties.Resources.api_24px;
            this.submnuItm07.Name = "submnuItm07";
            this.submnuItm07.Size = new System.Drawing.Size(180, 22);
            this.submnuItm07.Text = "API Key Manger";
            this.submnuItm07.Click += new System.EventHandler(this.submnuItm07_Click);
            // 
            // mnuItm03
            // 
            this.mnuItm03.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submnuItm08,
            this.submnuItm09,
            this.submnuItm10});
            this.mnuItm03.Image = global::ShutupLongLink.Properties.Resources.database_administrator_24px;
            this.mnuItm03.Name = "mnuItm03";
            this.mnuItm03.Size = new System.Drawing.Size(123, 20);
            this.mnuItm03.Text = "Mange Database";
            // 
            // submnuItm08
            // 
            this.submnuItm08.Image = global::ShutupLongLink.Properties.Resources.database_export_24px;
            this.submnuItm08.Name = "submnuItm08";
            this.submnuItm08.Size = new System.Drawing.Size(267, 22);
            this.submnuItm08.Text = "BackUp DataBase";
            this.submnuItm08.Click += new System.EventHandler(this.submnuItm08_Click);
            // 
            // submnuItm09
            // 
            this.submnuItm09.Image = global::ShutupLongLink.Properties.Resources.database_restore_24px;
            this.submnuItm09.Name = "submnuItm09";
            this.submnuItm09.Size = new System.Drawing.Size(267, 22);
            this.submnuItm09.Text = "Restore DataBase";
            this.submnuItm09.Click += new System.EventHandler(this.submnuItm09_Click);
            // 
            // submnuItm10
            // 
            this.submnuItm10.Image = global::ShutupLongLink.Properties.Resources.delete_database_24px;
            this.submnuItm10.Name = "submnuItm10";
            this.submnuItm10.Size = new System.Drawing.Size(267, 22);
            this.submnuItm10.Text = "Clear All DataBase Data ( Be Careful )";
            this.submnuItm10.Click += new System.EventHandler(this.submnuItm10_Click);
            // 
            // mnuItm04
            // 
            this.mnuItm04.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submnuItm02});
            this.mnuItm04.Image = global::ShutupLongLink.Properties.Resources.inquiry_24px;
            this.mnuItm04.Name = "mnuItm04";
            this.mnuItm04.Size = new System.Drawing.Size(60, 20);
            this.mnuItm04.Text = "&Help";
            // 
            // submnuItm02
            // 
            this.submnuItm02.Image = global::ShutupLongLink.Properties.Resources.Shutup_Long_Link;
            this.submnuItm02.Name = "submnuItm02";
            this.submnuItm02.Size = new System.Drawing.Size(180, 22);
            this.submnuItm02.Text = "&About";
            this.submnuItm02.Click += new System.EventHandler(this.submnuItm02_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkBxOnTop);
            this.Controls.Add(this.statusStrp);
            this.Controls.Add(this.mnuStrp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuStrp;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shutup Long Link ( Shortner Tool Manger )";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.mnuStrp.ResumeLayout(false);
            this.mnuStrp.PerformLayout();
            this.statusStrp.ResumeLayout(false);
            this.statusStrp.PerformLayout();
            this.grpBxLongURL.ResumeLayout(false);
            this.grpBxLongURL.PerformLayout();
            this.grpBxShortURL.ResumeLayout(false);
            this.grpBxShortURL.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.rightClickLstVw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBxService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrp;
        private System.Windows.Forms.ToolStripMenuItem mnuItm01;
        private System.Windows.Forms.ToolStripMenuItem mnuItm02;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl01;
        private System.Windows.Forms.TextBox txtBxLongURL;
        private System.Windows.Forms.Button btnRunShortner;
        private System.Windows.Forms.TextBox txtBxShortURL;
        private System.Windows.Forms.PictureBox picBxService;
        private System.Windows.Forms.ComboBox cmbBxService;
        private System.Windows.Forms.GroupBox grpBxLongURL;
        private System.Windows.Forms.GroupBox grpBxShortURL;
        private System.Windows.Forms.ToolStripMenuItem mnuItm04;
        private System.Windows.Forms.CheckBox chkBxOnTop;
        private System.Windows.Forms.ToolStripMenuItem submnuItm01;
        private System.Windows.Forms.ToolStripMenuItem submnuItm02;
        private System.Windows.Forms.Button btnCpyShortURL;
        private System.Windows.Forms.Button btnOpenLocalDateBase;
        private System.Windows.Forms.ToolStripMenuItem submnuItm03;
        private System.Windows.Forms.ToolStripMenuItem submnuItm04;
        private System.Windows.Forms.ToolStripMenuItem submnuItm05;
        private System.Windows.Forms.ToolStripMenuItem submnuItm06;
        private System.Windows.Forms.RadioButton rbAdType2;
        private System.Windows.Forms.RadioButton rbAdType1;
        private System.Windows.Forms.Label lblR7URLAlias;
        private System.Windows.Forms.TextBox txtBxR7URLAlias;
        private System.Windows.Forms.ImageList imgLst;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem submnuItm07;
        public System.Windows.Forms.StatusStrip statusStrp;
        private System.Windows.Forms.ToolStripStatusLabel StatusLblResponse;
        private System.Windows.Forms.Timer timrCpyShortURL;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip rightClickLstVw;
        private System.Windows.Forms.ToolStripMenuItem CopyWholeRow;
        private System.Windows.Forms.ToolStripMenuItem CopyLongURL;
        private System.Windows.Forms.ToolStripMenuItem CopyAliasURL;
        private System.Windows.Forms.ToolStripMenuItem CopyNotesURL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem GoToServiceWebSite;
        private System.Windows.Forms.ToolStripMenuItem GoToLongURL;
        private System.Windows.Forms.ToolStripMenuItem GoToShortURL;
        private System.Windows.Forms.ToolStripMenuItem EditeNotesURL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem DeleteSelectedURL;
        private System.Windows.Forms.ToolStripMenuItem CopyShortURL;
        private System.Windows.Forms.ToolStripMenuItem mnuItm03;
        private System.Windows.Forms.ListView lstVw;
        private System.Windows.Forms.ToolStripMenuItem submnuItm08;
        private System.Windows.Forms.ToolStripMenuItem submnuItm09;
        private System.Windows.Forms.ToolStripMenuItem submnuItm10;
    }
}

