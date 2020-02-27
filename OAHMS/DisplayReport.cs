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
using Microsoft.Reporting.WinForms;

namespace OAHMS
{
    public partial class DisplayReport : Form
    {
        public DisplayReport()
        {
            InitializeComponent();
        }

        private void DisplayReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OAHMSDataSet2.Resident' table. You can move, or remove it, as needed.
            this.ResidentTableAdapter.Fill(this.OAHMSDataSet2.Resident);
            // TODO: This line of code loads data into the 'OAHMSDataSet12.Room_Details' table. You can move, or remove it, as needed.
            this.Room_DetailsTableAdapter.Fill(this.OAHMSDataSet12.Room_Details);

            this.reportViewer1.RefreshReport();

            OAHMSDataSet1 ds = GetData();
            ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.LocalReport.RefreshReport();

        }
        private OAHMSDataSet1 GetData()
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dep\Documents\ITEC 499\Backup\New folder (2)\OAHMS - v3\OAHMS\OAHMS.mdf;Integrated Security = True"); @"Data Source=.\sqlexpress;Initial Catalog=StudentDetails;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Room_Details ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            OAHMSDataSet1 ds = new OAHMSDataSet1();
            da.Fill(ds, "DataTable1");
            return ds;
        }
        }
    }

