using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OAHMS
{
    public partial class frm_ActvDetail2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dep\Documents\ITEC 499\Backup\New folder (2)\OAHMS - v3\OAHMS\OAHMS.mdf ;Integrated Security = True");
        SqlCommand cmd; //Variables
        SqlDataAdapter da;
        DataTable dt;
        int ID = 0; //variable used in updating and deleting record

        public object ACTV_NUM { get; private set; }
        public object Actv_Name { get; private set; }
        public object R_Name { get; private set; }
        public object Notes { get; private set; }

        public frm_ActvDetail2()
        {
            InitializeComponent();
            showData();

        }

        private void frm_ActvDetail2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oAHMSDataSet13.ACTV_DETAILS' table. You can move, or remove it, as needed.
            this.aCTV_DETAILSTableAdapter.Fill(this.oAHMSDataSet13.ACTV_DETAILS);

        }
        //insert data
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_ActNum.Text != "" && txt_ActName.Text != "")
            {
                cmd = new SqlCommand("insert into actv_details(ACTV_NUM, ACTV_NAME, R_NAME, DATE, TIME, NOTES) values(@actv_num, @actv_name, @R_NAME, @DATE, @TIME, @NOTES)", con);
                con.Open();
                cmd.Parameters.AddWithValue("ACTV_NUM", txt_ActNum.Text);
                cmd.Parameters.AddWithValue("ACTV_NAME", txt_ActName.Text);
                cmd.Parameters.AddWithValue("R_NAME", txt_ResName.Text);
                cmd.Parameters.AddWithValue("NOTES", txt_Notes.Text);
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
        //display data in datagridview
        private void showData()
        {
            con.Open();
            DataTable dt = new DataTable();
            da = new SqlDataAdapter("select * from actv_details", con);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //clear data
        private void ClearData()
        {
            txt_ActNum.Text = "";
            txt_ActName.Text = "";
            txt_ResName.Text = "";
            txt_Notes.Text = "";
            ID = 0;
        }

        //dataGridView1 RowHeaderMouseClick Event
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txt_ActNum.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_ActName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_ResName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Notes.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        //Update Record
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_ActNum.Text != "" && txt_ActName.Text != "" && txt_ResName.Text != "" && txt_Notes.Text != "")
            { 
                cmd = new SqlCommand("update ACTV_DETAILS set ACTV_NUM=@ActNum, ACTV_NAME=@actv_name, R_NAME@ResName, NOTES=@Notes wher ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@ActNum", ACTV_NUM);
                cmd.Parameters.AddWithValue("ActName", Actv_Name);
                cmd.Parameters.AddWithValue("@ResName", R_Name);
                cmd.Parameters.AddWithValue("@Notes", Notes);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Updated Successfully ");
                showData();
                ClearData();
              }
         
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }

        }
        //Delete Record
        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                cmd = new SqlCommand("delete actv_details where ID=@id", con);
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
        

    }

}


