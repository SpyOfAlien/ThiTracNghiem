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
    public delegate void DataSendHandler(string msg);
    public partial class formConfirm : Form
    {
        public event DataSendHandler DataSend;
        public formConfirm()
        {
            InitializeComponent();
        }

        public formConfirm(string label)
        {
            InitializeComponent();
            this.questionLabel.Text = label;
         
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            this.DataSend("KHOA");
            this.Hide();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            this.DataSend("LOP");
            this.Hide();
        }
    }
}
