using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Microsoft.Reporting.WinForms;
using ElbarProject.BLL;

namespace ElbarProject.GUI
{
    public partial class frmReportCarReturn : Form
    {
        public frmReportCarReturn(int numTake)
        {
            InitializeComponent();
            //TakesTable curentTakeTable = new TakesTable();
            //BindingSource bsReport = new BindingSource();
            //bsReport.DataSource = curentTakeTable.GetTableForReportReturn(numTake);
            //ReportDataSource rdsouse = new ReportDataSource();
            //rdsouse.Name = "DataSet2";
            //rdsouse.Value = bsReport;
            //reportViewer1.LocalReport.DataSources.Add(rdsouse);
        }

        private void frmReportCarReturn_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void frmReportCarReturn_Load_1(object sender, EventArgs e)
        {

        }
    }
}
