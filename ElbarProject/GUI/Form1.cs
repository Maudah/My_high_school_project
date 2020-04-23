using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElbarProject.BLL;


namespace ElbarProject.GUI
{
    public partial class frmWellcome : Form
    {
      
        public frmWellcome()
        {
            InitializeComponent();
            BranchTable br = new BranchTable();
            Suport.FillCombox(cmbBranches, br.GetTable(), "branchName", "branchCoude");
      //      menuStrip1.Enabled = false;
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void הוספתלקוחToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportFixs f1 = new frmReportFixs();
            f1.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            menuStrip1.Enabled = true;
        }

        private void חיפושרכבToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchCars f1 = new frmSearchCars(this,"one", Convert.ToInt32 ( cmbBranches.SelectedValue ),"client" );
            f1.Show ();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void חיפושרכבבכלהסניפיםToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSearchCars f1 = new frmSearchCars(this, "all", Convert.ToInt32(cmbBranches.SelectedValue ), "worker");
            f1.Show();
        }

        private void מחיקתעירToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void הוספתקבוצהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddGroup fr = new frmAddGroup();
            fr.Show();
        }

        private void הוספתעובדToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddWorker fr = new frmAddWorker("Add");
            fr.Show();
        }

        private void הוספתדגםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddDesign frm = new frmAddDesign();
            frm.Show();
        }

        private void הוספתיצרןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddManufactore frmm = new frmAddManufactore();
            frmm.Show();
        }

        private void הוספתלקוחToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAddShowClient frmcl = new frmAddShowClient("add");
            frmcl.Show();
        }

        private void הוספתסניףToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddBranch frmb = new frmAddBranch();
            frmb.Show();
        }

        private void חיפשעובדToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddWorker frmw = new frmAddWorker("Update");
            frmw.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmShowCars  fr = new frmShowCars ("add");
            fr.Show();
        }

        private void הסרתעובדToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddWorker frmw = new frmAddWorker("Del");
            frmw.Show();
        }

        private void חיפושרכבToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmShowCars fr = new frmShowCars("update");
            fr.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmShowCars fr = new frmShowCars("del");
            fr.Show();
        }

        private void עדכוןמשכורותToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void עדכוןפרטילקוחToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddShowClient frm = new frmAddShowClient("update");
            frm.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            frmAddShowClient frm = new frmAddShowClient("search");
            frm.Show();
        }

        private void קטלוגרכביםשבסניףToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(cmbBranches.SelectedValue );
            frmSearchCars frm = new frmSearchCars(this, "one", x, "worker");
            frm.Show();
        }

        private void קטלוגרכביםבסניףToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(cmbBranches.SelectedValue);
            frmSearchCars frm = new frmSearchCars(this, "one", x, "client");
            frm.Show();
        }

        private void מנהלToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void הוספתהזמנהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(cmbBranches.SelectedValue);
            frmTakeForLong f1 = new frmTakeForLong(x,"long");
            f1.Show();
        }

        private void עדכוןפרטירכבToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowCars fr = new frmShowCars("update");
            fr.Show();
        }

        private void הוספתהזמנהלטווחקצרToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(cmbBranches.SelectedValue);
            frmTakeForLong f1 = new frmTakeForLong(x, "short");
            f1.Show();
        }

        private void ביטולהזמנהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDelTake frmdel = new frmDelTake();
            frmdel.Show();

        }

        private void חיפושהזמנהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchTake f1 = new frmSearchTake(Convert.ToInt32 ( cmbBranches.SelectedValue),"search");
            f1.Show();
        }

        private void עדכוןפרטיהזמנהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearchTake f1 = new frmSearchTake(Convert.ToInt32(cmbBranches.SelectedValue), "update");
            f1.Show();
        }

        private void דוחהחזרתרכבToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCarReturn f1 = new frmCarReturn(Convert.ToInt32(cmbBranches.SelectedValue));
            f1.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmAddFix f1 = new frmAddFix("add");
            f1.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmAddFix f1 = new frmAddFix("update");
            f1.Show();
        }

        private void כניסהיציאהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnterExit f1 = new frmEnterExit();
            f1.Show();
        }

        private void כניסהיציאהToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEnterExit f1 = new frmEnterExit();
            f1.Show();
        }

        private void כניסהיציאהToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmEnterExit f1 = new frmEnterExit();
            f1.Show();
        }

        private void כניסהיציאהToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmEnterExit f1 = new frmEnterExit();
            f1.Show();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtCoude.Text == "1234")
            {
                MessageBox.Show("ברוכים הבאים בחר בסניף הרצוי");
                cmbBranches.Enabled = true;
                cmbBranches.Enabled = true;
            }
            else
                MessageBox.Show("קוד שגוי נסה שוב");

        }

        private void לקיחתרכבToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTakeCar f1 = new frmTakeCar();
            f1.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmFixReturn f1 = new frmFixReturn();
                f1.Show();
        }

        private void מנהלראשיToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
