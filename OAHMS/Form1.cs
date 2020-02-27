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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection();

        public Form1()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\dep\Documents\ITEC 499\Backup\New folder (2)\OAHMS - v3\OAHMS\OAHMS.mdf;Integrated Security = True";

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oAHMSDataSet.USERS' table. You can move, or remove it, as needed.
            this.uSERSTableAdapter.Fill(this.oAHMSDataSet.USERS);

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\dep\Documents\ITEC 499\Backup\New folder (2)\OAHMS - v3\OAHMS\OAHMS.mdf; Integrated Security = True");
            con.Open();

            this.reportViewer1.RefreshReport();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\dep\Documents\ITEC 499\Backup\New folder (2)\OAHMS - v3\OAHMS\OAHMS.mdf; Integrated Security = True";
            con.Open();

            string USERID = txt_UserID.Text;
            string PASSWORD = txt_Password.Text;

            SqlCommand cmd = new SqlCommand("select USERID, PASSWORD from USERS where USERID = '" + txt_UserID.Text + "' and PASSWORD = '" + txt_Password.Text + " ' ", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login successfull");


                this.Hide();
                MainMenu mn = new MainMenu();
                mn.ShowDialog();
            }

            else
            {
                MessageBox.Show("Invalid login...please try again");
            }
            con.Close();
            }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
