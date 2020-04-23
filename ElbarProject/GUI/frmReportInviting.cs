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
    public partial class frmReportInviting : Form
    {
        public frmReportInviting(int numinviting)
        {
            InitializeComponent();
            TakesTable curentTakeTable = new TakesTable();
            BindingSource bsReport = new BindingSource();
            bsReport.DataSource = curentTakeTable.GetTableForReportInviting(numinviting);
            //ReportDataSource rdsouse = new ReportDataSource();
            //rdsouse.Name = "DataSet1";
            //rdsouse.Value = bsReport;
            //reportViewer1.LocalReport.DataSources.Add(rdsouse);
        }

        private void frmReportInviting_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }
    }
}
