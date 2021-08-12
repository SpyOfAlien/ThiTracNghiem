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
    public partial class formKhoa : Form
    {
        public formKhoa()
        {
            InitializeComponent();
        }
        string macs = "";
        string makhoa = "";
        Boolean checkButtonSua = false;
        Boolean khoa = true;
        Boolean choosed = false;
        int vitri = 0;

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKhoa.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void formKhoa_Load(object sender, EventArgs e)
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
                    = btnLuu.Enabled
                    = btnSua.Enabled = false;
            }

            dS.EnforceConstraints = false;

            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);

            this.gIANGDAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGDAYTableAdapter.Fill(this.dS.GIANGDAY);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            macs = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
            gbLop.Enabled = gbKhoa.Enabled = false;

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
                        this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
                        this.kHOATableAdapter.Fill(this.dS.KHOA);
                        this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.lOPTableAdapter.Fill(this.dS.LOP);

                        macs = ((DataRowView)bdsKhoa[0])["MACS"].ToString();
                    }
                }
            }
        }

        private void luuKhoa()
        {
            if (checkButtonSua)
            {
                if (txtTenKhoa.Text.Trim() == "")
                {
                    MessageBox.Show("Tên khoa không được để trống!");
                    txtTenKhoa.Focus();
                }
                this.bdsKhoa.EndEdit();
                bdsKhoa.ResetCurrentItem();
                this.kHOATableAdapter.Update(this.dS.KHOA);
                this.kHOATableAdapter.Fill(this.dS.KHOA);
                MessageBox.Show("Cập nhật khoa thành công!", "Notification", MessageBoxButtons.OK);

            }
            else
            {
                if (txtTenKhoa.Text.Trim() == "")
                {
                    MessageBox.Show("Mã khoa không được để trống!");
                    txtTenKhoa.Focus();
                }
                else if (txtTenKhoa.Text.Trim() == "")
                {
                    MessageBox.Show("Tên khoa không được để trống!");
                    txtTenKhoa.Focus();
                }
                else if (txtMaCoSo.Text.Trim() == "")
                {
                    MessageBox.Show("Mã cơ sở không được để trống!");
                    txtMaCoSo.Focus();
                }
                else
                {
                    SqlDataReader myReader1;
                    String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_KTMAKH]" +
                            "@MAKH = N'" + txtTenKhoa.Text + "' SELECT  'Return Value' = @return_value";

                    myReader1 = Program.ExecSqlDataReader(strlenh1);

                    if (myReader1 == null) return;

                    myReader1.Read();
                    int value1 = myReader1.GetInt32(0);

                    myReader1.Close();
                    if (value1 == 1)
                    {
                        MessageBox.Show("Mã khoa đã tồn tại. Hãy nhập lại.");
                        txtTenKhoa.Focus();
                    }

                    else
                    {
                        this.bdsKhoa.EndEdit();
                        bdsKhoa.ResetCurrentItem();
                        this.kHOATableAdapter.Update(this.dS.KHOA);
                        this.kHOATableAdapter.Fill(this.dS.KHOA);
                        MessageBox.Show("Cập nhật khoa thành công!", "Notification", MessageBoxButtons.OK);
                    }
                }
            }

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
            gbKhoa.Enabled = false;
        }

        private void luuLop()
        {
            if (checkButtonSua)
            {
                if (txtTenLop.Text.Trim() == "")
                {
                    MessageBox.Show("Tên lớp không được để trống!");
                    txtTenLop.Focus();
                }
                this.bdsLop.EndEdit();
                bdsLop.ResetCurrentItem();
                this.lOPTableAdapter.Update(this.dS.LOP);
                this.lOPTableAdapter.Fill(this.dS.LOP);
                MessageBox.Show("Cập nhật lớp thành công!", "Notification", MessageBoxButtons.OK);

                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
                gbLop.Enabled = false;
                
            }
            else
            {
                if (txtMaLop.Text.Trim() == "")
                {
                    MessageBox.Show("Mã lớp không được để trống!");
                    txtMaLop.Focus();
                }
                else if (txtTenLop.Text.Trim() == "")
                {
                    MessageBox.Show("Tên lớp không được để trống!");
                    txtTenLop.Focus();
                }
                else if (txtMaKhoaLop.Text.Trim() == "")
                {
                    MessageBox.Show("Mã khoa không được để trống!");
                    txtMaKhoaLop.Focus();
                }
                else
                {
                    SqlDataReader myReader1;
                    String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_KTMALOP]" +
                            "@MALOP = N'" + txtMaLop.Text + "' SELECT  'Return Value' = @return_value";

                    myReader1 = Program.ExecSqlDataReader(strlenh1);

                    if (myReader1 == null) return;

                    myReader1.Read();
                    int value1 = myReader1.GetInt32(0);

                    myReader1.Close();
                    if (value1 == 1)
                    {
                        MessageBox.Show("Mã lớp đã tồn tại. Hãy nhập lại.");
                        txtMaLop.Focus();
                    }

                    else
                    {
                        this.bdsLop.EndEdit();
                        bdsLop.ResetCurrentItem();
                        this.lOPTableAdapter.Update(this.dS.LOP);
                        this.lOPTableAdapter.Fill(this.dS.LOP);
                        MessageBox.Show("Cập nhật lớp thành công!", "Notification", MessageBoxButtons.OK);

                        btnThem.Enabled =  btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = true;
                        gbLop.Enabled = false;
                    }
                }
            }

        }

        private void xoa()
        {
            if (khoa)
            {
                if (bdsLop.Count > 0)
                {
                    MessageBox.Show("Không thể xóa khoa đã có lớp!", "", MessageBoxButtons.OK);
                    return;
                }
                if (bdsGV.Count > 0)
                {
                    MessageBox.Show("Không thể xóa khoa đã có giáo viên!", "", MessageBoxButtons.OK);
                    return;
                }


                if (MessageBox.Show("Bạn có thực sự muốn xóa khoa này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        bdsKhoa.RemoveCurrent();

                        this.kHOATableAdapter.Update(this.dS.KHOA);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa khoa đã có giáo viên!", "", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
            else
            {
                if (bdsLop.Count > 0)
                {
                    if (bdsSV.Count > 0)
                    {
                        MessageBox.Show("Không thể xóa lớp đã có sinh viên!", "", MessageBoxButtons.OK);
                        return;
                    }
                    if (bdsGD.Count > 0)
                    {
                        MessageBox.Show("Không thể xóa lớp đã được giảng dạy!", "", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có thực sự muốn xóa lớp này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            try
                            {
                                bdsLop.RemoveCurrent();
                                this.lOPTableAdapter.Update(this.dS.LOP);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Lỗi xóa Lớp!", "", MessageBoxButtons.OK);
                                return;
                            }
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Danh sách lớp của khoa này rỗng!", "", MessageBoxButtons.OK);
                    return;
                }

            }
        }


        private void btnDongKh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.kHOATableAdapter.Fill(this.dS.KHOA);
                this.lOPTableAdapter.Fill(this.dS.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formConfirm cff = new formConfirm("Bạn muốn thêm khoa hay lớp");
          
            cff.DataSend += Cff_DataSend;
            cff.ShowDialog();

            if (choosed)
            {
                checkButtonSua = false;
                if (khoa == true)
                {
                    
                    checkButtonSua = false;
                    vitri = bdsKhoa.Position;
                    bdsKhoa.AddNew();
                    txtMaCoSo.Text = macs;
                    txtTenKhoa.Focus();
                    txtMaCoSo.Enabled = false;
                    
                    gbLop.Enabled = false;
                    gbKhoa.Enabled = true;

                }
                else
                {
                    vitri = bdsLop.Position;
                    bdsLop.AddNew();
                    txtMaKhoaLop.Text = txtMaKhoa.Text;
                    txtTenLop.Focus();
                    txtMaKhoaLop.Enabled = false;

                    gbKhoa.Enabled = false;
                    gbLop.Enabled = true;

                }
                btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnSua.Enabled = false;
                btnLuu.Enabled = true;
                choosed = false;
            }
            
            
        }

        private void Cff_DataSend(string msg)
        {
            if (msg != null)
            {
                choosed = true;
                khoa = msg == "KHOA";
            }
            
            
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (khoa == true) luuKhoa();
            else
            {
                luuLop();
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formConfirm cff = new formConfirm("Bạn muốn sửa khoa hay lớp");

            cff.DataSend += Cff_DataSend;
            cff.ShowDialog();

            if (choosed)
            {
                checkButtonSua = true;
                if (khoa == true)
                {
                    gbKhoa.Enabled = true;
                    gbLop.Enabled = false;
                    txtTenKhoa.Focus();
                    txtMaCoSo.Enabled = txtMaKhoa.Enabled = false;
                }
                else
                {
                    gbKhoa.Enabled = false;
                    gbLop.Enabled = true;
                    txtTenLop.Focus();
                    txtMaKhoaLop.Enabled = txtMaLop.Enabled = false;
                }

                btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnSua.Enabled = false;
                btnLuu.Enabled = true;
                choosed = false;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formConfirm cff = new formConfirm("Bạn muốn xóa khoa hay lớp");

            cff.DataSend += Cff_DataSend;
            cff.ShowDialog();

            if (choosed)
            {
                this.xoa();
                choosed = false;
            }
            
        }

        private void btnCancelKhoa_Click(object sender, EventArgs e)
        {
            if (!checkButtonSua) { this.bdsKhoa.CancelEdit(); }
            this.kHOATableAdapter.Fill(this.dS.KHOA);
            this.btnCancelKhoa.Enabled = btnLuu.Enabled = false;
            gbKhoa.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnSua.Enabled = true;
        }

        private void btnCancelLop_Click(object sender, EventArgs e)
        {
            if (!checkButtonSua) { this.bdsLop.CancelEdit(); }
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.btnCancelLop.Enabled = btnLuu.Enabled = false;
            gbLop.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnSua.Enabled = true;
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

    }
}
