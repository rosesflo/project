using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAHMS
{
    public partial class frm_InvoiceReport : Form
    {
        public frm_InvoiceReport()
        {
            InitializeComponent();
        }

        private void InvoiceReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oAHMSDataSet24.Billing_Details' table. You can move, or remove it, as needed.
            this.billing_DetailsTableAdapter.Fill(this.oAHMSDataSet24.Billing_Details);

        }
    }
}
