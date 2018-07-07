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
    public partial class frmMemeberDetails : Form
    {
        public frmMemeberDetails()
        {
            InitializeComponent();
        }

        public frmMemeberDetails(int x)
        {
            InitializeComponent();
            if (x == 1)
            {
                btnChange.Enabled = false;
                btnRemove.Enabled = false;
            }
            else if (x == 2)
            {
                btnSave.Enabled = false;
            }
        }
        private void frmMemeberDetails_Load(object sender, EventArgs e)
        {

        }

        private void btnAddDepen_Click(object sender, EventArgs e)
        {
            if (txtDependants.Text != "")
            {
                lstDependants.Items.Add(txtDependants.Text);
                txtDependants.Text = "";
            }

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtMemID_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtMemName_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtMemTelephone_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtMemNic_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtMemAddress_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtDependants_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnUpload_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnAddDepen_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnRmvDependants_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void lstDependants_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btnRmvDependants_Click(object sender, EventArgs e)
        {
            try {
                lstDependants.Items.Remove(lstDependants.Items[lstDependants.SelectedIndex]);
            }
           catch(Exception ex)
            {

            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            photoOpenDialog.FileName = "";
            if(photoOpenDialog.ShowDialog()==DialogResult.OK)
            {
                picMember.Image = Image.FromFile(photoOpenDialog.FileName);
            }
        }
    }
}