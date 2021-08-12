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
    public partial class formGiangVien : Form
    {
        public formGiangVien()
        {
            InitializeComponent();
        }

        private void gIANGVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void gIANGVIENBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsGV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void formGiangVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            DS.EnforceConstraints = false;
            this.gIANGVIENTableAdapter.Fill(this.DS.GIANGVIEN);

            // TODO: This line of code loads data into the 'DS.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.kHOATableAdapter.Fill(this.DS.KHOA);
            this.cbKHOA.DataSource = DS.KHOA;
            this.cbKHOA.DisplayMember = "MAKH";
            this.cbKHOA.ValueMember = "MAKH";

            if (Program.mGroup == "PGV")
            {
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnLuu.Enabled = false;
                btnDong.Enabled = true;
            }
        }

        private void colMAKH_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            
            if (e.Column.FieldName != "MAKH") return;
            else
            {
                if ((string)e.Value == "MK1") {
                    e.Value = "Cong nghe thong tin";
                }
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsGV.AddNew();
            txtMa.Focus();
            this.cbKHOA.SelectedIndex = 1;
            this.cbKHOA.SelectedIndex = 0;
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String khoaValue = cbKHOA.SelectedValue.ToString().Trim();

            if (txtMa.Text.Trim() == "")
            {
                MessageBox.Show("Mã giảng viên không được để trống!");
                txtMa.Focus();
            }
            else if (txtHo.Text.Trim() == "")
            {
                MessageBox.Show("Họ giảng viên không được để trống!");
                txtHo.Focus();
            }
            else if (txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Tên giảng viên không được để trống!");
                txtTen.Focus();
            }
            else if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được để trống!");
                txtDiaChi.Focus();
            }
            else if (khoaValue == "")
            {
                MessageBox.Show("Mã khoa không được để trống!");
                cbKHOA.Focus();
            }
            else
            {
                SqlDataReader myReader;
                String strlenh1 = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_KTMAGV]" +
                        "@MAGV = N'" + txtMa.Text + "' SELECT  'Return Value' = @return_value";
                myReader = Program.ExecSqlDataReader(strlenh1);

                if (myReader == null) return;

                myReader.Read();
                int value = myReader.GetInt32(0);

                myReader.Close();
                if (value == 1)
                {
                    MessageBox.Show("Mã giảng viên đã tồn tại. Hãy nhập lại.");
                    txtMa.Focus();
                }
                else
                {
                    this.bdsGV.EndEdit();
                    this.bdsGV.ResetCurrentItem();
                    this.gIANGVIENTableAdapter.Update(this.DS.GIANGVIEN);
                    MessageBox.Show("Thêm giảng viên thành công!");
                }
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
