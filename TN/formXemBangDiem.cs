using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN
{
    public partial class formXemBangDiem : Form
    {
        private static DataTable dsLOP_MH_DA_THI;
        public formXemBangDiem()
        {
            InitializeComponent();
        }

        private void formXemBangDiem_Load(object sender, EventArgs e)
        {
            cmbCS.DataSource = Program.bds_dspm;
            cmbCS.DisplayMember = "TENCS";
            cmbCS.ValueMember = "TENSERVER";
            cmbCS.SelectedIndex = Program.mCoso;

            dsLOP_MH_DA_THI = new DataTable();
            string strlenh = "EXEC SP_MH_LOP_DA_THI";
            dsLOP_MH_DA_THI = Program.ExecSqlDataTable(strlenh);

            cmbTenLop.DisplayMember = "TENLOP";
            cmbTenLop.ValueMember = "MALOP";
            cmbTenLop.DataSource = cbLopDataSource(dsLOP_MH_DA_THI);

            if (Program.mGroup != "PGV")
            {
                cmbCS.Enabled = false;
            }
            else
            {
                cmbCS.Enabled = true;
            }
            cmbTenLop.Enabled = cmbTenMH.Enabled = btnXem.Enabled = true;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            TN.rptXemBangDiem obj;
            obj = new TN.rptXemBangDiem();

            string lenh;
            lenh = "SP_IN_BANG_DIEM N'" + cmbTenLop.SelectedValue.ToString() + "'" + ",'" + cmbTenMH.SelectedValue.ToString() + "'";
            DataTable myTable;
            myTable = Program.ExecSqlDataTable(lenh);
   
            obj.SetDataSource(myTable);
            obj.SetParameterValue("MALOP", cmbTenLop.SelectedValue.ToString());
            obj.SetParameterValue("MAMH", cmbTenMH.SelectedValue.ToString());
            crystalReportViewer.ReportSource = obj;
        }

        private void cmbCS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCS.SelectedValue != null)
            {
                if (cmbCS.ValueMember != "")
                {
                    if (Program.servername != cmbCS.SelectedValue.ToString())
                    {
                        Program.servername = cmbCS.SelectedValue.ToString();
                    }
                    if (cmbCS.SelectedIndex != Program.mCoso)
                    {
                        Program.username = Program.remoteLogin;
                        Program.password = Program.remotePassword;
                    }
                    else
                    {
                        Program.username = Program.loginDN;
                        Program.password = Program.passwordDN;
                    }
                    if (Program.ketNoi() == 0)
                    {
                        MessageBox.Show("Không thể kết nối", "Lỗi kết nối", MessageBoxButtons.OK);
                        return;
                    }

                    dsLOP_MH_DA_THI = new DataTable();
                    string strlenh = "EXEC SP_MH_LOP_DA_THI";
                    dsLOP_MH_DA_THI = Program.ExecSqlDataTable(strlenh);

                    cmbTenLop.DataSource = dsLOP_MH_DA_THI;
                    cmbTenLop.DisplayMember = "TENLOP";
                    cmbTenLop.ValueMember = "MALOP";
                    cmbTenLop.SelectedIndex = -1;
                    cmbTenMH.SelectedIndex = -1;
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MAMH", typeof(string));
            dt.Columns.Add("TENMH", typeof(string));

            if (dsLOP_MH_DA_THI.Rows.Count > 0 && this.cmbTenLop.SelectedValue != null)
            {
                for (int i = 0; i < dsLOP_MH_DA_THI.Rows.Count; i++)
                {
                    string maLop = dsLOP_MH_DA_THI.Rows[i]["MALOP"].ToString().Trim();
                    string maLopDangChon = this.cmbTenLop.SelectedValue.ToString().Trim();
                    if (maLop == maLopDangChon) {
                        DataRow dr = dt.NewRow();

                        dr["MAMH"] = dsLOP_MH_DA_THI.Rows[i]["MAMH"];
                        dr["TENMH"] = dsLOP_MH_DA_THI.Rows[i]["TENMH"];

                        dt.Rows.Add(dr);
                    }
                    
                }
            }

            cmbTenMH.DataSource = dt;
            cmbTenMH.DisplayMember = "TENMH";
            cmbTenMH.ValueMember = "MAMH";
        }

        private DataTable cbLopDataSource(DataTable dt)
        {
            DataTable lopDT = new DataTable();

            lopDT = dt.AsEnumerable().GroupBy(x => x.Field<string>("MALOP")).Select(y => y.First()).CopyToDataTable();
            return lopDT;
        }
    }
}
