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
    public partial class UserControlCurrentReadingCur : UserControl
    {
        public UserControlCurrentReadingCur()
        {
            InitializeComponent();
            cmbSearch.SelectedIndex = 0;
        }

        private void UserControlCurrentReadingCur_Load(object sender, EventArgs e)
        {
        
        }

        private void dgvCurrrentReading_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCurrentReading formreading = new frmCurrentReading();
            formreading.Show();
        }

        private void txtSearchMemberID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (dgvCurrrentReading.RowCount == 0)
                {
                    frmCurrentReading formreading = new frmCurrentReading();
                    formreading.Show();
                }

            }
        }
    }
}
