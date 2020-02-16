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
    public partial class frm_actvCard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dep\Documents\ITEC 499\Backup\New folder (2)\OAHMS - v3\OAHMS\OAHMS.mdf ;Integrated Security = True");
        SqlCommand cmd; //Variables
        SqlDataAdapter da;
        DataTable dt;
        int ID = 0; //variable used in updating and deleting record

        public frm_actvCard()
        {
            InitializeComponent();
            showData();
        }



      //  private void txt_actNum_TextChanged(object sender, EventArgs e)
      //  {

     //   }

     //   private void txt_actName_TextChanged(object sender, EventArgs e)
      //  {

     //   }

        private void Activity_Card_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oAHMSDataSet8.activity' table. You can move, or remove it, as needed.
            this.activityTableAdapter.Fill(this.oAHMSDataSet8.activity);

        }

        //insert data

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_actNum.Text != "" && txt_actName.Text != "")
            {
                cmd = new SqlCommand("insert into actv_details(ACTV_NUM, ACTV_NAME) values(@actv_num, @actv_name)", con);
                con.Open();
                cmd.Parameters.AddWithValue("ACTV_NUM", txt_actNum.Text);
                cmd.Parameters.AddWithValue("ACTV_NAME", txt_actName.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record inserted sucessfully ");
                showData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please enter information ");
            }
        }
        //Display data in dataGridView
        private void showData()
        {
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from Activity", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //Clear Data
        private void ClearData()
        {
            txt_actNum.Text = "";
            txt_actName.Text = "";
            ID = 0;

        }

        //dataGridView1 RowHeaderMouseClick Event
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_actNum.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_actName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        //update record

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_actNum.Text != "" && txt_actName.Text != "") 
            {
                cmd = new SqlCommand("update activity set ACTV_NUM = @actv_num, ACTV_NAME = @actv_name", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@actv.num", txt_actNum.Text);
                cmd.Parameters.AddWithValue("@actv_name", txt_actName.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record updated...");
                con.Close();
                showData();
                ClearData();
            }
        
            else
            {
                MessageBox.Show("Please select record to update..");
            }

        }
        //delete record

        private void btn_remove_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete Room_Details where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                showData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_actvDetails f23 = new frm_actvDetails();
            f23.ShowDialog();
        }



        //  private void btn_prev_Click(object sender, EventArgs e)
        //  {
        //    this.Hide();
        //     this.Hide();
        //     frmResident_Card f16 = new frmResident_Card();
        //     f16.ShowDialog();
    }
    }


