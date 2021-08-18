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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace TN
{
    public partial class formDK : Form
    {

        Boolean check = false;
        private int tongCH;

        public formDK()
        {
            InitializeComponent();
        }


        private void dANGKYBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDK.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }
        private static DataTable DS_MAGD_CHUA_DK;

        private void formDK_Load(object sender, EventArgs e)
        {
           
            cbCoSo.DataSource = Program.bds_dspm;
            cbCoSo.DisplayMember = "TENCS";
            cbCoSo.ValueMember = "TENSERVER";
            cbCoSo.SelectedIndex = Program.mCoso;

            cbTD.DisplayMember = "MATRINHDO";
            cbTD.ValueMember = "MATRINHDO";
            cbTD.DataSource = dS.TRINHDO;

            if (Program.mGroup != "PGV")
            {
                cbCoSo.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnLuu.Enabled = btnLamMoi.Enabled = btnXoa.Enabled = false;
            }
            else
            {
                cbCoSo.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnLuu.Enabled = btnLamMoi.Enabled = btnXoa.Enabled = true;
            }

            dS.EnforceConstraints = false;
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.dS.DANGKY);

            this.tHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.tHITableAdapter.Fill(this.dS.THI);

            this.gIANGDAYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGDAYTableAdapter.Fill(this.dS.GIANGDAY);

            this.tRINHDOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tRINHDOTableAdapter.Fill(this.dS.TRINHDO);

            txtMaNV.Enabled = false;
            gbDK.Enabled = false;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            DS_MAGD_CHUA_DK = new DataTable();
            string strlenh = "EXEC SP_DANHSACH_GIANGDAY_CHUA_DK";
            DS_MAGD_CHUA_DK = Program.ExecSqlDataTable(strlenh);

            if (DS_MAGD_CHUA_DK != null && DS_MAGD_CHUA_DK.Rows.Count > 0)
            {
                check = false;
                
                bdsDK.AddNew();
                txtMaNV.Text = Program.username;
                dpNgayThi.Value = DateTime.Now;

                cbGD.DisplayMember = "IDGD";
                cbGD.ValueMember = "IDGD";
                cbGD.DataSource = DS_MAGD_CHUA_DK;
                cbGD.SelectedIndex = 0;

                cbTD.SelectedIndex = 0;

                numSoCau.Value = 0;

                gbDK.Enabled = true;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = false;
                cbGD.Enabled = true;
                cbCoSo.Enabled = false;
            } else
            {
                MessageBox.Show("Tất cả các lớp đã được đăng ký, vui lòng kiểm tra lại!", "Notification", MessageBoxButtons.OK);
            }

        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (cbGD.Text.Trim() == "")
            {
                MessageBox.Show("Mã giảng dạy không được để trống!");
                cbGD.Focus();
            } else if (cbTD.Text.Trim() == "")
            {
                MessageBox.Show("Mã trình độ không được để trống!");
                cbTD.Focus();
            }
            else if (numSoCau.Value <= 0)
            {
                MessageBox.Show("Số lượng câu hỏi không được để trống!");
                numSoCau.Focus();
            }
            else if (!ktSoLuongCauHoi())
            {
                MessageBox.Show("Số lượng câu hỏi không đủ");
                numSoCau.Focus();
            } else if (dpNgayThi.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Ngày đăng ký không được bé hơn ngày hiện tại");
                dpNgayThi.Focus();
            } else
            {
                this.bdsDK.EndEdit();
                bdsDK.ResetCurrentItem();
                this.dANGKYTableAdapter.Update(this.dS.DANGKY);
                this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
                MessageBox.Show("Sửa đăng kí thành công!", "Notification", MessageBoxButtons.OK);

                gbDK.Enabled = false;
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnHoanTac.Enabled = true;
                cbCoSo.Enabled = true;
            }
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsThi.Count > 0)
            {
                MessageBox.Show("Không thể sửa đăng kí đã được thi!", "", MessageBoxButtons.OK);
                return;
            }

            check = true;
            gbDK.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnHoanTac.Enabled = false;
            cbGD.Enabled = cbCoSo.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsThi.Count > 0)
            {
                MessageBox.Show("Không thể xóa đăng kí đã được thi!", "", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (MessageBox.Show("Bạn có thực sự muốn xóa đăng kí này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        bdsDK.RemoveCurrent();
                        this.dANGKYTableAdapter.Update(this.dS.DANGKY);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa đăng kí!", "", MessageBoxButtons.OK);
                        return;
                    }
                }
            }
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
                this.tHITableAdapter.Fill(this.dS.THI);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Refresh: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }


        private void cbCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.IsDisposed == false && cbCoSo.SelectedValue != null)
            {
                if (cbCoSo.ValueMember != "")
                {
                    if (Program.servername != cbCoSo.SelectedValue.ToString())
                    {
                        Program.servername = cbCoSo.SelectedValue.ToString();
                    }
                    if (cbCoSo.SelectedIndex != Program.mCoso)
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
                    else
                    {
                        dS.EnforceConstraints = false;
                        this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                        this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
                        this.tHITableAdapter.Connection.ConnectionString = Program.connstr;
                        this.tHITableAdapter.Fill(this.dS.THI);
                    }
                }
            }
        }

        private bool ktSoLuongCauHoi()
        {
            
            string idGD = this.dkGridView.GetFocusedRowCellValue("IDGD").ToString().Trim();
            string maTD = this.cbTD.SelectedValue.ToString().Trim();
            string cmd = String.Format("EXEC SP_DEM_SLCH @IDGD={0}, @MATRINHDO='{1}'", int.Parse(idGD), maTD);
            SqlDataReader reader = Program.ExecSqlDataReader(cmd);

            if (reader == null) return false;
            reader.Read();
            int chCSHienTai = reader.GetInt32(0);
            int chTong= reader.GetInt32(1);
            reader.Close();

            if (chCSHienTai >= numSoCau.Value)
            {
                return true;
            } else if (chTong < numSoCau.Value)
            {
                return false;
            } else
            {
                MessageBox.Show(String.Format("Số lượng câu hỏi ở cơ sở hiện tại không đủ. Chương trình lấy {0} câu hỏi từ cơ sở còn lại", numSoCau.Value - chCSHienTai));
                return true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (!check)
            {
                this.bdsDK.RemoveCurrent();
      
            }

            this.bdsDK.CancelEdit();
            gbDK.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnLamMoi.Enabled = btnHoanTac.Enabled = true;
            cbCoSo.Enabled = true;
        }
    }
}