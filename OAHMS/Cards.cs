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
    public partial class frm_Cards : Form


    {
        public frm_Cards()
        {
            InitializeComponent();
        }

        private void frm_Cards_Load(object sender, EventArgs e)
        {

        }

        private void btn_rtnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu f20 = new MainMenu();
            f20.ShowDialog();
        }

        private void btn_nok_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_NCard f21 = new frm_NCard();
            f21.ShowDialog();
        }

        private void btn_room_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRoom f22 = new frmRoom();
            f22.ShowDialog();
        }

        private void btn_residentCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resident_Card f23 = new Resident_Card();
            f23.ShowDialog();
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmp_Card f24 = new frmEmp_Card();
            f24.ShowDialog();
        }

        private void btn_activity_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_actvCard f25 = new frm_actvCard();
            f25.ShowDialog();
        }
    }
}
