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

namespace TN
{
    public partial class formLichThi : Form
    {
        private bool giangVien = false;
        public formLichThi()
        {
            InitializeComponent();
        }

        private void formLichThi_Load(object sender, EventArgs e)
        {
           if (Program.mGroup == "SINHVIEN")
            {
                this.pnGV.Dispose();
                this.pnSV.Dock = DockStyle.Fill;
                giangVien = false;
            } else if (Program.mGroup == "GIANGVIEN" || Program.mGroup == "KHOA")
            {
                this.pnSV.Dispose();
                this.pnGV.Dock = DockStyle.Fill;
                giangVien = true;
            }

            if (giangVien)
            {
                this.sP_LAY_LICH_THI_THUTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_LICH_THI_THUTableAdapter.Fill(this.dS.SP_LAY_LICH_THI_THU, Program.username);
            }
            else
            {
     
                this.sP_LAY_LICH_THITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_LAY_LICH_THITableAdapter.Fill(this.dS.SP_LAY_LICH_THI, Program.username);
            }

            if (
                (!giangVien && this.dS.SP_LAY_LICH_THI.Rows.Count > 0) ||
                (giangVien && this.dS.SP_LAY_LICH_THI_THU.Rows.Count > 0)
            )
            {
                btnThi.Enabled = true;
            }
            else
            {
                btnThi.Enabled = false;
            }

        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            GridView grid = giangVien ? gridViewGV : gridViewSV;

            String monHoc = grid.GetFocusedRowCellValue("MAMH").ToString().Trim();
            Int32 soCau = Int32.Parse(grid.GetFocusedRowCellValue("SOCAU").ToString());
            String lop = grid.GetFocusedRowCellValue("MALOP").ToString().Trim();
            String trinhDo = grid.GetFocusedRowCellValue("MATRINHDO").ToString().Trim();
            String ngayThi = grid.GetFocusedRowCellValue("NGAYTHI").ToString().Trim();
            int idDK = int.Parse(grid.GetFocusedRowCellValue("IDDK").ToString().Trim());

            if (DateTime.Now.Date < DateTime.Parse(ngayThi).Date && !giangVien)
            {
                MessageBox.Show("Chưa tới ngày thi!", "Thông báo", MessageBoxButtons.OK);
            } else if (DateTime.Now.Date > DateTime.Parse(ngayThi).Date && !giangVien)
            {
                MessageBox.Show("Đã qua ngày thi!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            if (monHoc != "" && soCau > 0 && lop != "")
            {
                Form formThi = new formThi(monHoc, soCau, lop, trinhDo, idDK);

                if (!giangVien)
                {
                    formThi.FormClosed += new FormClosedEventHandler(RefreshGridView);
                } else
                {
                    this.btnThi.Enabled = true;
                }

                formThi.ShowDialog();
                
            }
        }

        private void RefreshGridView(object sender, FormClosedEventArgs e)
        {
            this.sP_LAY_LICH_THITableAdapter.Fill(this.dS.SP_LAY_LICH_THI, Program.username);
 
            if (this.dS.SP_LAY_LICH_THI.Rows.Count > 0)
            {
                btnThi.Enabled = true;
            }
            else
            {
                btnThi.Enabled = false;
            }
            
        }
    }
}
