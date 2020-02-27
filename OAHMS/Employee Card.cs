using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OAHMS
{
    public partial class frmEmp_Card : Form
    {
     //   private object reportViewer1;

        public frmEmp_Card()
        {
            InitializeComponent();
        }

        private void frmEmp_Card_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oAHMSDataSet6.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.oAHMSDataSet6.Employees);

         //   this.reportViewer1.RefreshReport();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dep\Documents\ITEC 499\Backup\New folder (2)\OAHMS - v3\OAHMS\OAHMS.mdf;Integrated Security = True");
                SqlCommand cmd;
                con.Open();

                string s = "insert into Employees values (@p1, @p2, @p3, @p4, @p5, @p6)";
                cmd = new SqlCommand(s, con);

                cmd.Parameters.AddWithValue("@p1", txt_empID.Text);
                cmd.Parameters.AddWithValue("@p2", txt_empName.Text);
                cmd.Parameters.AddWithValue("@p3", txt_empTitle.Text);
                cmd.Parameters.AddWithValue("@p4", txt_empAddr.Text);
                // cmd.Parameters.AddWithValue("@p5", txt_volunteer.Text);//
                cmd.Parameters.AddWithValue("@p5", txt_notes.Text);
                cmd.Parameters.AddWithValue("@p6", txt_qual.Text);

                int i = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_EmpDetails f9 = new frm_EmpDetails();
            f9.ShowDialog();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeesTableAdapter.FillBy(this.oAHMSDataSet6.Employees);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
