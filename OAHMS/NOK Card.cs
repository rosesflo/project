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
    public partial class frm_NCard : Form
    { 

    SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dep\Documents\ITEC 499\Backup\New folder (2)\OAHMS - v3\OAHMS\OAHMS.mdf;Integrated Security = True");
    SqlCommand cmd; //Variables
    SqlDataAdapter da;
    DataTable dt;
    int Record_Id;

    
        public frm_NCard()
        {
            InitializeComponent();
            showdata();
        }

        private void NOK_Card_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oAHMSDataSet11.Next_of_Kin' table. You can move, or remove it, as needed.
            this.next_of_KinTableAdapter1.Fill(this.oAHMSDataSet11.Next_of_Kin);
            // TODO: This line of code loads data into the 'oAHMSDataSet.Next_of_Kin' table. You can move, or remove it, as needed.
           // this.next_of_KinTableAdapter.Fill(this.oAHMSDataSet.Next_of_Kin);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("insert into Next-of_Kin values('" + txt_ID.Text +"','"+ txt_Name.Text + "', '" + txt_Addr.Text + "', '" + txt_Phone.Text + "', '"+ txt_Email.Text +"', '"+ txt_RName.Text +"')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record saved....");
            con.Close();
            showdata();
        }

        //method to show data in datagrid view//

        private void showdata()
        {
            {
                da = new SqlDataAdapter("select * from Room_Details", con);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Record_Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Addr.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Phone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Email.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_RName.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //this.Close();
            // Close();
            this.Hide();
            frmResident_Card f4 = new frmResident_Card();
            f4.ShowDialog();
        }
    }
}
