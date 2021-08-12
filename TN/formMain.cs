using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.Utils;

namespace TN
{
    public partial class formMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private bool dangXuat = false;
        public formMain()
        {
            InitializeComponent();
            this.chonTabMacDinh();
        }

        private void ribbonControl_MouseDown(object sender, MouseEventArgs e)
        {
            RibbonHitInfo mouseLocation = ribbonControl.CalcHitInfo(e.Location);
            if (
                (mouseLocation.Page == pageHeThong || mouseLocation.Page == pageTaiKhoan) &&
                Program.mGroup == "SINHVIEN")
            {
                MessageBox.Show("Bạn không có quyền truy cập hệ thống");
                DXMouseEventArgs.GetMouseArgs(e).Handled = true;
            }
        }

        private void formMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!dangXuat)
            {
                DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn thoát khỏi chương trình?", "Thoát", MessageBoxButtons.OKCancel);
                if (dialog == DialogResult.OK)
                {
                    Program.formDangNhap.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }

        }

        private void chonTabMacDinh()
        {
            if (Program.mGroup == "SINHVIEN")
            {
                this.ribbonControl.SelectedPage = pageThi;
            } else
            {
                this.ribbonControl.SelectedPage = pageHeThong;
            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }


        private void btnGV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(formGiangVien));
            if (form != null) form.Activate();
            else
            {
                formGiangVien f = new formGiangVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(formMonHoc));
            if (form != null) form.Activate();
            else
            {
                formMonHoc f = new formMonHoc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnCH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(formCauHoi));
            if (form != null) form.Activate();
            else
            {
                formCauHoi f = new formCauHoi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(formKhoa));
            if (form != null) form.Activate();
            else
            {
                formKhoa f = new formKhoa();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(formLopSV));
            if (form != null) form.Activate();
            else
            {
                formLopSV f = new formLopSV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(formGD));
            if (form != null) form.Activate();
            else
            {
                formGD f = new formGD();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(formDK));
            if (form != null) form.Activate();
            else
            {
                formDK f = new formDK();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnLichThi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(formLichThi));
            if (form != null) form.Activate();
            else
            {
                formLichThi f = new formLichThi();
                f.MdiParent = this;
                f.Show();
            }
        }

        //private void btnXemCTBT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        //{
        //    formChonMon f = new formChonMon();
        //    f.ShowDialog();
        //}

        private void btnBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(formLichThi));
            if (form != null) form.Activate();
            else
            {
                formXemBangDiem f = new formXemBangDiem();
                f.MdiParent = this;
                f.Show();
            }
           
        }


        private void btnCTBT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(formCTBT));
            if (form != null) form.Activate();
            else
            {
                formCTBT f = new formCTBT();
                f.MdiParent = this;
                f.Show();
            }
        }


        private void btnTaoLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form form = this.CheckExists(typeof(formTaoLogin));
            if (form != null) form.Activate();
            else
            {
                formTaoLogin f = new formTaoLogin();
                f.MdiParent = this;
                f.Show();
            }
        }


        private void formMain_Load(object sender, EventArgs e)
        {
            this.xuLyBatTat();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.dangXuat = true;
            this.Close();
            Program.formDangNhap.Show();
        }

        private void xuLyBatTat()
        {
            switch (Program.mGroup)
            {
                case "PGV":
                    btnLichThi.Enabled = btnCH.Enabled = false;
                    break;

                case "KHOA":
                    btnXemCTBT.Enabled = false;
                    break;

                case "GIANGVIEN":
                    btnLichThi.Caption = "Thi thử";
                    btnXemCTBT.Enabled = btnTaoLogin.Enabled  = false;
                    break;

                case "SINHVIEN":
                    btnLichThi.Caption = "Xem Lịch thi";
                    btnBD.Enabled = false;
                    break;
            }
        }
    }
}
