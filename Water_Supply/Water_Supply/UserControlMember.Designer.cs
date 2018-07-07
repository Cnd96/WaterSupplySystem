namespace Water_Supply
{
    partial class UserControlMember
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvMemberslist = new System.Windows.Forms.DataGridView();
            this.MemberID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelephoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.lblSearchId = new System.Windows.Forms.Label();
            this.grpSearchBy = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberslist)).BeginInit();
            this.grpSearchBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMemberslist
            // 
            this.dgvMemberslist.AllowUserToAddRows = false;
            this.dgvMemberslist.AllowUserToDeleteRows = false;
            this.dgvMemberslist.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMemberslist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMemberslist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberID,
            this.MemberName,
            this.NIC,
            this.TelephoneNo,
            this.Address});
            this.dgvMemberslist.Location = new System.Drawing.Point(31, 133);
            this.dgvMemberslist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMemberslist.Name = "dgvMemberslist";
            this.dgvMemberslist.ReadOnly = true;
            this.dgvMemberslist.RowHeadersVisible = false;
            this.dgvMemberslist.Size = new System.Drawing.Size(1117, 432);
            this.dgvMemberslist.TabIndex = 0;
            this.dgvMemberslist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMemberslist_CellDoubleClick);
            // 
            // MemberID
            // 
            this.MemberID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MemberID.DividerWidth = 2;
            this.MemberID.Frozen = true;
            this.MemberID.HeaderText = "Member ID";
            this.MemberID.Name = "MemberID";
            this.MemberID.ReadOnly = true;
            this.MemberID.Width = 139;
            // 
            // MemberName
            // 
            this.MemberName.DividerWidth = 2;
            this.MemberName.Frozen = true;
            this.MemberName.HeaderText = "Member Name";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            this.MemberName.Width = 300;
            // 
            // NIC
            // 
            this.NIC.DividerWidth = 2;
            this.NIC.Frozen = true;
            this.NIC.HeaderText = "NIC";
            this.NIC.Name = "NIC";
            this.NIC.ReadOnly = true;
            this.NIC.Width = 150;
            // 
            // TelephoneNo
            // 
            this.TelephoneNo.DividerWidth = 2;
            this.TelephoneNo.Frozen = true;
            this.TelephoneNo.HeaderText = "Telephone ";
            this.TelephoneNo.Name = "TelephoneNo";
            this.TelephoneNo.ReadOnly = true;
            this.TelephoneNo.Width = 150;
            // 
            // Address
            // 
            this.Address.DividerWidth = 2;
            this.Address.Frozen = true;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 400;
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.Location = new System.Drawing.Point(31, 596);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(225, 52);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "Add New Member";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // lblSearchId
            // 
            this.lblSearchId.AutoSize = true;
            this.lblSearchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSearchId.Location = new System.Drawing.Point(11, 33);
            this.lblSearchId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchId.Name = "lblSearchId";
            this.lblSearchId.Size = new System.Drawing.Size(97, 20);
            this.lblSearchId.TabIndex = 5;
            this.lblSearchId.Text = "Search By :";
            // 
            // grpSearchBy
            // 
            this.grpSearchBy.Controls.Add(this.txtSearch);
            this.grpSearchBy.Controls.Add(this.cmbSearch);
            this.grpSearchBy.Controls.Add(this.lblSearchId);
            this.grpSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchBy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpSearchBy.Location = new System.Drawing.Point(31, 26);
            this.grpSearchBy.Name = "grpSearchBy";
            this.grpSearchBy.Size = new System.Drawing.Size(577, 77);
            this.grpSearchBy.TabIndex = 6;
            this.grpSearchBy.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(257, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 30);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cmbSearch
            // 
            this.cmbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Member ID",
            "Member Name"});
            this.cmbSearch.Location = new System.Drawing.Point(95, 29);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(143, 33);
            this.cmbSearch.TabIndex = 6;
            // 
            // UserControlMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.grpSearchBy);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.dgvMemberslist);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlMember";
            this.Size = new System.Drawing.Size(1798, 1075);
            this.Load += new System.EventHandler(this.UserControlMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMemberslist)).EndInit();
            this.grpSearchBy.ResumeLayout(false);
            this.grpSearchBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMemberslist;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Label lblSearchId;
        private System.Windows.Forms.GroupBox grpSearchBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelephoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbSearch;
    }
}
