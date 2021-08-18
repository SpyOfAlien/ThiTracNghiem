using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace TN
{
    public partial class formDangNhap : Form
    {

        public formDangNhap()
        {
            InitializeComponent();
        }

        private void formDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tNDataSet.GET_SUBSCRIBERS' table. You can move, or remove it, as needed.
            this.gET_SUBSCRIBERSTableAdapter.Fill(this.tNDataSet.GET_SUBSCRIBERS);
            this.cbLogin.SelectedIndex = 1;
            this.cbLogin.SelectedIndex = 0;

        }

        private void cbLogin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.IsDisposed == false && this.cbLogin.SelectedValue != null)
            {
                Program.servername = this.cbLogin.SelectedValue.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtDangNhap.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản đăng nhập không được trống", "Báo lỗi đăng nhập", MessageBoxButtons.OK);
                txtDangNhap.Focus();
                return;
            }

            Program.login = txtDangNhap.Text;
            Program.password = txtPass.Text;

           
            if (Program.ketNoi() == 0) return;

            Program.bds_dspm =  this.bds_DSPM;
            Program.mCoso = cbLogin.SelectedIndex;
            Program.username = txtDangNhap.Text;
            Program.loginDN = Program.username;
            Program.passwordDN = Program.password;

            SqlDataReader myReader;

            String existCmd = "EXEC SP_CHECK_USER_TONTAI '" + txtDangNhap.Text + "'";
            myReader = Program.ExecSqlDataReader(existCmd);
            if (myReader == null) return;
            if ( myReader.HasRows == false)
            {
                MessageBox.Show("Tài khoản không tồn tại!!");
                return;
            }

            myReader.Close();

            String strlenh = "EXEC SP_DANGNHAP '" + txtDangNhap.Text + "'";
            myReader = Program.ExecSqlDataReader(strlenh);
            if (myReader == null) return;
            myReader.Read();

            Program.username = myReader.GetString(0).Trim();
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Login khong co quyen truy cap csdl");
                return;
            }
            Program.mHoten = myReader.GetString(1).Trim();
            Program.mGroup = myReader.GetString(2).Trim();
            if (myReader.FieldCount == 4)
            {

                Program.mKhoa = myReader.GetString(3).Trim();
            }
            myReader.Close();
            Program.conn.Close();
           

            this.Hide();
            formMain frm = new formMain();
            frm.MADN.Text = getMaDN(Program.mGroup, Program.username);
            frm.HOTEN.Text = "Họ tên: " + Program.mHoten;
            frm.NHOM.Text = "Nhóm: " + Program.mGroup;
            frm.Show();
            frm.FormClosed += FormMain_Closed;
        }

        private void FormMain_Closed(object sender, FormClosedEventArgs e)
        {
            if (cbLogin.SelectedIndex != -1)
            {
                this.cbLogin.SelectedIndex = 0;
                this.txtDangNhap.Text = this.txtPass.Text = "";
            }
        }

        private string getMaDN(string group, string user) 
        {
            String maDn = "";

            switch(group)
            {
                case "PGV":
                    maDn = "Mã nhân viên: " + user;
                    break;

                case "KHOA":
                case "GIANGVIEN":
                    maDn = "Mã giảng viên: " + user;
                    break;

                case "SINHVIEN":
                    maDn = "Mã sinh viên: " + user;
                    break;

            }

            return maDn;

        }
    }
}
