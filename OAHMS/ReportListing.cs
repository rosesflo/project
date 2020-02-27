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

    //show report
{
    public partial class frm_rptList : Form
    {
        public frm_rptList()
        {
            InitializeComponent();
        }

        private void btn_ResList_Click(object sender, EventArgs e)
        {
            frm_rptList f50 = new frm_rptList();
            f50.ShowDialog();
        }

        private void btn_RoomList_Click(object sender, EventArgs e)
        {
            DisplayReport f52 = new DisplayReport();
            f52.ShowDialog();
        }

        private void frm_rptList_Load(object sender, EventArgs e)
        {

        }

        //    private void btn_RoomList_Click(object sender, EventArgs e)
        //   {
        //   RptRoomDetails f51 = new RptRoomDetails(); // create an instance of Room Details
        //   f51.ShowDialog(); // display the form, the report will be automatically displayed
        //   }

        //  private void rptResdidentList_Load(object sender, EventArgs e)
        // {
        //    rptResdidentList f51 = new rptResdidentList();
        //     f51.ShowDialog();
        // }
    }
}
