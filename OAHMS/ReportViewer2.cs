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
    public partial class ReportViewer2 : Form
    {
        public ReportViewer2()
        {
            InitializeComponent();
        }

        private void ReportViewer2_Load(object sender, EventArgs e)
        {
            DataSet1 ds = GetData();
            ReportDataSource datasource = new ReportDataSource("DataSet1", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    
        private DataSet1 GetData()
        {
            SqlConnection con = new SqlConnection((@"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dep\Documents\ITEC 499\Backup\New folder (2)\OAHMS - v3\OAHMS\OAHMS.mdf ;Integrated Security = True"));
            SqlCommand cmd = new SqlCommand("SELECT * FROM activity", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet1 ds = new DataSet1();
            da.Fill(ds, "DataTable1");
            return ds;
        }
    }
}
    

