namespace TN
{
    partial class formLichThi
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
            System.Windows.Forms.Label mAMHLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThi = new System.Windows.Forms.Button();
            this.dS = new TN.DS();
            this.sP_LAY_LICH_THIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LAY_LICH_THITableAdapter = new TN.DSTableAdapters.SP_LAY_LICH_THITableAdapter();
            this.tableAdapterManager1 = new TN.DSTableAdapters.TableAdapterManager();
            this.sP_LAY_LICH_THI_THUBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_LAY_LICH_THI_THUTableAdapter = new TN.DSTableAdapters.SP_LAY_LICH_THI_THUTableAdapter();
            this.pnSV = new System.Windows.Forms.Panel();
            this.sP_LAY_LICH_THIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewSV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnGV = new System.Windows.Forms.Panel();
            this.sP_LAY_LICH_THI_THUGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDDK1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAU1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMATRINHDO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            mAMHLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_LICH_THIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_LICH_THI_THUBindingSource)).BeginInit();
            this.pnSV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_LICH_THIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSV)).BeginInit();
            this.pnGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_LICH_THI_THUGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGV)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(334, 57);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(62, 19);
            mAMHLabel.TabIndex = 1;
            mAMHLabel.Text = "MAMH:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 927);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 134);
            this.panel1.TabIndex = 0;
            // 
            // btnThi
            // 
            this.btnThi.Location = new System.Drawing.Point(589, 36);
            this.btnThi.Name = "btnThi";
            this.btnThi.Size = new System.Drawing.Size(119, 39);
            this.btnThi.TabIndex = 0;
            this.btnThi.Text = "Vào phòng thi";
            this.btnThi.UseVisualStyleBackColor = true;
            this.btnThi.Click += new System.EventHandler(this.btnThi_Click);
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_LAY_LICH_THIBindingSource
            // 
            this.sP_LAY_LICH_THIBindingSource.DataMember = "SP_LAY_LICH_THI";
            this.sP_LAY_LICH_THIBindingSource.DataSource = this.dS;
            // 
            // sP_LAY_LICH_THITableAdapter
            // 
            this.sP_LAY_LICH_THITableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.CAUHOITableAdapter = null;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.COSOTableAdapter = null;
            this.tableAdapterManager1.CT_BAITHITableAdapter = null;
            this.tableAdapterManager1.DANGKYTableAdapter = null;
            this.tableAdapterManager1.GIANGDAYTableAdapter = null;
            this.tableAdapterManager1.GIANGVIENTableAdapter = null;
            this.tableAdapterManager1.KHOATableAdapter = null;
            this.tableAdapterManager1.LOPTableAdapter = null;
            this.tableAdapterManager1.LUACHONTableAdapter = null;
            this.tableAdapterManager1.MONHOCTableAdapter = null;
            this.tableAdapterManager1.NV_PGVTableAdapter = null;
            this.tableAdapterManager1.SINHVIENTableAdapter = null;
            this.tableAdapterManager1.THITableAdapter = null;
            this.tableAdapterManager1.TRINHDOTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = TN.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_LAY_LICH_THI_THUBindingSource
            // 
            this.sP_LAY_LICH_THI_THUBindingSource.DataMember = "SP_LAY_LICH_THI_THU";
            this.sP_LAY_LICH_THI_THUBindingSource.DataSource = this.dS;
            // 
            // sP_LAY_LICH_THI_THUTableAdapter
            // 
            this.sP_LAY_LICH_THI_THUTableAdapter.ClearBeforeFill = true;
            // 
            // pnSV
            // 
            this.pnSV.Controls.Add(this.sP_LAY_LICH_THIGridControl);
            this.pnSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSV.Location = new System.Drawing.Point(0, 0);
            this.pnSV.Name = "pnSV";
            this.pnSV.Size = new System.Drawing.Size(1337, 455);
            this.pnSV.TabIndex = 1;
            // 
            // sP_LAY_LICH_THIGridControl
            // 
            this.sP_LAY_LICH_THIGridControl.DataSource = this.sP_LAY_LICH_THIBindingSource;
            this.sP_LAY_LICH_THIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_LAY_LICH_THIGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_LAY_LICH_THIGridControl.MainView = this.gridViewSV;
            this.sP_LAY_LICH_THIGridControl.Name = "sP_LAY_LICH_THIGridControl";
            this.sP_LAY_LICH_THIGridControl.Size = new System.Drawing.Size(1337, 455);
            this.sP_LAY_LICH_THIGridControl.TabIndex = 0;
            this.sP_LAY_LICH_THIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSV});
            // 
            // gridViewSV
            // 
            this.gridViewSV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDDK,
            this.colNGAYTHI,
            this.colSOCAU,
            this.colMATRINHDO,
            this.colMAMH,
            this.colMAGV,
            this.colMALOP});
            this.gridViewSV.GridControl = this.sP_LAY_LICH_THIGridControl;
            this.gridViewSV.Name = "gridViewSV";
            // 
            // colIDDK
            // 
            this.colIDDK.FieldName = "IDDK";
            this.colIDDK.Name = "colIDDK";
            this.colIDDK.Visible = true;
            this.colIDDK.VisibleIndex = 0;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 1;
            // 
            // colSOCAU
            // 
            this.colSOCAU.FieldName = "SOCAU";
            this.colSOCAU.Name = "colSOCAU";
            this.colSOCAU.Visible = true;
            this.colSOCAU.VisibleIndex = 2;
            // 
            // colMATRINHDO
            // 
            this.colMATRINHDO.FieldName = "MATRINHDO";
            this.colMATRINHDO.Name = "colMATRINHDO";
            this.colMATRINHDO.Visible = true;
            this.colMATRINHDO.VisibleIndex = 3;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 4;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 5;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 6;
            // 
            // pnGV
            // 
            this.pnGV.Controls.Add(this.sP_LAY_LICH_THI_THUGridControl);
            this.pnGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnGV.Location = new System.Drawing.Point(0, 455);
            this.pnGV.Name = "pnGV";
            this.pnGV.Size = new System.Drawing.Size(1337, 472);
            this.pnGV.TabIndex = 2;
            // 
            // sP_LAY_LICH_THI_THUGridControl
            // 
            this.sP_LAY_LICH_THI_THUGridControl.DataSource = this.sP_LAY_LICH_THI_THUBindingSource;
            this.sP_LAY_LICH_THI_THUGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_LAY_LICH_THI_THUGridControl.Location = new System.Drawing.Point(0, 0);
            this.sP_LAY_LICH_THI_THUGridControl.MainView = this.gridViewGV;
            this.sP_LAY_LICH_THI_THUGridControl.Name = "sP_LAY_LICH_THI_THUGridControl";
            this.sP_LAY_LICH_THI_THUGridControl.Size = new System.Drawing.Size(1337, 472);
            this.sP_LAY_LICH_THI_THUGridControl.TabIndex = 0;
            this.sP_LAY_LICH_THI_THUGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGV});
            // 
            // gridViewGV
            // 
            this.gridViewGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDDK1,
            this.colNGAYTHI1,
            this.colSOCAU1,
            this.colMATRINHDO1,
            this.colMAMH1,
            this.colMAGV1,
            this.colMALOP1});
            this.gridViewGV.GridControl = this.sP_LAY_LICH_THI_THUGridControl;
            this.gridViewGV.Name = "gridViewGV";
            // 
            // colIDDK1
            // 
            this.colIDDK1.FieldName = "IDDK";
            this.colIDDK1.Name = "colIDDK1";
            this.colIDDK1.Visible = true;
            this.colIDDK1.VisibleIndex = 0;
            // 
            // colNGAYTHI1
            // 
            this.colNGAYTHI1.FieldName = "NGAYTHI";
            this.colNGAYTHI1.Name = "colNGAYTHI1";
            this.colNGAYTHI1.Visible = true;
            this.colNGAYTHI1.VisibleIndex = 1;
            // 
            // colSOCAU1
            // 
            this.colSOCAU1.FieldName = "SOCAU";
            this.colSOCAU1.Name = "colSOCAU1";
            this.colSOCAU1.Visible = true;
            this.colSOCAU1.VisibleIndex = 2;
            // 
            // colMATRINHDO1
            // 
            this.colMATRINHDO1.FieldName = "MATRINHDO";
            this.colMATRINHDO1.Name = "colMATRINHDO1";
            this.colMATRINHDO1.Visible = true;
            this.colMATRINHDO1.VisibleIndex = 3;
            // 
            // colMAMH1
            // 
            this.colMAMH1.FieldName = "MAMH";
            this.colMAMH1.Name = "colMAMH1";
            this.colMAMH1.Visible = true;
            this.colMAMH1.VisibleIndex = 4;
            // 
            // colMAGV1
            // 
            this.colMAGV1.FieldName = "MAGV";
            this.colMAGV1.Name = "colMAGV1";
            this.colMAGV1.Visible = true;
            this.colMAGV1.VisibleIndex = 5;
            // 
            // colMALOP1
            // 
            this.colMALOP1.FieldName = "MALOP";
            this.colMALOP1.Name = "colMALOP1";
            this.colMALOP1.Visible = true;
            this.colMALOP1.VisibleIndex = 6;
            // 
            // formLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.pnGV);
            this.Controls.Add(this.pnSV);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formLichThi";
            this.Text = "Lịch thi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formLichThi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_LICH_THIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_LICH_THI_THUBindingSource)).EndInit();
            this.pnSV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_LICH_THIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSV)).EndInit();
            this.pnGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sP_LAY_LICH_THI_THUGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGV)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button btnThi;
        private DS dS;
        private System.Windows.Forms.BindingSource sP_LAY_LICH_THIBindingSource;
        private DSTableAdapters.SP_LAY_LICH_THITableAdapter sP_LAY_LICH_THITableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource sP_LAY_LICH_THI_THUBindingSource;
        private DSTableAdapters.SP_LAY_LICH_THI_THUTableAdapter sP_LAY_LICH_THI_THUTableAdapter;
        private System.Windows.Forms.Panel pnSV;
        private System.Windows.Forms.Panel pnGV;
        private DevExpress.XtraGrid.GridControl sP_LAY_LICH_THIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSV;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDK;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAU;
        private DevExpress.XtraGrid.Columns.GridColumn colMATRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.GridControl sP_LAY_LICH_THI_THUGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGV;
        private DevExpress.XtraGrid.Columns.GridColumn colIDDK1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAU1;
        private DevExpress.XtraGrid.Columns.GridColumn colMATRINHDO1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV1;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP1;
    }

    #endregion
}