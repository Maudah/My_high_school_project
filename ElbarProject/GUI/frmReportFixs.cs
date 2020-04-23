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
    public partial class frmReportFixs : Form
    {
        public frmReportFixs()
        {
            InitializeComponent();
            FixsTable curentFixTable = new FixsTable();
            BindingSource bsReport = new BindingSource();
            bsReport.DataSource = curentFixTable.GetFixisTable();
            //ReportDataSource rdsouse = new ReportDataSource();
            //rdsouse.Name = "DataSet3";
            //rdsouse.Value = bsReport;
            //reportViewer1.LocalReport.DataSources.Add(rdsouse);
        }

        private void frmReportFixs_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
