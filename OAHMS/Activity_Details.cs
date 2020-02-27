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
    public partial class frm_actvDetails : Form
    {
        public frm_actvDetails()
        {
            InitializeComponent();
        }

        private void Activity_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oAHMSDataSet10.ACTV_DETAILS' table. You can move, or remove it, as needed.
            this.aCTV_DETAILSTableAdapter.Fill(this.oAHMSDataSet10.ACTV_DETAILS);

            //  this.reportViewer1.RefreshReport();


        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dep\Documents\ITEC 499\Backup\New folder (2)\OAHMS - v3\OAHMS\OAHMS.mdf;Integrated Security = True");
                SqlCommand cmd;
                con.Open();

                string s = "insert into ACTV_DETAILS values @p1, @p2, @p3, @p4, @p5)";
                cmd = new SqlCommand(s, con);

                cmd.Parameters.AddWithValue("@p1", txt_actvNum.Text);
                cmd.Parameters.AddWithValue("@p2", txt_actv_Name.Text);
                cmd.Parameters.AddWithValue("@p3", txt_id.Text);
                cmd.Parameters.AddWithValue("@p4", txt_name);
                cmd.Parameters.AddWithValue("@p5", txt_notes.Text);

                int i = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void btn_actvCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_actvCard f21 = new frm_actvCard();
            f21.ShowDialog();
        }

        private void btn_main_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu f22 = new MainMenu();
            f22.ShowDialog();
        }
    }
}
