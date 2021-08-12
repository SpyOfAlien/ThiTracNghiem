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
using DevExpress.XtraReports.Parameters;

namespace TN
{
    public partial class formChonMon : Form
    {

        private string monhoc;
        private DataTable dtMonHoc;
        public formChonMon()
        {
            InitializeComponent();
        }

        private void formChonMon_Load(object sender, EventArgs e)
        {

            string cmd = String.Format("EXEC SP_DS_MON_HOC_SV @MASV='{0}'", Program.username);
            DataTable tb = Program.ExecSqlDataTable(cmd);
            this.dtMonHoc = tb;
            this.cbMH.DataSource = tb;

            this.cbMH.DisplayMember = "TENMH";
            this.cbMH.ValueMember = "MAMH";

            this.monhoc = cbMH.SelectedValue.ToString().Trim();
        }

        private void cbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.monhoc = cbMH.SelectedValue.ToString().Trim();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string tenMH = layTenMH();
            RP_XEMKETQUA rp = new RP_XEMKETQUA(tenMH);

            rp.Parameters["MASV"].Value = Program.username;
            rp.Parameters["MAMH"].Value = this.monhoc;
            rp.RequestParameters = false;
            rp.ShowPreview();
            this.Hide();
        }

        private string layTenMH()
        {
            return this.dtMonHoc.Rows[this.cbMH.SelectedIndex]["TENMH"].ToString();
        }
    }
}
