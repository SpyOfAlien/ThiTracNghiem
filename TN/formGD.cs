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
    public partial class formGD : Form
    {
        public formGD()
        {
            InitializeComponent();
        }
        Boolean check = false;
        private void gIANGDAYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGD.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void formGD_Load(object sender, EventArgs e)
        {
   
            cbCoSo.DataSource = Program.bds_dspm;
            cbCoSo.DisplayMember = "TENCS";
            cbCoSo.ValueMember = "TENSERVER";
            cbCoSo.SelectedIndex = Program.mCoso;

            dS.EnforceConstraints = false;
            this.gIANGDAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGDAYTableAdapter.Fill(this.dS.GIANGDAY);

            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.dS.DANGKY);

            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            cbMaLop.DataSource = dS.LOP;
            cbMaLop.DisplayMember = "MALOP";
            cbMaLop.ValueMember = "MALOP";

            cbMaMH.DataSource = dS.MONHOC;
            cbMaMH.DisplayMember = "MAMH";
            cbMaMH.ValueMember = "MAMH";

            cbMaGV.DataSource = dS.GIANGVIEN;
            cbMaGV.DisplayMember = "MAGV";
            cbMaGV.ValueMember = "MAGV";

            gbGD.Enabled = false;

            if (Program.mGroup != "KHOA")
            {
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLuu.Enabled = btnHoanTac.Enabled = btnLamMoi.Enabled = false;
            }
            if (Program.mGroup != "PGV")
            {
                cbCoSo.Enabled = false;
            }


        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check = false;
            bdsGD.AddNew();

            cbMaGV.SelectedIndex = 0;
            cbMaGV.SelectedIndex = 1;
            cbMaGV.SelectedIndex = 0;

            cbMaLop.SelectedIndex = 0;
            cbMaLop.SelectedIndex = 1;
            cbMaLop.SelectedIndex = 0;

            cbMaMH.SelectedIndex = 0;
            cbMaMH.SelectedIndex = 1;
            cbMaMH.SelectedIndex = 0;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnHoanTac.Enabled = btnLamMoi.Enabled = false;
            gbGD.Enabled = true;
            cbMaMH.Enabled = cbMaLop.Enabled = cbMaGV.Enabled = true;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (check)
            {
                if (cbMaGV.Text.Trim() == "")
                {
                    MessageBox.Show("Giảng viên không được để trống!");
                    cbMaGV.Focus();
                }
                else
                {
                    this.bdsGD.EndEdit();
                    bdsGD.ResetCurrentItem();
                    this.gIANGDAYTableAdapter.Update(this.dS.GIANGDAY);
                    MessageBox.Show("Sửa giảng dạy thành công!", "Notification", MessageBoxButtons.OK);

                    btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnHoanTac.Enabled = btnLamMoi.Enabled = true;
                    cbMaLop.Enabled = cbMaMH.Enabled = true;
                    gbGD.Enabled = false;
                }
            }
            else
            {
                if (cbMaMH.Text.Trim() == "")
                {
                    MessageBox.Show("Mã môn học không được để trống!");
                    cbMaMH.Focus();
                }
                else if (cbMaGV.Text.Trim() == "")
                {
                    MessageBox.Show("giảng viên không được để trống!");
                    cbMaGV.Focus();
                }
                else if (cbMaLop.Text.Trim() == "")
                {
                    MessageBox.Show("Mã lớp không được để trống!");
                    cbMaLop.Focus();
                }
                else
                {
                    SqlDataReader myReader1;
                    String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_KTGD]" +
                            "@MALOP = N'" + cbMaLop.Text.Trim() + "',@MAMH = N'" + cbMaMH.Text.Trim() + "' SELECT  'Return Value' = @return_value";
                    myReader1 = Program.ExecSqlDataReader(strlenh1);

                    if (myReader1 == null) return;

                    myReader1.Read();
                    int value1 = myReader1.GetInt32(0);

                    myReader1.Close();
                    if (value1 == 1)
                    {
                        MessageBox.Show("Trùng mã lớp và mã môn học. Hãy nhập lại.");
                    }
                    else
                    {

                        this.bdsGD.EndEdit();
                        bdsGD.ResetCurrentItem();
                        this.gIANGDAYTableAdapter.Update(this.dS.GIANGDAY);
                        MessageBox.Show("Thêm giảng dạy thành công!", "Notification", MessageBoxButtons.OK);

                        btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnHoanTac.Enabled = btnLamMoi.Enabled = true;
                        gbGD.Enabled = false;

                    }
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnHoanTac.Enabled = btnLamMoi.Enabled = false;
            gbGD.Enabled = true;
            cbMaLop.Enabled = cbMaMH.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDK.Count > 0)
            {
                MessageBox.Show("Gảng dạy này đã được đăng kí thi. KhÔng thể xóa!", "", MessageBoxButtons.OK);
                return;
            }
            else
           if (MessageBox.Show("Bạn có thực sự muốn xóa giảng dạy này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    bdsGD.RemoveCurrent();
                    this.gIANGDAYTableAdapter.Update(this.dS.GIANGDAY);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa giảng dạy!\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void cbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCoSo.SelectedValue != null)
            {
                if (cbCoSo.ValueMember != "")
                {
                    if (Program.servername != cbCoSo.SelectedValue.ToString())
                    {
                        Program.servername = cbCoSo.SelectedValue.ToString();
                    }
                    if (cbCoSo.SelectedIndex != Program.mCoso)
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
                    else
                    {
                        dS.EnforceConstraints = false;
                        this.gIANGDAYTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.gIANGDAYTableAdapter.Fill(this.dS.GIANGDAY);

                        this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.dANGKYTableAdapter.Fill(this.dS.DANGKY);

                        this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);

                        this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Fill(this.dS.LOP);

                    }
                }
            }
        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.bdsGD.CancelEdit();
            if (!check)
            {
                this.bdsGD.RemoveCurrent();
            } else
            {
                this.gIANGDAYTableAdapter.Fill(this.dS.GIANGDAY);
                cbMaLop.Enabled = cbMaMH.Enabled = true;
            }

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnHoanTac.Enabled = btnLamMoi.Enabled = true;
            gbGD.Enabled = false;
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.gIANGDAYTableAdapter.Fill(this.dS.GIANGDAY);
        }
    }
}
