using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class formCauHoi : Form
    {

        public string prevA
        { get; set; }
        public string prevB
        { get; set; }
        public string prevC
        { get; set; }
        public string prevD
        { get; set; }
        public int prevFocus
        { get; set; }

        private string prevDA { get; set; }
        private string prevND { get; set; }

        private bool themMoi = false;
        private bool chinhsua = false; // control enable LC when CH grid view focus change
        public formCauHoi()
        {
            InitializeComponent();
            this.CauHoiGridView.FocusedRowChanged += CauHoiGridView_FocusedRowChanged;
        }

        private void cAUHOIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsCH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);
        }

        private void formCauHoi_Load(object sender, EventArgs e)
        {

            dS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.CAUHOI' table. You can move, or remove it, as needed.
            this.cAUHOITableAdapter.Connection.ConnectionString = Program.connstr;

            if (Program.mGroup == "KHOA")
            {
                this.cAUHOITableAdapter.FillByKhoa(this.dS.CAUHOI, Program.username, Program.mKhoa);
            }
            else if (Program.mGroup == "GIANGVIEN")
            {
                this.cAUHOITableAdapter.FillByGiangVien(this.dS.CAUHOI, Program.username);
            }

            // TODO: This line of code loads data into the 'dS.LUACHON' table. You can move, or remove it, as needed.
            this.lUACHONTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lUACHONTableAdapter.Fill(this.dS.LUACHON);
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'dS.TRINHDO' table. You can move, or remove it, as needed.
            this.tRINHDOTableAdapter.Connection.ConnectionString = Program.connstr;
            this.tRINHDOTableAdapter.Fill(this.dS.TRINHDO);

            this.handleEnableAllFields();
            this.btnLuu.Enabled = this.btnCancel.Enabled = false;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            themMoi = true;
            chinhsua = false;
            this.bdsCH.AddNew();
            this.btnLuu.Enabled = this.btnCancel.Enabled = true;
            this.btnThem.Enabled = this.btnSua.Enabled = this.btnXoa.Enabled = this.btnLamMoi.Enabled = this.btnHoanTac.Enabled = false;
            this.handleEnableAllFields(true);
            txtND.Focus();
            this.CauHoiGridView.SetFocusedRowCellValue(CauHoiGridView.Columns["MAGV"], Program.username);
            this.cbLoaiCH.SelectedIndex = this.cbMaMH.SelectedIndex = this.cbMaTD.SelectedIndex = cbDA.SelectedIndex = 1;
            this.cbLoaiCH.SelectedIndex = this.cbMaMH.SelectedIndex = this.cbMaTD.SelectedIndex = cbDA.SelectedIndex = 0;
        }

        private void CauHoiGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Cập nhật các field không liên kết trực tiếp với gridview khi thay đổi focused row.
            if (this.txtND.Enabled == false)
            {
                this.capNhatLuaChon();

                if (this.CauHoiGridView.GetFocusedRowCellValue("LOAICAUHOI") != null)
                {
                    this.cbLoaiCH.SelectedItem = this.CauHoiGridView.GetFocusedRowCellValue("LOAICAUHOI").ToString().Trim();
                }

                if (this.CauHoiGridView.GetFocusedRowCellValue("DAPAN") != null)
                {
                    this.cbDA.SelectedItem = this.CauHoiGridView.GetFocusedRowCellValue("DAPAN").ToString().Trim();
                }
            }
        }


        private void capNhatLuaChon()
        {
         
            this.txtA.Text = (string)this.LuaChonGridView.GetRowCellValue(0, "NOIDUNG");
            this.txtB.Text = (string)this.LuaChonGridView.GetRowCellValue(1, "NOIDUNG");
            this.txtC.Text = (string)this.LuaChonGridView.GetRowCellValue(2, "NOIDUNG");
            this.txtD.Text = (string)this.LuaChonGridView.GetRowCellValue(3, "NOIDUNG");
        }

        private void btnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (txtND.Text.Trim() == "")
            {
                MessageBox.Show("Nội dung câu hỏi không được để trống!");
                txtND.Focus();
            }

            else if (
                cbLoaiCH.SelectedIndex == 0 &&
                this.cbDA.SelectedItem.ToString() == ""
            )
            {
                MessageBox.Show("Vui lòng chọn đáp án cho câu hỏi!");
                cbDA.Focus();
            }

            else if (
                cbLoaiCH.SelectedIndex == 0 &&
                (txtA.Text.Trim() == "" || txtB.Text.Trim() == "" || txtC.Text.Trim() == "" || txtD.Text.Trim() == "")
            )
            {
                MessageBox.Show("Nội dung câu trả lời không được để trống!");
                txtA.Focus();
            } else if (
                cbLoaiCH.SelectedIndex == 0 && (
                txtA.Text.Trim() == txtB.Text.Trim() ||
                txtA.Text.Trim() == txtC.Text.Trim() ||
                txtA.Text.Trim() == txtD.Text.Trim() ||
                txtB.Text.Trim() == txtC.Text.Trim() ||
                txtB.Text.Trim() == txtD.Text.Trim() ||
                txtC.Text.Trim() == txtD.Text.Trim())
            ) {
                MessageBox.Show("Nội dung câu trả lời không được trùng nhau!");
                txtA.Focus();

            } else
            {
                // Kiểm tra nội dung câu hỏi nếu thêm mới hoặc chỉnh sửa nội dung
                if (themMoi || (chinhsua && txtND.Text.Trim() != prevND))
                {
                    SqlDataReader myReader;
                    String strlenh = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_KTCH]" +
                            "@NOIDUNG = N'" + txtND.Text.Trim() + "' SELECT  'Return Value' = @return_value";
                    myReader = Program.ExecSqlDataReader(strlenh);

                    if (myReader == null) return;

                    myReader.Read();
                    int value = myReader.GetInt32(0);

                    myReader.Close();
                    if (value == 1)
                    {
                        MessageBox.Show("Câu hỏi đã tồn tại. Vui lòng nhập lại");
                        txtND.Focus();
                        return;
                    }
                }

                this.bdsCH.EndEdit();
                this.cAUHOITableAdapter.Update(this.dS.CAUHOI);

                string loaiCH = CauHoiGridView.GetFocusedRowCellValue("LOAICAUHOI").ToString().Trim();
                Int32 idCH = Int32.Parse(CauHoiGridView.GetFocusedRowCellValue("IDCH").ToString().Trim());

                if (loaiCH == "WH")
                {
                    this.themLuaChon(idCH, "A");
                    this.themLuaChon(idCH, "B");
                    this.themLuaChon(idCH, "C");
                    this.themLuaChon(idCH, "D");
                }
                else if (LuaChonGridView.RowCount > 1 && !themMoi)
                {
                    String cmd = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_XOALC]" +
                       "@IDCH = N'" + idCH + "' SELECT  'Return Value' = @return_value";
                    Int32 rowEffected = Program.ExecSqlNonQuery(cmd);

                    this.lUACHONTableAdapter.Fill(this.dS.LUACHON);
                }

                this.LuaChonGridView.MoveFirst();
                this.capNhatLuaChon();
                this.handleEnableAllFields();
                this.btnLuu.Enabled = false;
                this.chinhsua = this.themMoi = false;
                this.btnThem.Enabled =
                    this.btnSua.Enabled =
                    this.btnXoa.Enabled =
                    this.btnLamMoi.Enabled =
                    this.btnHoanTac.Enabled = true;
            }
        }

        private void themLuaChon(Int32 idCH, string luaChon)
        {
           int idx = 0;
           if (
                themMoi ||
                (!themMoi && LuaChonGridView.RowCount < 4)
           )
            { 
                this.bdsLC.AddNew();
            }

            switch (luaChon)
            {
                case "A":
                    this.LuaChonGridView.SetFocusedRowCellValue("NOIDUNG", this.txtA.Text.Trim());
                    break;

                case "B":
                    this.LuaChonGridView.SetFocusedRowCellValue("NOIDUNG", this.txtB.Text.Trim());
                    idx = 1;
                    break;

                case "C":   
                    this.LuaChonGridView.SetFocusedRowCellValue("NOIDUNG", this.txtC.Text.Trim());
                    idx = 2;
                    break;

                case "D":      
                    this.LuaChonGridView.SetFocusedRowCellValue("NOIDUNG", this.txtD.Text.Trim());
                    idx = 3;
                    break;
            }

            if (!themMoi)
            {
                Int32 idLC = Int32.Parse(LuaChonGridView.GetFocusedRowCellValue("IDLC").ToString().Trim());
                this.LuaChonGridView.SetFocusedRowCellValue("IDLC", idLC);
            }
            this.LuaChonGridView.SetFocusedRowCellValue( "TENLC", luaChon);
            this.LuaChonGridView.SetFocusedRowCellValue( "IDCH", idCH);

            this.bdsLC.EndEdit();
            this.bdsLC.ResetCurrentItem();
            this.lUACHONTableAdapter.Update(this.dS.LUACHON);

            if (
                !themMoi &&
                idx < LuaChonGridView.RowCount - 1
            )
            {
                this.LuaChonGridView.MoveNext();
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogXoa =  MessageBox.Show("Bạn có thực sự muốn xóa câu hỏi này", "Xóa", MessageBoxButtons.OKCancel);

            if (dialogXoa == DialogResult.OK)
            {
                Int32 idCH = Int32.Parse(CauHoiGridView.GetFocusedRowCellValue("IDCH").ToString().Trim());

                String cmd = "DECLARE	@return_value int EXEC @return_value = [dbo].[SP_XOALC]" +
                        "@IDCH = N'" + idCH + "' SELECT  'Return Value' = @return_value";
                Int32 rowEffected = Program.ExecSqlNonQuery(cmd);

                if (rowEffected == 0)
                {
                    this.bdsCH.RemoveCurrent();
                    this.lUACHONTableAdapter.Update(this.dS.LUACHON);
                    this.cAUHOITableAdapter.Update(this.dS.CAUHOI);
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            themMoi = false;
            chinhsua = true;
            prevA = this.txtA.Text.Trim();
            prevB = this.txtB.Text.Trim();
            prevC = this.txtC.Text.Trim();
            prevD = this.txtD.Text.Trim();
            prevDA = this.cbDA.SelectedItem.ToString().Trim();
            prevND = this.txtND.Text.Trim();
            this.btnThem.Enabled = this.btnXoa.Enabled = this.btnSua.Enabled = this.btnLamMoi.Enabled = this.btnHoanTac.Enabled = false;
            this.btnCancel.Enabled = this.btnLuu.Enabled = true;
            this.handleEnableAllFields(true);
            
            if (this.cbLoaiCH.SelectedItem.ToString() == "YN")
            {
                txtA.Enabled
                = txtB.Enabled
                = txtC.Enabled
                = txtD.Enabled = false;
            }
        }

        private void handleEnableAllFields(bool isEnable = false)
        {
            txtND.Enabled
                = cbLoaiCH.Enabled
                = cbMaMH.Enabled
                = cbMaTD.Enabled
                = cbDA.Enabled
                = txtA.Enabled
                = txtB.Enabled
                = txtC.Enabled
                = txtD.Enabled = isEnable ? true : false;
        }

        private void cbLoaiCH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtA.Enabled
            = txtB.Enabled
            = txtC.Enabled
            = txtD.Enabled
            = (cbLoaiCH.SelectedIndex == 0  && (chinhsua == true || themMoi == true)) ? true : false;
            thayDoiDSDA();
        }

        private void thayDoiDSDA()
        {
            if (cbLoaiCH.SelectedIndex == 1 && cbDA.Items.Count > 2)
            {
                List<ComboBox> datasource = new List<ComboBox>()
                {
                    new ComboBox("Yes", "Yes"),
                    new ComboBox("No", "No"),
                };

                cbDA.DisplayMember = "display";
                cbDA.ValueMember = "value";

                this.cbDA.DataSource = datasource;
         
            }

            if (cbLoaiCH.SelectedIndex == 0 && cbDA.Items.Count < 3)
            {
                List<ComboBox> datasource = new List<ComboBox>()
                {
                    new ComboBox("A", "A"),
                    new ComboBox("B", "B"),
                    new ComboBox("C", "C"),
                    new ComboBox("D", "D"),
                };

                cbDA.DisplayMember = "display";
                cbDA.ValueMember = "value";

                this.cbDA.DataSource = datasource;
         
            }
        }

        private void cbDA_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbDA.SelectedValue != null)
            {
                this.CauHoiGridView.SetFocusedRowCellValue("DAPAN", this.cbDA.SelectedValue.ToString());
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.btnSua.Enabled = this.btnThem.Enabled = this.btnXoa.Enabled = this.btnLamMoi.Enabled = this.btnHoanTac.Enabled = true;
            this.btnCancel.Enabled = false;
            this.handleEnableAllFields();

            if (themMoi)
            {
                this.bdsCH.CancelEdit();
                this.bdsCH.RemoveCurrent();
            } else
            {
                this.txtA.Text = prevA;
                this.txtB.Text = prevB;
                this.txtC.Text = prevC;
                this.txtD.Text = prevD;
                this.cbDA.SelectedItem = prevDA;

                prevA = prevB = prevC = prevD = prevDA = prevND = "";
            }

            this.bdsCH.CancelEdit();
        }

        private void btnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnLamMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.cAUHOITableAdapter.Connection.ConnectionString = Program.connstr;

            if (Program.mGroup == "KHOA")
            {
                this.cAUHOITableAdapter.FillByKhoa(this.dS.CAUHOI, Program.username, Program.mKhoa);
            }
            else if (Program.mGroup == "GIANGVIEN")
            {
                this.cAUHOITableAdapter.FillByGiangVien(this.dS.CAUHOI, Program.username);
            }
        }

        private void btnHoanTac_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //dS.CAUHOI.RejectChanges()
        }
    }

    public class ComboBox
    {
        public string display {get; set;}
        public string value { get; set; }

        public ComboBox(string _display, string _value)
        {
            display = _display;
            value = _value;
        }
    }
}
