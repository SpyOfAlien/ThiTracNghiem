namespace TN
{
    partial class formChonMon
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
            this.cbMH = new System.Windows.Forms.ComboBox();
            this.bdsDSMHSV = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new TN.DS();
            this.btnXem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sP_DS_MON_HOC_SVTableAdapter = new TN.DSTableAdapters.SP_DS_MON_HOC_SVTableAdapter();
            this.sPDSMONHOCSVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSMHSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPDSMONHOCSVBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMH
            // 
            this.cbMH.FormattingEnabled = true;
            this.cbMH.Location = new System.Drawing.Point(52, 80);
            this.cbMH.Margin = new System.Windows.Forms.Padding(4);
            this.cbMH.Name = "cbMH";
            this.cbMH.Size = new System.Drawing.Size(216, 27);
            this.cbMH.TabIndex = 0;
            this.cbMH.SelectedIndexChanged += new System.EventHandler(this.cbMH_SelectedIndexChanged);
            // 
            // bdsDSMHSV
            // 
            this.bdsDSMHSV.DataMember = "SP_DS_MON_HOC_SV";
            this.bdsDSMHSV.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(95, 139);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(112, 36);
            this.btnXem.TabIndex = 1;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn môn học";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 48);
            this.panel1.TabIndex = 3;
            // 
            // sP_DS_MON_HOC_SVTableAdapter
            // 
            this.sP_DS_MON_HOC_SVTableAdapter.ClearBeforeFill = true;
            // 
            // sPDSMONHOCSVBindingSource
            // 
            this.sPDSMONHOCSVBindingSource.DataMember = "SP_DS_MON_HOC_SV";
            this.sPDSMONHOCSVBindingSource.DataSource = this.dS;
            // 
            // formChonMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 205);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.cbMH);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formChonMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formChonMon";
            this.Load += new System.EventHandler(this.formChonMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsDSMHSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPDSMONHOCSVBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMH;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bdsDSMHSV;
        private DS dS;
        private DSTableAdapters.SP_DS_MON_HOC_SVTableAdapter sP_DS_MON_HOC_SVTableAdapter;
        private System.Windows.Forms.BindingSource sPDSMONHOCSVBindingSource;
    }
}