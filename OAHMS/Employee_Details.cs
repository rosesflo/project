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
    public partial class frm_EmpDetails : Form
    {
        public frm_EmpDetails()
        {
            InitializeComponent();
        }

        private void frm_EmpDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oAHMSDataSet.Emp_Details' table. You can move, or remove it, as needed.
            this.emp_DetailsTableAdapter.Fill(this.oAHMSDataSet.Emp_Details);

        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dep\Documents\ITEC 499\Backup\New folder (2)\OAHMS - v3\OAHMS\OAHMS.mdf;Integrated Security = True");
                SqlCommand cmd;
                con.Open();

                string s = "insert into Emp_Details values (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11)";
                cmd = new SqlCommand(s, con);

                cmd.Parameters.AddWithValue("@p1", txt_emp_ID.Text);
               // cmd.Parameters.AddWithValue("@p2", txt_jobTitle);
                cmd.Parameters.AddWithValue("@p3", txt_name.Text);
                cmd.Parameters.AddWithValue("@p4", txt_addr.Text);
                cmd.Parameters.AddWithValue("@p5", txt_age.Text);
                cmd.Parameters.AddWithValue("@p6", txt_homeID);
                cmd.Parameters.AddWithValue("#p7", txt_jobTitle);
                cmd.Parameters.AddWithValue("@p8", txt_salary);
                cmd.Parameters.AddWithValue("@p9", txt_nis);
                cmd.Parameters.AddWithValue("@p10", txt_phone);
                cmd.Parameters.AddWithValue("@p11", txt_email);
                            

                int i = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void btn_empCard_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmp_Card f8 = new frmEmp_Card();
            f8.ShowDialog();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu f11 = new MainMenu();
            f11.ShowDialog();
        }
    }
}
