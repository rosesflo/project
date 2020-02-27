using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace OAHMS
{
    public partial class frmSearch : Form
    {
        //connection string
        string cs = (@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dep\Documents\ITEC 499\Backup\New folder (2)\OAHMS - v3\OAHMS\OAHMS.mdf;Integrated Security = True");
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;

 
        public frmSearch()
        {
            InitializeComponent();
        }

        //search load event
        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oAHMSDataSet14.Resident' table. You can move, or remove it, as needed.
            this.residentTableAdapter.Fill(this.oAHMSDataSet14.Resident);

            con = new SqlConnection(cs);
            con.Open();
            da = new SqlDataAdapter("select * from Resident", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void txt_SearchName_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            da = new SqlDataAdapter("select * from Resident where R_Name like '" + txt_SearchName.Text + "%'", con);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu f37 = new MainMenu();
            f37.ShowDialog();
        }
    }
}
