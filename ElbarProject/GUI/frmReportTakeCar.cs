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
    public partial class frmReportTakeCar : Form
    {
        public frmReportTakeCar(int numTake)
        {
            InitializeComponent();
            TakesTable  curentTakeTable = new TakesTable ();
            BindingSource bsReport = new BindingSource();
            bsReport.DataSource = curentTakeTable.GetTableForReportTakes(numTake);
            //ReportDataSource rdsouse = new ReportDataSource();
            //rdsouse.Name = "DataSet4";
            //rdsouse.Value = bsReport;
            //reportViewer1.LocalReport.DataSources.Add(rdsouse);
        }

        private void frmReportTakeCar_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }
    }
}
