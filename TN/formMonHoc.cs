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
    public partial class formMonHoc : Form
    {
        private bool isAdd = false;
        public formMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void formMonHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            dS.EnforceConstraints = false;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

            // TODO: This line of code loads data into the 'dS.CAUHOI' table. You can move, or remove it, as needed.
            this.cAUHOITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cAUHOITableAdapter.Fill(this.dS.CAUHOI);
            // TODO: This line of code loads data into the 'dS.GIANGDAY' table. You can move, or remove it, as needed.
            this.gIANGDAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGDAYTableAdapter.Fill(this.dS.GIANGDAY);

            // TODO: This line of code loads data into the 'DS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.dS.KHOA);

            this.cbKHOA.DataSource = dS.KHOA;

            this.cbKHOA.DisplayMember = "MAKH";
            this.cbKHOA.ValueMember = "MAKH";

            this.txtMaMonHoc.Enabled = this.txtTenMonHoc.Enabled = this.cbKHOA.Enabled = false;

            this.btnHoanTac.Enabled = this.btnThem.Enabled = this.btnSua.Enabled = this.btnXoa.Enabled = this.btnLuu.Enabled = false;
            if (Program.mGroup == "KHOA")
            {
                this.btnThem.Enabled = this.btnXoa.Enabled = this.btnSua.Enabled = true;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMH.AddNew();
            this.isAdd = true;
            this.txtMaMonHoc.Enabled = this.txtTenMonHoc.Enabled = this.cbKHOA.Enabled = true;
            this.btnLuu.Enabled = true;
            this.btnXoa.Enabled = this.btnSua.Enabled = false;
            txtMaMonHoc.Focus();
            this.cbKHOA.SelectedIndex = 1;
            this.cbKHOA.SelectedIndex = 0;
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String khoaValue = cbKHOA.SelectedValue.ToString().Trim();

            if (txtMaMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống!");
                txtMaMonHoc.Focus();
            }
            else if (txtTenMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được để trống!");
                txtTenMonHoc.Focus();
            }
            
            else if (khoaValue == "")
            {
                MessageBox.Show("Mã khoa không được để trống!");
                cbKHOA.Focus();
            }
            else
            {
                SqlDataReader myReader;
                if (isAdd)
                {

                    String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_KTMAMH]" +
                            "@MAMH = N'" + txtMaMonHoc.Text + "' SELECT  'Return Value' = @return_value";
                    myReader = Program.ExecSqlDataReader(strlenh);
                    if (myReader == null) return;
                    myReader.Read();
                    int value = myReader.GetInt32(0);
                    myReader.Close();
                    if (value == 1)
                    {
                        MessageBox.Show("Mã môn học đã tồn tại. Vui lòng nhập lại!");
                        txtMaMonHoc.Focus();
                        return;
                    }
                }



             
                    this.bdsMH.EndEdit();
                    this.bdsMH.ResetCurrentItem();
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                    MessageBox.Show("Cập nhật môn học thành công!");
                    this.btnXoa.Enabled = this.btnSua.Enabled = true;
                    this.txtMaMonHoc.Enabled = this.txtTenMonHoc.Enabled = this.cbKHOA.Enabled = false;
                    this.btnLuu.Enabled = false;
                    this.isAdd = false;
                
            }
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.bdsGD.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học đã tạo câu hỏi!", "", MessageBoxButtons.OK);
                return;
            }
            if (this.bdsCH.Count > 0)
            {
                MessageBox.Show("Không thể xóa môn học đã đăng ký dạy!", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thực sự muốn xóa môn học này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                
                    try
                    {
                        bdsMH.RemoveCurrent();
                        this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa môn học!\n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
                
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             this.txtTenMonHoc.Enabled = this.cbKHOA.Enabled = true;
            this.btnLuu.Enabled = true;
            if (this.isAdd == true) this.isAdd = false;
            this.btnXoa.Enabled = this.btnThem.Enabled = false;
            txtTenMonHoc.Focus();
            this.cbKHOA.SelectedIndex = 1;
            this.cbKHOA.SelectedIndex = 0;
        }
    }
}
