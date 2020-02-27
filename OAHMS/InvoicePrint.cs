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
    public partial class frm_InvoicePrint : Form
    {
        public frm_InvoicePrint()
        {
            InitializeComponent();
        }

        private void InvoicePrint_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
