using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OAHMS
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }


        private void btn_Residents_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmResident_Card f2 = new frmResident_Card();
            f2.ShowDialog();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Employees_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_EmpDetails f10 = new frm_EmpDetails();
            f10.ShowDialog();
        }

        private void btn_medRecord_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMedCard f31 = new frmMedCard();
            f31.ShowDialog();
        }

        private void btn_cards_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Cards f32 = new frm_Cards();
            f32.ShowDialog();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_rptList f33 = new frm_rptList();
            f33.ShowDialog();
        }

        private void btn_inquiry_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSearch f34 = new frmSearch();
            f34.ShowDialog();
        }
    }
}
