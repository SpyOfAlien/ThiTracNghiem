using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TN
{
 
    public partial class formThi : Form
    {
        private bool giangVien = false;

        private int duration;
        private int  s;
        private int m;
        private System.Timers.Timer timer;
        private string mh;
        private string td;
        private string maLop;
        private int sc;
        private int currIdx = 0;
        private int dk;
        private bool daBatDau = false;

        private List<CauHoi> dsCauHoi;

        private void formThi_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == "SINHVIEN")
            {
                giangVien = false;
            }
            else if (Program.mGroup == "GIANGVIEN" || Program.mGroup == "KHOA")
            {
                giangVien = true;
            }

            ControlBox = false; // Xóa control button (-, [], x)
            pnBatDau.Visible = true;
            btnNext.Visible = btnPrev.Visible = false;
            tbDSCH.Enabled = btnNopbai.Enabled = false;
        }

        public formThi()
        {
            InitializeComponent();
        }

        public formThi(string monHoc, int soCau, string lop, string trinhDo, int idDK)
        {
            InitializeComponent();


            this.txtTimer.Enabled = false;
            this.duration = soCau;

            this.lbMaSV.Text = Program.mHoten;
            this.lbLop.Text = maLop = lop;
            this.lbMon.Text = mh = monHoc;
            this.lbSoCau.Text = soCau.ToString();
            this.lbNgay.Text = DateTime.Now.ToString("MM/dd/yyyy");
            this.lbThoiGian.Text = String.Format("{0} phút", duration);

            sc = soCau;
            td = trinhDo;
            dk = idDK;

            this.showDSCH();
            this.layCauHoi(td, sc, mh);

        }

        private void initTimer()
        {
            timer = new System.Timers.Timer();
            timer.Elapsed += OnTimedEvent;
            timer.Interval = 1000;

            m = duration;
            s = 0;
            this.setTimer();
            timer.Start();
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                if (s == 0)
                {
                    if (m == 0)
                    {
                        btnThoat.Enabled = btnNopbai.Enabled = false;
                        timer.Dispose();                 
                        tinhDiem();
                        this.Close();

                    }
                    else
                    {
                        m -= 1;
                        s = 59;
                    }
                }
                else if (s > 0)
                {
                    s -= 1;
                }

                if (m == 0 && s == 30)
                {
                    txtTimer.BackColor = Color.Red;
                }

                this.setTimer();
            }));
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            if (daBatDau)
            {
                dialogResult = MessageBox.Show("Kết quả thi sẽ không được tính, bạn sẽ được 0 điểm nếu thóat", "Thoát", MessageBoxButtons.OKCancel);  
            }

            if (dialogResult == DialogResult.OK)
            {
                this.dsCauHoi.ForEach(ch => ch.choosed = null);
                this.tinhDiem();
               
            }

            if (!daBatDau || dialogResult == DialogResult.OK)
            {
                if (timer != null)
                {
                    timer.Stop();
                    timer.Dispose();
                }
                this.Close();
            }

           
        }

        private void btnNopbai_Click(object sender, EventArgs e)
        {
            List<CauHoi> cauChuaChon = dsCauHoi.FindAll(ch => ch.choosed == null);
            DialogResult dialogResult = new DialogResult();
            if (cauChuaChon.Count > 0)
            {
               dialogResult =
                    MessageBox.Show(
                        String.Format(
                            "Chưa hết thời gian làm bài, bạn còn {0} câu hỏi chưa chọn, bạn có chắc muốn nộp bài?",
                            cauChuaChon.Count
                        ),
                        "Nộp bài", MessageBoxButtons.OKCancel);
            } else
            {
               dialogResult = MessageBox.Show("Chưa hết thời gian làm bài, bạn có chắc muốn nộp bài?", "Nộp bài", MessageBoxButtons.OKCancel);
            }
            
            if (dialogResult == DialogResult.OK)
            {
                timer.Stop();
                timer.Dispose();
                this.tinhDiem();
                this.Close();

            }
        }

        private void setTimer()
        {
            this.txtTimer.Text = String.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
        }

        private void layCauHoi(string trinhDo, int soCau, string monHoc)
        {
            string cmd = String.Format("EXEC SP_LAYCAUHOI @MAMH='{0}', @MATRINHDO='{1}', @SOCAU='{2}', @MALOP='{3}'", monHoc, trinhDo, soCau, maLop);
            DataTable dt = Program.ExecSqlDataTable(cmd);

            if (dt.Rows.Count > 0)
            {
                var dsCH = new List<CauHoi>(dt.Rows.Count);
                foreach (DataRow row in dt.Rows)
                {
                    var values = row.ItemArray;
                    var cauhoi = new CauHoi()
                    {
                        IDCH = Int32.Parse(values[0].ToString()),
                        LOAICAUHOI = values[1].ToString(),
                        NOIDUNG = values[2].ToString(),
                        DAPAN = values[3].ToString(),
                        A = values[4].ToString(),
                        B = values[5].ToString(),
                        C = values[6].ToString(),
                        D = values[7].ToString(),
                    };
                    dsCH.Add(cauhoi);
                }

                dsCauHoi = dsCH;
            }

           
        }

        private void showDSCH()
        {
            int col = 0;
            int row = 0;
            for (int i = 0; i < sc; i ++)
            {
               
                Button bt = new Button();
                bt.Name = String.Format("btnC{0}", i+1);
                bt.Text = String.Format("{0}", i + 1);
                bt.Dock = DockStyle.Fill;
                bt.Click += new System.EventHandler(this.btnCH_Click);

                tbDSCH.Controls.Add(bt, col, row);

                col++;
                if (col == 5)
                {
                    col = 0;
                    row++;
                }

            }
        }

        private void btnCH_Click(object sender, EventArgs e)
        {
            int idx = int.Parse(((Button)sender).Text) - 1;
            this.currIdx = idx;
        
            renderCH();
        }

        private void renderCH()
        {
            
            CauHoi ch = dsCauHoi[currIdx];

            string noiDung = String.Format("{0}. {1}", currIdx + 1, ch.NOIDUNG);
            lbNDCH.Text = noiDung;

            // Xóa lựa chọn trước
            if (tbLC.Controls.Count > 1)
            {
                tbLC.Controls.Clear();
            }

            if (ch.LOAICAUHOI.Trim() == "YN")
            {
                RadioButton rb1 = new RadioButton();
                rb1.Text = "Yes";
                rb1.Checked = ch.choosed == "Yes";
                rb1.CheckedChanged += new System.EventHandler(onSelectDA);

                RadioButton rb2 = new RadioButton();
                rb2.Text = "No";
                rb2.Checked = ch.choosed == "No";
                rb2.CheckedChanged += new System.EventHandler(onSelectDA);

                tbLC.Controls.Add(rb1, 0, 0);
                tbLC.Controls.Add(rb2, 0, 1);

            } else
            {
                RadioButton rb1 = new RadioButton();
                rb1.Text = ch.A;
                rb1.Checked = ch.choosed == "A";
                rb1.CheckedChanged += new System.EventHandler(onSelectDA);

                RadioButton rb2 = new RadioButton();
                rb2.Text = ch.B;
                rb2.Checked = ch.choosed == "B";
                rb2.CheckedChanged += new System.EventHandler(onSelectDA);

                RadioButton rb3 = new RadioButton();
                rb3.Text = ch.C;
                rb3.Checked = ch.choosed == "C";
                rb3.CheckedChanged += new System.EventHandler(onSelectDA);

                RadioButton rb4 = new RadioButton();
                rb4.Text = ch.D;
                rb4.Checked = ch.choosed == "D";
                rb4.CheckedChanged += new System.EventHandler(onSelectDA);

                tbLC.Controls.Add(rb1, 0, 0);
                tbLC.Controls.Add(rb2, 0, 1);
                tbLC.Controls.Add(rb3, 0, 2);
                tbLC.Controls.Add(rb4, 0, 3);
            }

            this.btnPrev.Enabled = currIdx > 0 ? true : false;
            this.btnNext.Enabled = currIdx < sc - 1 ? true : false;
        }

        private void btnThi_Click(object sender, EventArgs e)
        {
            pnBatDau.Visible = false;
            btnPrev.Visible = btnNext.Visible = true;
            tbDSCH.Enabled = btnNopbai.Enabled = true;
            daBatDau = true;
            renderCH();
            initTimer();
        }

        private void onSelectDA(object sender, EventArgs e)
        {
            CauHoi ch = dsCauHoi[currIdx];
            string choosed = ((RadioButton)sender).Text;

            if (ch.LOAICAUHOI.Trim() == "WH")
            {
                ch.choosed = ch.A.Trim() == choosed ? "A" : ch.B.Trim() == choosed ? "B" : ch.C.Trim() == choosed ? "C" : "D";
            } else
            {
                ch.choosed = "Yes" == choosed ? "Yes" : "No";
            }

            this.capNhatCauDaChon();


        }

        private void tinhDiem()
        {
            double diemMotCau = 10 / (double)sc;
            double diem = 0;

            foreach (CauHoi ch in dsCauHoi)
            {
                if (ch.choosed == ch.DAPAN.Trim())
                {
                    diem += diemMotCau;
                }
            }

            diem = Math.Round(diem * 2, MidpointRounding.AwayFromZero) / 2;

            MessageBox.Show(String.Format("Điểm: {0}", diem));

            if (!giangVien)
            {
                this.luuDiem(diem);
            }
            
        }

        private void luuDiem(double diem)
        {
            // Luu table diem
            string cmdLuuDiem = String.Format("EXEC SP_LUU_THONG_TIN_THI @IDDK='{0}', @DIEM='{1}', @MASV='{2}'", dk, diem, Program.username);
            Program.ExecSqlNonQuery(cmdLuuDiem);

            // Luu table ctbt
            DataTable dt = new DataTable();

            dt.Columns.Add("IDDK", typeof(int));
            dt.Columns.Add("IDCH", typeof(int));
            dt.Columns.Add("MASV", typeof(string));
            dt.Columns.Add("CAUTRALOI", typeof(string));

            foreach (CauHoi ch in dsCauHoi)
                
            {
                DataRow dr = dt.NewRow();
                dr["IDDK"] = dk;
                dr["IDCH"] = ch.IDCH;
                dr["MASV"] = Program.username.Trim();

                dr["CAUTRALOI"] = ch.choosed != null ? ch.choosed.Trim() : "X";
                
                dt.Rows.Add(dr);
            }

            SqlCommand Sqlcmd = new SqlCommand("SP_LUU_CTBT", Program.conn);
            Sqlcmd.CommandType = CommandType.StoredProcedure;
            Sqlcmd.CommandTimeout = 600;
            Sqlcmd.Parameters.AddWithValue("@CTBT", dt);
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }
            try
            {
                Sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
   
                this.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                Program.conn.Close();
            }

        }

        private void capNhatCauDaChon(bool isSelect = false) {
            foreach (Button bt in tbDSCH.Controls.OfType<Button>())

            {
                if (bt.Text == (currIdx + 1).ToString())
                {
                    bt.BackColor =  Color.Green;
                   
                } 
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currIdx > 0)
            {
                this.currIdx--;
                this.renderCH();
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currIdx < sc - 1)
            {
                this.currIdx++;
                this.renderCH();
            }
        }
    }

    public class CauHoi
    {
        public int IDCH { get; set; }
        public string LOAICAUHOI { get; set; }
        public string NOIDUNG { get; set; }

        public string DAPAN { get; set; }

        public string A { get; set; }

        public string B { get; set; }

        public string C { get; set; }

        public string D { get; set; }



        public string choosed { get; set; }
    }
}
