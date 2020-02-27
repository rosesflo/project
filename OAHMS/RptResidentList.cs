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
    public partial class Reports : Form
    {
        //private object report3

        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'OAHMSDataSet2.Resident' table. You can move, or remove it, as needed.
            this.ResidentTableAdapter.Fill(this.OAHMSDataSet2.Resident);
            this.rptResdentDetails.RefreshReport();
        }

        private void rptResidentDetails_Load(object sender, EventArgs e)
        {
            OAHMSDataSet2 ds = GetData();
            ReportDataSource datasource = new ReportDataSource(" OAHMSDataSet2", ds.Tables[0]);
            this.report31.LocalReport.DataSources.Clear();
            this.report31.LocalReport.DataSources.Add(datasource);
            this.report31.RefreshReport();
        }

        private OAHMSDataSet2 GetData()
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename= C:\Users\dep\Documents\ITEC 499\Backup\New folder (2)\OAHMS - v3\OAHMS\OAHMS.mdf;Integrated Security = True");
            SqlCommand cmd = new SqlCommand("SELECT * FROM Resident", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            OAHMSDataSet2 ds = new OAHMSDataSet2();
            da.Fill(ds, "DataTable1");
            return ds;
        }
    }
}
