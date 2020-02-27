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
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }

        private void Invoice_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oAHMSDataSet16.Billing_Details' table. You can move, or remove it, as needed.
            this.billing_DetailsTableAdapter1.Fill(this.oAHMSDataSet16.Billing_Details);
            // TODO: This line of code loads data into the 'oAHMSDataSet15.Billing_Details' table. You can move, or remove it, as needed.
            this.billing_DetailsTableAdapter.Fill(this.oAHMSDataSet15.Billing_Details);

        }
    }
}
