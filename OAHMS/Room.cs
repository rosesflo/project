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
    public partial class frmRoom : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dep\Documents\ITEC 499\Backup\New folder (2)\OAHMS - v3\OAHMS\OAHMS.mdf ;Integrated Security = True");
        SqlCommand cmd; //Variables
        SqlDataAdapter da;
        DataTable dt;
        int ID = 0; //variable used in updating and deleting record


        public frmRoom()
        {
            InitializeComponent();
            showData();

        }


        private void Room_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oAHMSDataSet7.Room_Details' table. You can move, or remove it, as needed.
            this.room_DetailsTableAdapter.Fill(this.oAHMSDataSet7.Room_Details);

        }
        //Insert Data

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_RM_ID.Text != "" && txt_Number.Text != "" && txt_Name.Text != "")
            {
                cmd = new SqlCommand("insert into Room_Details (RM_ID, RM_Number, RM_Type, Available, R_Name) values(@RM_ID, @RM_Number, @RM_Type, @Available, @R_Name)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@RM_ID", txt_RM_ID.Text);
                cmd.Parameters.AddWithValue("@RM_Number", txt_Number.Text);
                cmd.Parameters.AddWithValue("@RM_Type", txt_type.Text);
                cmd.Parameters.AddWithValue("@Available", txt_available.Text);
                cmd.Parameters.AddWithValue("@R_Name", txt_Name.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
                showData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please enter information");
            }
        }
        //Display data in dataGridView

        private void showData()
        {
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from Room_Details", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //Clear Data
        private void ClearData()
        {
            txt_RM_ID.Text = "";
            txt_Number.Text = "";
            txt_type.Text = "";
            txt_available.Text = "";
            txt_Name.Text = ""; 
            ID = 0;

        }
        //dataGridView1 RowHeaderMouseClick Event
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_RM_ID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Number.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_type.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_available.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Name.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }



        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmResident_Card f16 = new frmResident_Card();
            f16.ShowDialog();
        }

        //update record 

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_RM_ID.Text != "" && txt_Number.Text != "" && txt_type.Text != "" && txt_available.Text != "" && txt_Name.Text != "")
            {
                cmd = new SqlCommand("update Room_Details set RM_ID=@rm_id, RM_Number=@rm_number, RM_Type=@rm_type, Available=@available, R_Name=@r_name where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@rm_id", txt_RM_ID.Text);
                cmd.Parameters.AddWithValue("@rm_number", txt_Number.Text);
                cmd.Parameters.AddWithValue("@rm_type", txt_type.Text);
                cmd.Parameters.AddWithValue("@available", txt_available.Text);
                cmd.Parameters.AddWithValue("@r_name", txt_Name.Text);
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

        //to delete record

        private void btn_delete_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_Number_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    

