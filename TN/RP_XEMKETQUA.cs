using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Parameters;

namespace TN
{
    public partial class RP_XEMKETQUA : DevExpress.XtraReports.UI.XtraReport
    {
        public RP_XEMKETQUA(string mh)
        {
            InitializeComponent();
     
            this.lbHoTen.Text = Program.mHoten;
            this.lbMaMon.Text = mh;

        }

    }
}
