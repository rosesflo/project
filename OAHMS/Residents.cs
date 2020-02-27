using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OAHMS
{
    public partial class frmResident_Card : Form
    {
        public string cs { get; private set; }

        public frmResident_Card()
        {
            InitializeComponent();
        }

        private void frmResidents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oAHMSDataSet1.Resident_Details' table. You can move, or remove it, as needed.
            this.resident_DetailsTableAdapter.Fill(this.oAHMSDataSet1.Resident_Details);

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\dep\Documents\ITEC 499\Backup\New folder (2)\OAHMS - v3\OAHMS\OAHMS.mdf;Integrated Security = True");
                SqlCommand cmd;
                con.Open();

                string s = "insert into Resident_Details values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12, @p13, @p14, @p15, @p16, @p17)";

                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@p1", txt_ID.Text);
                cmd.Parameters.AddWithValue("@p2", txt_Name.Text);
                cmd.Parameters.AddWithValue("@p3", txt_RNum.Text);
                cmd.Parameters.AddWithValue("@p4", txt_Type.Text);
                cmd.Parameters.AddWithValue("@p5", txt_Age.Text);
                cmd.Parameters.AddWithValue("@p6", txt_Sex.Text);
                cmd.Parameters.AddWithValue("@p7", dtp_DOB.Text);
                cmd.Parameters.AddWithValue("@p8", dtp_DEntered.Text);
                cmd.Parameters.AddWithValue("@p9", dtp_DLeft.Text);
                cmd.Parameters.AddWithValue("@p10", txt_Status.Text);
                cmd.Parameters.AddWithValue("@p11", txt_Hobbies.Text);
                cmd.Parameters.AddWithValue("@p12", txt_Disability.Text);
                cmd.Parameters.AddWithValue("@p13", txt_PJob.Text);
                cmd.Parameters.AddWithValue("@p14", txt_Deceased.Text);
                cmd.Parameters.AddWithValue("@p15", dtp_DOD.Text);
                cmd.Parameters.AddWithValue("@p16", txt_NOK.Text);
                cmd.Parameters.AddWithValue("@p17", txt_Notes.Text);
                cmd.CommandType = CommandType.Text;

                int i = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(i+ " Row(s) inserted ");
                //myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }

        
}

        private void btn_Close_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Hide();
            MainMenu f2 = new MainMenu();
            f2.ShowDialog();
                
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_rcard_Click(object sender, EventArgs e)
        {
            this.Hide();
            //frmResident_Card f4 = new frmResident_Card();
            Resident_Card f4 = new Resident_Card();
            f4.ShowDialog();
        }

        private void btn_ncard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_NCard f3 = new frm_NCard();
            f3.ShowDialog();
        }

        private void btn_rmcard_Click(object sender, EventArgs e)
        {
            //this.Hide();
            // frmRoom f5 = new frmRoom();
            // f5.ShowDialog();
            this.Hide();
            frmRoom f15 = new frmRoom();
            f15.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
} 
