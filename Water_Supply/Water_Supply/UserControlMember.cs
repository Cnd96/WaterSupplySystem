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
    public partial class UserControlMember : UserControl
    {
        public UserControlMember()
        {
            InitializeComponent();
            cmbSearch.SelectedIndex = 0;
        }

        private void UserControlMember_Load(object sender, EventArgs e)
        {
            dgvMemberslist.RowHeadersVisible = false;
            this.dgvMemberslist.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            frmMemeberDetails frmmembers = new frmMemeberDetails(1);
            frmmembers.ShowDialog();
        }

        private void dgvMemberslist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemeberDetails frmmembers = new frmMemeberDetails(2);
            frmmembers.Show();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (dgvMemberslist.RowCount == 0)
                {
                    frmMemeberDetails frmmembers = new frmMemeberDetails(2);
                    frmmembers.Show();
                }
            }
        }
    }
}
