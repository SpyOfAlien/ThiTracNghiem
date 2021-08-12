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
    public partial class formLopSV : Form
    {
        public formLopSV()
        {
            InitializeComponent();
        }
        Boolean check = false;

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLop.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void formLopSV_Load(object sender, EventArgs e)
        {

            cmdCoSo.DataSource = Program.bds_dspm;
            cmdCoSo.DisplayMember = "TENCS";
            cmdCoSo.ValueMember = "TENSERVER";
            cmdCoSo.SelectedIndex = Program.mCoso;



            if (Program.mGroup != "PGV")
            {
                cmdCoSo.Enabled = false;
            }
            else
            {
                cmdCoSo.Enabled = true;
                btnThem.Enabled
                    = btnSua.Enabled
                    = btnXoa.Enabled
                    = btnLamMoi.Enabled
                    = btnHoanTac.Enabled
                    = btnLuu.Enabled = false;
            }

            dS.EnforceConstraints = false;

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.tHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.tHITableAdapter.Fill(this.dS.THI);

            gbSVField.Enabled = false;

        }

        private void cmdCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmdCoSo.SelectedValue != null)
            {
                if (cmdCoSo.ValueMember != "")
                {
                    if (Program.servername != cmdCoSo.SelectedValue.ToString())
                    {
                        Program.servername = cmdCoSo.SelectedValue.ToString();
                    }
                    if (cmdCoSo.SelectedIndex != Program.mCoso)
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
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Fill(this.dS.LOP);
                        this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    }
                }
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check = false;
            bdsSV.AddNew();
            txtMaSV.Focus();
            txtMaLop.Text = lopGridView.GetFocusedRowCellValue("MALOP").ToString().Trim();
            dpNgaySinh.Value = DateTime.Now;

            txtMaLop.Enabled = false;
            gbSVField.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = false;

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (check)
            {
                if (txtHo.Text.Trim() == "")
                {
                    MessageBox.Show("Họ sinh viên không được để trống!");
                    txtHo.Focus();
                }
                else if (txtTen.Text.Trim() == "")
                {
                    MessageBox.Show("Tên sinh viên không được để trống!");
                    txtTen.Focus();
                }
                else
                {
                    this.bdsSV.EndEdit();
                    bdsSV.ResetCurrentItem();
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    MessageBox.Show("Cập nhật sinh viên thành công!", "Notification", MessageBoxButtons.OK);
                }

            }
            else
            {
                if (txtMaSV.Text.Trim() == "")
                {
                    MessageBox.Show("Mã sinh viên không được để trống!");
                    txtMaSV.Focus();
                }
                else if (txtHo.Text.Trim() == "")
                {
                    MessageBox.Show("Họ sinh viên không được để trống!");
                    txtHo.Focus();
                }
                else if (txtTen.Text.Trim() == "")
                {
                    MessageBox.Show("Tên sinh viên không được để trống!");
                    txtTen.Focus();
                }
                else
                {
                    SqlDataReader myReader1;
                    String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_KTMASV]" +
                            "@MASV = N'" + txtMaSV.Text + "' SELECT  'Return Value' = @return_value";

                    myReader1 = Program.ExecSqlDataReader(strlenh1);

                    if (myReader1 == null) return;

                    myReader1.Read();
                    int value1 = myReader1.GetInt32(0);

                    myReader1.Close();
                    if (value1 == 1)
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại. Hãy nhập lại.");
                        txtMaSV.Focus();
                    }

                    else
                    {
                        this.bdsSV.EndEdit();
                        bdsSV.ResetCurrentItem();
                        this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                        this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                        MessageBox.Show("Cập nhật sinh viên thành công!", "Notification", MessageBoxButtons.OK);
                    }
                }
            }

            gbSVField.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = true;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            check = true;
            txtMaLop.Enabled = txtMaSV.Enabled = true;
            txtMaLop.Text = lopGridView.GetFocusedRowCellValue("MALOP").ToString().Trim();

            txtHo.Focus();
            txtMaLop.Enabled = txtMaSV.Enabled = false;
            gbSVField.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLamMoi.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSV.Count > 0)
            {
                if (bdsThi.Count > 0)
                {
                    MessageBox.Show("Không thể xóa sinh viên đã làm bài thi!", "", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show("Bạn có thực sự muốn xóa sinh viên này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        bdsSV.RemoveCurrent();
                        this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa sinh viên!\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Lớp này chưa có sinh viên.", "", MessageBoxButtons.OK);
                return;
            }

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Fill(this.dS.LOP);
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }
        
    }
}
