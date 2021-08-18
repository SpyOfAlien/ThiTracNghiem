using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace TN
{
    public partial class formCTBT : Form
    {
        private DataTable DS_SV_MON_DA_THI;
        private DataTable DS_LOP_DA_THI;
        public formCTBT()
        {
            InitializeComponent();
        }

        public formCTBT(formMain fm)
        {
            InitializeComponent();

        }

        private void formCTBT_Load(object sender, EventArgs e)
        {
            cmbCS.DataSource = Program.bds_dspm;
            cmbCS.DisplayMember = "TENCS";
            cmbCS.ValueMember = "TENSERVER";
            cmbCS.SelectedIndex = Program.mCoso;

            if(Program.mGroup == "PGV")
            {
                cmbCS.Enabled = true;
            } else
            {
                cmbCS.Enabled = false;
            }

            if (Program.mGroup == "SINHVIEN")
            {
                DS_SV_MON_DA_THI = Program.ExecSqlDataTable(String.Format("EXEC SP_DS_LOP_MON_HOC_SV_DA_THI @MASV={0}", Program.username));

                if (DS_SV_MON_DA_THI.Rows.Count > 0)
                {
                    cmbTenMH.DisplayMember = "TENMH";
                    cmbTenMH.ValueMember = "MAMH";
                    cmbTenMH.DataSource = DS_SV_MON_DA_THI;
                    cmbTenMH.SelectedIndex = 0;

                    cmbLop.DisplayMember = "TENLOP";
                    cmbLop.ValueMember = "MALOP";
                    var lopitem = new[] { new { TENLOP = DS_SV_MON_DA_THI.Rows[0]["TENLOP"], MALOP = DS_SV_MON_DA_THI.Rows[0]["MALOP"] } };
                    cmbLop.DataSource = lopitem;
                    cmbLop.SelectedIndex = 0;
                } else
                {
                    btnXem.Enabled = false;
                }

                cmbSinhVien.DisplayMember = "TENSV";
                cmbSinhVien.ValueMember = "MASV";
                var svItem = new[] { new { TENSV = Program.mHoten, MASV = Program.username } };
                cmbSinhVien.DataSource = svItem;
                cmbSinhVien.SelectedIndex = 0;

                cmbLop.Enabled = cmbSinhVien.Enabled = false;

            } else
            {
                DS_LOP_DA_THI = Program.ExecSqlDataTable("EXEC SP_MH_LOP_DA_THI");

                if (DS_LOP_DA_THI.Rows.Count > 0)
                {
                    cmbLop.DisplayMember = "TENLOP";
                    cmbLop.ValueMember = "MALOP";
                    cmbLop.DataSource = cbLopDataSource(DS_LOP_DA_THI);
                } else
                {
                    MessageBox.Show("Chưa có lớp nào đã thi ở cơ sở hiện tại");
                    cmbLop.Enabled = cmbSinhVien.Enabled = cmbTenMH.Enabled = btnXem.Enabled = false;
                    cmbLop.DataSource = cmbSinhVien.DataSource = cmbTenMH.DataSource = null;
                }
              
            }
        }

        private void cmbCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.IsDisposed == false && cmbCS.SelectedValue != null)
            {
                if (cmbCS.ValueMember != "")
                {
                    if (Program.servername != cmbCS.SelectedValue.ToString())
                    {
                        Program.servername = cmbCS.SelectedValue.ToString();
                    }
                    if (cmbCS.SelectedIndex != Program.mCoso)
                    {
                        Program.login = Program.remoteLogin;
                        Program.password = Program.remotePassword;
                    }
                    else
                    {
                        Program.login = Program.loginDN;
                        Program.password = Program.passwordDN;
                    }
                    if (Program.ketNoi() == 0)
                    {
                        MessageBox.Show("Không thể kết nối", "Lỗi kết nối", MessageBoxButtons.OK);
                        return;
                    }

                    DS_LOP_DA_THI = new DataTable();
                    string strlenh = "EXEC SP_MH_LOP_DA_THI";
                    DS_LOP_DA_THI = Program.ExecSqlDataTable(strlenh);

                    if (DS_LOP_DA_THI.Rows.Count > 0) {

                        cmbLop.DisplayMember = "TENLOP";
                        cmbLop.ValueMember = "MALOP";
                        cmbLop.DataSource = cbLopDataSource(DS_LOP_DA_THI);
                        cmbLop.Enabled = cmbSinhVien.Enabled = cmbTenMH.Enabled = btnXem.Enabled = true;
                    } else
                    {
                        MessageBox.Show("Chưa có lớp nào đã thi ở cơ sở hiện tại");
                        cmbLop.Enabled = cmbSinhVien.Enabled = cmbTenMH.Enabled = btnXem.Enabled = false;
                        cmbLop.DataSource = cmbSinhVien.DataSource = cmbTenMH.DataSource = null;
                    }
                   
                }
            }
        }


        private DataTable cbLopDataSource(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                DataTable lopDT = new DataTable();
                lopDT = dt.AsEnumerable().GroupBy(x => x.Field<string>("MALOP")).Select(y => y.First()).CopyToDataTable();
                return lopDT;
            } else
            {
                return dt;
            }
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLop.SelectedValue != null && Program.mGroup != "SINHVIEN")
            {
                string cmd = String.Format("SELECT MASV, HO + ' ' + TEN AS TENSV FROM SINHVIEN WHERE MALOP='{0}'", cmbLop.SelectedValue.ToString().Trim());
                DataTable svDT = Program.ExecSqlDataTable(cmd);

                if (svDT.Rows.Count > 0)
                {
                    cmbSinhVien.DisplayMember = "TENSV";
                    cmbSinhVien.ValueMember = "MASV";
                    cmbSinhVien.DataSource = svDT;
                }
               
            }
            
        }

        private void cmbSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSinhVien.SelectedValue != null && Program.mGroup != "SINHVIEN")
            {
                string cmd = String.Format("EXEC SP_DS_LOP_MON_HOC_SV_DA_THI @MASV={0}", cmbSinhVien.SelectedValue.ToString().Trim());
                DS_SV_MON_DA_THI = Program.ExecSqlDataTable(cmd);

                if (DS_SV_MON_DA_THI.Rows.Count > 0)
                {
                    cmbTenMH.DisplayMember = "TENMH";
                    cmbTenMH.ValueMember = "MAMH";
                    cmbTenMH.DataSource = DS_SV_MON_DA_THI;
                    cmbTenMH.SelectedIndex = 0;
                    btnXem.Enabled = true;
                } else
                {
                    btnXem.Enabled = false;
                    MessageBox.Show("Sinh viên chưa thi môn học nào");
                }
              
            }
             
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string maSV = cmbSinhVien.SelectedValue.ToString().Trim();
            string maMH = cmbTenMH.SelectedValue.ToString().Trim();

            string monHoc = cmbTenMH.Text.Trim();
            string hoTen = cmbSinhVien.Text.Trim();
            string lop = cmbLop.Text.Trim();


            string cmd = String.Format("EXEC SP_XEMKETQUA @MASV='{0}', @MAMH='{1}'", maSV, maMH);
            DataTable ctbtDT = Program.ExecSqlDataTable(cmd);

            TN.rpt_XemChiTietBaiThi obj = new TN.rpt_XemChiTietBaiThi();

            obj.SetDataSource(ctbtDT);
            obj.SetParameterValue("MASV", maSV);
            obj.SetParameterValue("MAMH", maMH);
            obj.SetParameterValue("TENMH", monHoc);
            obj.SetParameterValue("LOP", lop);
            obj.SetParameterValue("HOTEN", hoTen);

            crystalReportViewer.ReportSource = obj;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
