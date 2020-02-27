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
    public partial class frmMedCard : Form
    {
        public string cs { get; private set; }


        public frmMedCard()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dtp_time_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmMedCard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oAHMSDataSet9.Med_Records' table. You can move, or remove it, as needed.
            this.med_RecordsTableAdapter.Fill(this.oAHMSDataSet9.Med_Records);

        }


        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dep\Documents\ITEC 499\Backup\New folder (2)\OAHMS - v3\OAHMS\OAHMS.mdf ;Integrated Security = True");
                SqlCommand cmd;
                con.Open();

                string s = "insert into Med_Records values (@p1, @p2, @p3, @p4, @p5, @p6)";

                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@p1", txt_rid.Text);
                cmd.Parameters.AddWithValue("@p2", txt_rname.Text);
                cmd.Parameters.AddWithValue("@p3", txt_physician.Text);
                cmd.Parameters.AddWithValue("@p4", txt_mcond.Text);
                cmd.Parameters.AddWithValue("@5", txt_pcond.Text);
                cmd.Parameters.AddWithValue("@p6", txt_notes.Text);
                cmd.CommandType = CommandType.Text;

                int i = cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(i + " Row(s) inserted ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }


        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu f30 = new MainMenu();
            f30.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // private void btn_save_Click_1(object sender, EventArgs e)
        //  {

        //  }
    }
}
