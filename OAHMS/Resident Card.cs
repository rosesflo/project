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
    public partial class Resident_Card : Form
    {
        public string cs { get; private set; }

        public Resident_Card()
        {
            InitializeComponent();
        }

        private void Resident_Card_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oAHMSDataSet2.Resident' table. You can move, or remove it, as needed.
            this.residentTableAdapter.Fill(this.oAHMSDataSet2.Resident);
            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dep\Documents\ITEC 499\Backup\New folder (2)\OAHMS - v3\OAHMS\OAHMS.mdf ;Integrated Security = True");
            SqlCommand cmd;
            con.Open();
            String s = "insert into Resident values (@p1, @p2, @p3, @p4, @p5, @p6, @p7)";

            cmd = new SqlCommand(s, con);

            cmd.Parameters.AddWithValue("@p1", txt_ID.Text);
            cmd.Parameters.AddWithValue("@p2", txt_Name.Text);
            cmd.Parameters.AddWithValue("@p3", txt_Addr.Text);
            cmd.Parameters.AddWithValue("@p4", txt_Rel.Text);
            cmd.Parameters.AddWithValue("@p5", txt_Alleg.Text);
            cmd.Parameters.AddWithValue("@p6", txt_NoK.Text);
            cmd.Parameters.AddWithValue("@p7", txt_Notes.Text);
            cmd.CommandType = CommandType.Text;
            int i = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(i + " Row(s) Inserted ");

        }

       
        private void btn_close_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();
            frmResident_Card f7 = new frmResident_Card();
            f7.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
