namespace TN
{
    partial class formDK
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
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label iDGDLabel;
            System.Windows.Forms.Label mATRINHDOLabel;
            System.Windows.Forms.Label sOCAULabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDK));
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCoSo = new System.Windows.Forms.ComboBox();
            this.dS = new TN.DS();
            this.bdsDK = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new TN.DSTableAdapters.DANGKYTableAdapter();
            this.tableAdapterManager = new TN.DSTableAdapters.TableAdapterManager();
            this.dANGKYGridControl = new DevExpress.XtraGrid.GridControl();
            this.dkGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gbDK = new System.Windows.Forms.GroupBox();
            this.dpNgayThi = new System.Windows.Forms.DateTimePicker();
            this.btnHuy = new System.Windows.Forms.Button();
            this.numSoCau = new System.Windows.Forms.NumericUpDown();
            this.cbTD = new System.Windows.Forms.ComboBox();
            this.cbGD = new System.Windows.Forms.ComboBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.bdsThi = new System.Windows.Forms.BindingSource(this.components);
            this.tHITableAdapter = new TN.DSTableAdapters.THITableAdapter();
            this.bdsTD = new System.Windows.Forms.BindingSource(this.components);
            this.tRINHDOTableAdapter = new TN.DSTableAdapters.TRINHDOTableAdapter();
            this.bdsGD = new System.Windows.Forms.BindingSource(this.components);
            this.gIANGDAYTableAdapter = new TN.DSTableAdapters.GIANGDAYTableAdapter();
            mANVLabel = new System.Windows.Forms.Label();
            iDGDLabel = new System.Windows.Forms.Label();
            mATRINHDOLabel = new System.Windows.Forms.Label();
            sOCAULabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKYGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dkGridView)).BeginInit();
            this.gbDK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoCau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGD)).BeginInit();
            this.SuspendLayout();
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(682, 110);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(90, 19);
            mANVLabel.TabIndex = 4;
            mANVLabel.Text = "Mã nhân viên";
            // 
            // iDGDLabel
            // 
            iDGDLabel.AutoSize = true;
            iDGDLabel.Location = new System.Drawing.Point(135, 50);
            iDGDLabel.Name = "iDGDLabel";
            iDGDLabel.Size = new System.Drawing.Size(51, 19);
            iDGDLabel.TabIndex = 5;
            iDGDLabel.Text = "ID GD";
            // 
            // mATRINHDOLabel
            // 
            mATRINHDOLabel.AutoSize = true;
            mATRINHDOLabel.Location = new System.Drawing.Point(429, 46);
            mATRINHDOLabel.Name = "mATRINHDOLabel";
            mATRINHDOLabel.Size = new System.Drawing.Size(80, 19);
            mATRINHDOLabel.TabIndex = 6;
            mATRINHDOLabel.Text = "Mã trình độ";
            // 
            // sOCAULabel
            // 
            sOCAULabel.AutoSize = true;
            sOCAULabel.Location = new System.Drawing.Point(721, 45);
            sOCAULabel.Name = "sOCAULabel";
            sOCAULabel.Size = new System.Drawing.Size(51, 19);
            sOCAULabel.TabIndex = 8;
            sOCAULabel.Text = "Số câu";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(116, 104);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(60, 19);
            nGAYTHILabel.TabIndex = 11;
            nGAYTHILabel.Text = "Ngày thi";
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar5});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnLuu,
            this.btnLamMoi,
            this.barButtonItem6,
            this.btnHoanTac,
            this.btnDong,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLamMoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHoanTac),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDong)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 8;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.LargeImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.LargeImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.LargeImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnLuu
            // 
            this.btnLuu.Caption = "Lưu";
            this.btnLuu.Id = 3;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.LargeImage")));
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLuu_ItemClick);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Caption = "Làm mới";
            this.btnLamMoi.Id = 4;
            this.btnLamMoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.Image")));
            this.btnLamMoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.ImageOptions.LargeImage")));
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnLamMoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLamMoi_ItemClick);
            // 
            // btnHoanTac
            // 
            this.btnHoanTac.Caption = "Hoàn tác";
            this.btnHoanTac.Id = 6;
            this.btnHoanTac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.Image")));
            this.btnHoanTac.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHoanTac.ImageOptions.LargeImage")));
            this.btnHoanTac.Name = "btnHoanTac";
            this.btnHoanTac.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnDong
            // 
            this.btnDong.Caption = "Đóng";
            this.btnDong.Id = 7;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.LargeImage")));
            this.btnDong.Name = "btnDong";
            this.btnDong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDong_ItemClick);
            // 
            // bar5
            // 
            this.bar5.BarName = "Status bar";
            this.bar5.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar5.OptionsBar.AllowQuickCustomization = false;
            this.bar5.OptionsBar.DrawDragBorder = false;
            this.bar5.OptionsBar.UseWholeRow = true;
            this.bar5.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(978, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 721);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(978, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 697);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(978, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 697);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Đóng";
            this.barButtonItem6.Id = 5;
            this.barButtonItem6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonItem6.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbCoSo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 57);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "CƠ SỞ:";
            // 
            // cbCoSo
            // 
            this.cbCoSo.FormattingEnabled = true;
            this.cbCoSo.Location = new System.Drawing.Point(250, 14);
            this.cbCoSo.Name = "cbCoSo";
            this.cbCoSo.Size = new System.Drawing.Size(431, 27);
            this.cbCoSo.TabIndex = 0;
            this.cbCoSo.SelectedIndexChanged += new System.EventHandler(this.cbCoSo_SelectedIndexChanged);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDK
            // 
            this.bdsDK.DataMember = "DANGKY";
            this.bdsDK.DataSource = this.dS;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = this.dANGKYTableAdapter;
            this.tableAdapterManager.GIANGDAYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LUACHONTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.NV_PGVTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.THITableAdapter = null;
            this.tableAdapterManager.TRINHDOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dANGKYGridControl
            // 
            this.dANGKYGridControl.DataSource = this.bdsDK;
            this.dANGKYGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dANGKYGridControl.Location = new System.Drawing.Point(0, 81);
            this.dANGKYGridControl.MainView = this.dkGridView;
            this.dANGKYGridControl.MenuManager = this.barManager1;
            this.dANGKYGridControl.Name = "dANGKYGridControl";
            this.dANGKYGridControl.Size = new System.Drawing.Size(978, 153);
            this.dANGKYGridControl.TabIndex = 8;
            this.dANGKYGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dkGridView});
            // 
            // dkGridView
            // 
            this.dkGridView.GridControl = this.dANGKYGridControl;
            this.dkGridView.Name = "dkGridView";
            // 
            // gbDK
            // 
            this.gbDK.Controls.Add(nGAYTHILabel);
            this.gbDK.Controls.Add(this.dpNgayThi);
            this.gbDK.Controls.Add(this.btnHuy);
            this.gbDK.Controls.Add(sOCAULabel);
            this.gbDK.Controls.Add(this.numSoCau);
            this.gbDK.Controls.Add(mATRINHDOLabel);
            this.gbDK.Controls.Add(this.cbTD);
            this.gbDK.Controls.Add(iDGDLabel);
            this.gbDK.Controls.Add(this.cbGD);
            this.gbDK.Controls.Add(mANVLabel);
            this.gbDK.Controls.Add(this.txtMaNV);
            this.gbDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDK.Location = new System.Drawing.Point(0, 234);
            this.gbDK.Name = "gbDK";
            this.gbDK.Size = new System.Drawing.Size(978, 487);
            this.gbDK.TabIndex = 9;
            this.gbDK.TabStop = false;
            // 
            // dpNgayThi
            // 
            this.dpNgayThi.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsDK, "NGAYTHI", true));
            this.dpNgayThi.Location = new System.Drawing.Point(191, 100);
            this.dpNgayThi.Name = "dpNgayThi";
            this.dpNgayThi.Size = new System.Drawing.Size(340, 26);
            this.dpNgayThi.TabIndex = 12;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(505, 165);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(120, 38);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // numSoCau
            // 
            this.numSoCau.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsDK, "SOCAU", true));
            this.numSoCau.Location = new System.Drawing.Point(788, 43);
            this.numSoCau.Name = "numSoCau";
            this.numSoCau.Size = new System.Drawing.Size(120, 26);
            this.numSoCau.TabIndex = 9;
            // 
            // cbTD
            // 
            this.cbTD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDK, "MATRINHDO", true));
            this.cbTD.FormattingEnabled = true;
            this.cbTD.Location = new System.Drawing.Point(525, 42);
            this.cbTD.Name = "cbTD";
            this.cbTD.Size = new System.Drawing.Size(144, 27);
            this.cbTD.TabIndex = 7;
            // 
            // cbGD
            // 
            this.cbGD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDK, "IDGD", true));
            this.cbGD.FormattingEnabled = true;
            this.cbGD.Location = new System.Drawing.Point(191, 47);
            this.cbGD.Name = "cbGD";
            this.cbGD.Size = new System.Drawing.Size(175, 27);
            this.cbGD.TabIndex = 6;
            // 
            // txtMaNV
            // 
            this.txtMaNV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDK, "MANV", true));
            this.txtMaNV.Location = new System.Drawing.Point(788, 104);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(120, 26);
            this.txtMaNV.TabIndex = 5;
            // 
            // bdsThi
            // 
            this.bdsThi.DataMember = "FK_THI_DANGKY";
            this.bdsThi.DataSource = this.bdsDK;
            // 
            // tHITableAdapter
            // 
            this.tHITableAdapter.ClearBeforeFill = true;
            // 
            // bdsTD
            // 
            this.bdsTD.DataMember = "TRINHDO";
            this.bdsTD.DataSource = this.dS;
            // 
            // tRINHDOTableAdapter
            // 
            this.tRINHDOTableAdapter.ClearBeforeFill = true;
            // 
            // bdsGD
            // 
            this.bdsGD.DataMember = "GIANGDAY";
            this.bdsGD.DataSource = this.dS;
            // 
            // gIANGDAYTableAdapter
            // 
            this.gIANGDAYTableAdapter.ClearBeforeFill = true;
            // 
            // formDK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(978, 741);
            this.Controls.Add(this.gbDK);
            this.Controls.Add(this.dANGKYGridControl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formDK";
            this.Text = "formDK";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formDK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANGKYGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dkGridView)).EndInit();
            this.gbDK.ResumeLayout(false);
            this.gbDK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoCau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.BindingSource bdsDK;
        private DS dS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCoSo;
        private DSTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox gbDK;
        private System.Windows.Forms.NumericUpDown numSoCau;
        private System.Windows.Forms.ComboBox cbTD;
        private System.Windows.Forms.ComboBox cbGD;
        private System.Windows.Forms.TextBox txtMaNV;
        private DevExpress.XtraGrid.GridControl dANGKYGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView dkGridView;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.BindingSource bdsThi;
        private DSTableAdapters.THITableAdapter tHITableAdapter;
        private System.Windows.Forms.BindingSource bdsTD;
        private DSTableAdapters.TRINHDOTableAdapter tRINHDOTableAdapter;
        private System.Windows.Forms.BindingSource bdsGD;
        private DSTableAdapters.GIANGDAYTableAdapter gIANGDAYTableAdapter;
        private System.Windows.Forms.DateTimePicker dpNgayThi;
    }
}