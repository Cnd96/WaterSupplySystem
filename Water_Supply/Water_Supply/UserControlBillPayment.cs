using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Supply
{
    public partial class UserControlBillPayment : UserControl
    {
        public UserControlBillPayment()
        {
            InitializeComponent();
            cmbSearchBy.SelectedIndex = 0;
            DateTime date = DateTime.Now;
            lblDate.Text = date.ToString("MMM-d-yyyy");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }
    }
}
