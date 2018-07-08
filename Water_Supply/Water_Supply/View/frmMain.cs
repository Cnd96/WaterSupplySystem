using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Supply
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Slider.Height = btnBillPayment.Height;
            Slider.Top = btnBillPayment.Top;
            userControlBillPayment1.BringToFront();
        }

        private void btnBillPayment_Click(object sender, EventArgs e)
        {
            Slider.Height = btnBillPayment.Height;
            Slider.Top = btnBillPayment.Top;
            userControlBillPayment1.BringToFront();
        }

        private void btnBillGenerate_Click(object sender, EventArgs e)
        {
            Slider.Height = btnBillGenerate.Height;
            Slider.Top = btnBillGenerate.Top;
            userControl1BillGenerate1.BringToFront();
        }

        private void btnCurrent_Click(object sender, EventArgs e)
        {
            Slider.Height = btnCurrentReading.Height;
            Slider.Top = btnCurrentReading.Top;
           userControlCurrentReadingCur1.BringToFront();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            Slider.Height = btnMember.Height;
            Slider.Top = btnMember.Top;
           userControlMember1.BringToFront();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            Slider.Height = btnAdmin.Height;
            Slider.Top = btnAdmin.Top;
            userControlAdmin1.BringToFront();
        }
    }
}
