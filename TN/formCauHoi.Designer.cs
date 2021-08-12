using System;

namespace TN
{
    partial class formCauHoi
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
            System.Windows.Forms.Label nOIDUNGLabel;
            System.Windows.Forms.Label dAPANLabel;
            System.Windows.Forms.Label lOAICAUHOILabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mATRINHDOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCauHoi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barControl = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnLamMoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoanTac = new DevExpress.XtraBars.BarButtonItem();
            this.btnDong = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.dS = new TN.DS();
            this.bdsCH = new System.Windows.Forms.BindingSource(this.components);
            this.cAUHOITableAdapter = new TN.DSTableAdapters.CAUHOITableAdapter();
            this.tableAdapterManager = new TN.DSTableAdapters.TableAdapterManager();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lUACHONGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsLC = new System.Windows.Forms.BindingSource(this.components);
            this.LuaChonGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDCH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cAUHOIGridControl = new DevExpress.XtraGrid.GridControl();
            this.CauHoiGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDCH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNOIDUNG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAICAUHOI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDAPAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDA = new System.Windows.Forms.ComboBox();
            this.cbLoaiCH = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbMaTD = new System.Windows.Forms.ComboBox();
            this.tRINHDOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbMaMH = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtND = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.labelD = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.bdsTD = new System.Windows.Forms.BindingSource(this.components);
            this.tRINHDOTableAdapter = new TN.DSTableAdapters.TRINHDOTableAdapter();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.mONHOCTableAdapter = new TN.DSTableAdapters.MONHOCTableAdapter();
            this.lUACHONTableAdapter = new TN.DSTableAdapters.LUACHONTableAdapter();
            nOIDUNGLabel = new System.Windows.Forms.Label();
            dAPANLabel = new System.Windows.Forms.Label();
            lOAICAUHOILabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mATRINHDOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCH)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lUACHONGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuaChonGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAUHOIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CauHoiGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            this.SuspendLayout();
            // 
            // nOIDUNGLabel
            // 
            nOIDUNGLabel.AutoSize = true;
            nOIDUNGLabel.Location = new System.Drawing.Point(7, 25);
            nOIDUNGLabel.Name = "nOIDUNGLabel";
            nOIDUNGLabel.Size = new System.Drawing.Size(50, 13);
            nOIDUNGLabel.TabIndex = 0;
            nOIDUNGLabel.Text = "Nội dung";
            // 
            // dAPANLabel
            // 
            dAPANLabel.AutoSize = true;
            dAPANLabel.Location = new System.Drawing.Point(273, 141);
            dAPANLabel.Name = "dAPANLabel";
            dAPANLabel.Size = new System.Drawing.Size(42, 13);
            dAPANLabel.TabIndex = 4;
            dAPANLabel.Text = "Đáp án";
            // 
            // lOAICAUHOILabel
            // 
            lOAICAUHOILabel.AutoSize = true;
            lOAICAUHOILabel.Location = new System.Drawing.Point(250, 22);
            lOAICAUHOILabel.Name = "lOAICAUHOILabel";
            lOAICAUHOILabel.Size = new System.Drawing.Size(65, 13);
            lOAICAUHOILabel.TabIndex = 10;
            lOAICAUHOILabel.Text = "Loại câu hỏi";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(249, 59);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(66, 13);
            mAMHLabel.TabIndex = 11;
            mAMHLabel.Text = "Mã môn học";
            // 
            // mATRINHDOLabel
            // 
            mATRINHDOLabel.AutoSize = true;
            mATRINHDOLabel.Location = new System.Drawing.Point(254, 102);
            mATRINHDOLabel.Name = "mATRINHDOLabel";
            mATRINHDOLabel.Size = new System.Drawing.Size(61, 13);
            mATRINHDOLabel.TabIndex = 12;
            mATRINHDOLabel.Text = "Mã trình độ";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.barControl,
            this.bar3});
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
            this.btnDong});
            this.barManager1.MainMenu = this.barControl;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // barControl
            // 
            this.barControl.BarName = "Main menu";
            this.barControl.DockCol = 0;
            this.barControl.DockRow = 0;
            this.barControl.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barControl.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLamMoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHoanTac),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDong)});
            this.barControl.OptionsBar.MultiLine = true;
            this.barControl.OptionsBar.UseWholeRow = true;
            this.barControl.Text = "Main menu";
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
            this.btnHoanTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoanTac_ItemClick);
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
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(978, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 386);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(978, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 341);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(978, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 341);
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
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsCH
            // 
            this.bdsCH.DataMember = "CAUHOI";
            this.bdsCH.DataSource = this.dS;
            // 
            // cAUHOITableAdapter
            // 
            this.cAUHOITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CAUHOITableAdapter = this.cAUHOITableAdapter;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lUACHONGridControl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cAUHOIGridControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.81525F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.18475F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 341);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // lUACHONGridControl
            // 
            this.lUACHONGridControl.DataSource = this.bdsLC;
            this.lUACHONGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lUACHONGridControl.Location = new System.Drawing.Point(492, 3);
            this.lUACHONGridControl.MainView = this.LuaChonGridView;
            this.lUACHONGridControl.MenuManager = this.barManager1;
            this.lUACHONGridControl.Name = "lUACHONGridControl";
            this.lUACHONGridControl.Size = new System.Drawing.Size(483, 140);
            this.lUACHONGridControl.TabIndex = 3;
            this.lUACHONGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.LuaChonGridView});
            // 
            // bdsLC
            // 
            this.bdsLC.DataMember = "FK_LUACHON_CAUHOI";
            this.bdsLC.DataSource = this.bdsCH;
            // 
            // LuaChonGridView
            // 
            this.LuaChonGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDLC,
            this.colTENLC,
            this.colNOIDUNG1,
            this.colIDCH1});
            this.LuaChonGridView.GridControl = this.lUACHONGridControl;
            this.LuaChonGridView.Name = "LuaChonGridView";
            // 
            // colIDLC
            // 
            this.colIDLC.Caption = "ID";
            this.colIDLC.FieldName = "IDLC";
            this.colIDLC.Name = "colIDLC";
            this.colIDLC.OptionsColumn.AllowEdit = false;
            this.colIDLC.OptionsColumn.ReadOnly = true;
            this.colIDLC.Visible = true;
            this.colIDLC.VisibleIndex = 0;
            this.colIDLC.Width = 57;
            // 
            // colTENLC
            // 
            this.colTENLC.Caption = "Tên";
            this.colTENLC.FieldName = "TENLC";
            this.colTENLC.Name = "colTENLC";
            this.colTENLC.OptionsColumn.AllowEdit = false;
            this.colTENLC.OptionsColumn.ReadOnly = true;
            this.colTENLC.Visible = true;
            this.colTENLC.VisibleIndex = 1;
            this.colTENLC.Width = 46;
            // 
            // colNOIDUNG1
            // 
            this.colNOIDUNG1.Caption = "Nội dung";
            this.colNOIDUNG1.FieldName = "NOIDUNG";
            this.colNOIDUNG1.Name = "colNOIDUNG1";
            this.colNOIDUNG1.OptionsColumn.AllowEdit = false;
            this.colNOIDUNG1.OptionsColumn.ReadOnly = true;
            this.colNOIDUNG1.Visible = true;
            this.colNOIDUNG1.VisibleIndex = 2;
            this.colNOIDUNG1.Width = 519;
            // 
            // colIDCH1
            // 
            this.colIDCH1.Caption = "ID câu hỏi";
            this.colIDCH1.FieldName = "IDCH";
            this.colIDCH1.Name = "colIDCH1";
            this.colIDCH1.OptionsColumn.AllowEdit = false;
            this.colIDCH1.OptionsColumn.ReadOnly = true;
            this.colIDCH1.Visible = true;
            this.colIDCH1.VisibleIndex = 3;
            this.colIDCH1.Width = 63;
            // 
            // cAUHOIGridControl
            // 
            this.cAUHOIGridControl.DataSource = this.bdsCH;
            this.cAUHOIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cAUHOIGridControl.Location = new System.Drawing.Point(3, 3);
            this.cAUHOIGridControl.MainView = this.CauHoiGridView;
            this.cAUHOIGridControl.MenuManager = this.barManager1;
            this.cAUHOIGridControl.Name = "cAUHOIGridControl";
            this.cAUHOIGridControl.Size = new System.Drawing.Size(483, 140);
            this.cAUHOIGridControl.TabIndex = 0;
            this.cAUHOIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CauHoiGridView});
            // 
            // CauHoiGridView
            // 
            this.CauHoiGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDCH,
            this.colNOIDUNG,
            this.colLOAICAUHOI,
            this.colDAPAN,
            this.colMAMH,
            this.colMATRINHDO,
            this.colMAGV});
            this.CauHoiGridView.GridControl = this.cAUHOIGridControl;
            this.CauHoiGridView.Name = "CauHoiGridView";
            // 
            // colIDCH
            // 
            this.colIDCH.Caption = "ID";
            this.colIDCH.FieldName = "IDCH";
            this.colIDCH.Name = "colIDCH";
            this.colIDCH.OptionsColumn.AllowEdit = false;
            this.colIDCH.OptionsColumn.ReadOnly = true;
            this.colIDCH.Visible = true;
            this.colIDCH.VisibleIndex = 0;
            this.colIDCH.Width = 70;
            // 
            // colNOIDUNG
            // 
            this.colNOIDUNG.Caption = "Nội dung";
            this.colNOIDUNG.FieldName = "NOIDUNG";
            this.colNOIDUNG.Name = "colNOIDUNG";
            this.colNOIDUNG.OptionsColumn.AllowEdit = false;
            this.colNOIDUNG.OptionsColumn.ReadOnly = true;
            this.colNOIDUNG.Visible = true;
            this.colNOIDUNG.VisibleIndex = 1;
            this.colNOIDUNG.Width = 253;
            // 
            // colLOAICAUHOI
            // 
            this.colLOAICAUHOI.AppearanceCell.Options.UseTextOptions = true;
            this.colLOAICAUHOI.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colLOAICAUHOI.Caption = "Loại";
            this.colLOAICAUHOI.FieldName = "LOAICAUHOI";
            this.colLOAICAUHOI.Name = "colLOAICAUHOI";
            this.colLOAICAUHOI.OptionsColumn.AllowEdit = false;
            this.colLOAICAUHOI.OptionsColumn.ReadOnly = true;
            this.colLOAICAUHOI.Visible = true;
            this.colLOAICAUHOI.VisibleIndex = 2;
            this.colLOAICAUHOI.Width = 39;
            // 
            // colDAPAN
            // 
            this.colDAPAN.AppearanceCell.Options.UseTextOptions = true;
            this.colDAPAN.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.colDAPAN.Caption = "Đáp án";
            this.colDAPAN.FieldName = "DAPAN";
            this.colDAPAN.Name = "colDAPAN";
            this.colDAPAN.OptionsColumn.AllowEdit = false;
            this.colDAPAN.OptionsColumn.ReadOnly = true;
            this.colDAPAN.Visible = true;
            this.colDAPAN.VisibleIndex = 3;
            this.colDAPAN.Width = 48;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.OptionsColumn.ReadOnly = true;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 4;
            this.colMAMH.Width = 81;
            // 
            // colMATRINHDO
            // 
            this.colMATRINHDO.Caption = "Mã trình độ";
            this.colMATRINHDO.FieldName = "MATRINHDO";
            this.colMATRINHDO.Name = "colMATRINHDO";
            this.colMATRINHDO.OptionsColumn.AllowEdit = false;
            this.colMATRINHDO.OptionsColumn.ReadOnly = true;
            this.colMATRINHDO.Visible = true;
            this.colMATRINHDO.VisibleIndex = 5;
            this.colMATRINHDO.Width = 82;
            // 
            // colMAGV
            // 
            this.colMAGV.Caption = "Mã giảng viên";
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.OptionsColumn.AllowEdit = false;
            this.colMAGV.OptionsColumn.ReadOnly = true;
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 6;
            this.colMAGV.Width = 112;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDA);
            this.groupBox1.Controls.Add(this.cbLoaiCH);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(mATRINHDOLabel);
            this.groupBox1.Controls.Add(this.cbMaTD);
            this.groupBox1.Controls.Add(mAMHLabel);
            this.groupBox1.Controls.Add(this.cbMaMH);
            this.groupBox1.Controls.Add(lOAICAUHOILabel);
            this.groupBox1.Controls.Add(this.txtND);
            this.groupBox1.Controls.Add(dAPANLabel);
            this.groupBox1.Controls.Add(nOIDUNGLabel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 189);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Câu hỏi";
            // 
            // cbDA
            // 
            this.cbDA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCH, "DAPAN", true));
            this.cbDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDA.FormattingEnabled = true;
            this.cbDA.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cbDA.Location = new System.Drawing.Point(322, 138);
            this.cbDA.Name = "cbDA";
            this.cbDA.Size = new System.Drawing.Size(149, 21);
            this.cbDA.TabIndex = 19;
            this.cbDA.SelectedIndexChanged += new System.EventHandler(this.cbDA_SelectedIndexChanged);
            // 
            // cbLoaiCH
            // 
            this.cbLoaiCH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCH, "LOAICAUHOI", true));
            this.cbLoaiCH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiCH.FormattingEnabled = true;
            this.cbLoaiCH.Items.AddRange(new object[] {
            "WH",
            "YN"});
            this.cbLoaiCH.Location = new System.Drawing.Point(321, 19);
            this.cbLoaiCH.Name = "cbLoaiCH";
            this.cbLoaiCH.Size = new System.Drawing.Size(150, 21);
            this.cbLoaiCH.TabIndex = 18;
            this.cbLoaiCH.SelectedIndexChanged += new System.EventHandler(this.cbLoaiCH_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(391, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbMaTD
            // 
            this.cbMaTD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCH, "MATRINHDO", true));
            this.cbMaTD.DataSource = this.tRINHDOBindingSource;
            this.cbMaTD.DisplayMember = "MATRINHDO";
            this.cbMaTD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaTD.FormattingEnabled = true;
            this.cbMaTD.Location = new System.Drawing.Point(322, 99);
            this.cbMaTD.Name = "cbMaTD";
            this.cbMaTD.Size = new System.Drawing.Size(150, 21);
            this.cbMaTD.TabIndex = 13;
            this.cbMaTD.ValueMember = "MATRINHDO";
            // 
            // tRINHDOBindingSource
            // 
            this.tRINHDOBindingSource.DataMember = "TRINHDO";
            this.tRINHDOBindingSource.DataSource = this.dS;
            // 
            // cbMaMH
            // 
            this.cbMaMH.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCH, "MAMH", true));
            this.cbMaMH.DataSource = this.mONHOCBindingSource;
            this.cbMaMH.DisplayMember = "MAMH";
            this.cbMaMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaMH.FormattingEnabled = true;
            this.cbMaMH.Location = new System.Drawing.Point(322, 56);
            this.cbMaMH.Name = "cbMaMH";
            this.cbMaMH.Size = new System.Drawing.Size(150, 21);
            this.cbMaMH.TabIndex = 12;
            this.cbMaMH.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // txtND
            // 
            this.txtND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsCH, "NOIDUNG", true));
            this.txtND.Location = new System.Drawing.Point(63, 25);
            this.txtND.Multiline = true;
            this.txtND.Name = "txtND";
            this.txtND.Size = new System.Drawing.Size(168, 129);
            this.txtND.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtD);
            this.groupBox2.Controls.Add(this.txtC);
            this.groupBox2.Controls.Add(this.txtB);
            this.groupBox2.Controls.Add(this.txtA);
            this.groupBox2.Controls.Add(this.labelD);
            this.groupBox2.Controls.Add(this.labelC);
            this.groupBox2.Controls.Add(this.labelB);
            this.groupBox2.Controls.Add(this.labelA);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(492, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(483, 189);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đáp án";
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(61, 159);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(413, 32);
            this.txtD.TabIndex = 11;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(61, 112);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(413, 32);
            this.txtC.TabIndex = 10;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(61, 63);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(413, 32);
            this.txtB.TabIndex = 9;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(61, 21);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(413, 32);
            this.txtA.TabIndex = 8;
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(26, 164);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(15, 13);
            this.labelD.TabIndex = 3;
            this.labelD.Text = "D";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(27, 121);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(14, 13);
            this.labelC.TabIndex = 2;
            this.labelC.Text = "C";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(27, 77);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(14, 13);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "B";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(27, 33);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(14, 13);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "A";
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
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.dS;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // lUACHONTableAdapter
            // 
            this.lUACHONTableAdapter.ClearBeforeFill = true;
            // 
            // formCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 406);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "formCauHoi";
            this.Text = "formCauHoi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCH)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lUACHONGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LuaChonGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cAUHOIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CauHoiGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tRINHDOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CauHoiGridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LuaChonGridView_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar barControl;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnLuu;
        private DevExpress.XtraBars.BarButtonItem btnLamMoi;
        private DevExpress.XtraBars.BarButtonItem btnHoanTac;
        private DevExpress.XtraBars.BarButtonItem btnDong;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private System.Windows.Forms.BindingSource bdsCH;
        private DS dS;
        private DSTableAdapters.CAUHOITableAdapter cAUHOITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl cAUHOIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView CauHoiGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCH;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAICAUHOI;
        private DevExpress.XtraGrid.Columns.GridColumn colDAPAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMATRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtND;
        private System.Windows.Forms.ComboBox cbMaTD;
        private System.Windows.Forms.ComboBox cbMaMH;
        private System.Windows.Forms.BindingSource bdsTD;
        private DSTableAdapters.TRINHDOTableAdapter tRINHDOTableAdapter;
        private System.Windows.Forms.BindingSource bdsMH;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource tRINHDOBindingSource;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.BindingSource bdsLC;
        private DSTableAdapters.LUACHONTableAdapter lUACHONTableAdapter;
        private DevExpress.XtraGrid.GridControl lUACHONGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView LuaChonGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLC;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLC;
        private DevExpress.XtraGrid.Columns.GridColumn colNOIDUNG1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDCH1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cbDA;
        private System.Windows.Forms.ComboBox cbLoaiCH;
    }
}