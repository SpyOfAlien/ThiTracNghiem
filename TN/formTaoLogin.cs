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

namespace TN
{
    public partial class formTaoLogin : Form
    {
        private static DataTable dsTen;
        public formTaoLogin()
        {
            InitializeComponent();
        }

        private void formTaoLogin_Load(object sender, EventArgs e)
        {
            layDanhSachTen(true);
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            if (cmbTen.Text.Trim() == "")
            {
                MessageBox.Show("Nhóm quyên không được để trống. Kiểm tra lại !!!", "Thông báo");
            }
            else if (cmbTen.Text.Trim() == "")
            {
                if (Program.mGroup == "PGV")
                {
                    MessageBox.Show("Bạn chưa chọn nhân viên cần tạo tài khoản !!!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn giảng viên cần tạo tài khoản !!!", "Thông báo");
                }
            }
            else if (txtTenLogin.Text.Trim() == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtTenLogin.Focus();
            }
            else if (txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Mật khẩu không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtPass.Focus();
            }
            else if (txtConfirmPass.Text.Trim() == "")
            {
                MessageBox.Show("Xác nhận khẩu không được để trống. Kiểm tra lại !!!", "Thông báo");
                txtConfirmPass.Focus();
            }
            else if (txtPass.Text.Trim().Equals(txtConfirmPass.Text.Trim()) == false)
            {
                MessageBox.Show("Mật khẩu phải trùng nhau. Kiểm tra lại !!!", "Thông báo");
                txtConfirmPass.Focus();
            }
            else
            {
                SqlDataReader myReader;
                String strlenh = "DECLARE @return_value int EXEC @return_value = [dbo].[SP_TAOLOGIN]"
                    + "@LGNAME = N'" + txtTenLogin.Text.Trim() + "',"
                    + "@PASS = N'" + txtPass.Text.Trim() + "',"
                    + "@USERNAME = N'" + cmbTen.SelectedValue.ToString().Trim() + "',"
                    + "@ROLE = N'" + cmbNhom.Text.ToString().Trim() + "'"
                    + "SELECT  'Return Value' = @return_value";

                myReader = Program.ExecSqlDataReader(strlenh);

                if (myReader == null) return;

                myReader.Read();
                int value = myReader.GetInt32(0);

                myReader.Close();
                if (value == 1 || value == 2)
                {
                    MessageBox.Show("UserName bị trùng.");
                    return;
                }
                else if (value == 0)
                {
                    MessageBox.Show("Tạo thành công!");
                    txtTenLogin.Text = txtPass.Text = txtConfirmPass.Text = "";
                    layDanhSachTen();
                }
            }
        }

        private void layDanhSachTen(bool isLoad = false)
        {
            if (Program.mGroup == "PGV")
            {
                lbTen.Text = "Mã nhân viên";
                cmbNhom.Items.Add("PGV");
                cmbNhom.SelectedItem = "PGV";

                dsTen = new DataTable();
                string strlenh = "EXEC SP_DS_NV_CHUACOLOGIN";

                dsTen = Program.ExecSqlDataTable(strlenh);

                if (dsTen.Rows.Count > 0)
                {
                    cmbTen.DataSource = dsTen;
                    cmbTen.DisplayMember = "HOTEN";
                    cmbTen.ValueMember = "MANV";
                } else
                {
                    MessageBox.Show("Tất cả nhân viên đã tạo tài khoản. Vui lòng kiểm tra lại", "Thông báo");
                    cmbTen.Enabled = txtTenLogin.Enabled = txtPass.Enabled = txtConfirmPass.Enabled = btnTao.Enabled = false;
                }

            }
            else if (Program.mGroup == "KHOA")
            {
                lbTen.Text = "Mã giảng viên";
                cmbNhom.Items.Add("KHOA");
                cmbNhom.Items.Add("GIANGVIEN");
                if (isLoad) cmbNhom.SelectedItem = "KHOA";

                dsTen = new DataTable();
                string strlenh = "EXEC SP_DS_GV_CHUACOLOGIN @MAGV=N'" + Program.username + "'";
                dsTen = Program.ExecSqlDataTable(strlenh);

                if (dsTen.Rows.Count > 0)
                {
                    cmbTen.DataSource = dsTen;
                    cmbTen.DisplayMember = "HOTEN";
                    cmbTen.ValueMember = "MAGV";
                }
                else
                {
                    MessageBox.Show("Tất cả giảng viên đã tạo tài khoản. Vui lòng kiểm tra lại", "Thông báo");
                    cmbTen.Enabled = txtTenLogin.Enabled = txtPass.Enabled = txtConfirmPass.Enabled = btnTao.Enabled = false;
                }
            }
        }
    }
}
