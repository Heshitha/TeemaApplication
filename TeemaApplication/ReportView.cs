using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeemaApplication
{
    public partial class frmReportView : Form
    {
        public frmReportView()
        {
            InitializeComponent();
        }

        public frmReportView(ReportClass report)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = report;
        }

        private void frmReportView_Load(object sender, EventArgs e)
        {

        }
    }
}
