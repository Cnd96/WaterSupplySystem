namespace Water_Supply
{
    partial class UserControlCurrentReadingCur
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
            this.dgvCurrrentReading = new System.Windows.Forms.DataGridView();
            this.lblSearchBillId = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpSearchBy = new System.Windows.Forms.GroupBox();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.billID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentReadind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrrentReading)).BeginInit();
            this.grpSearchBy.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCurrrentReading
            // 
            this.dgvCurrrentReading.AllowUserToAddRows = false;
            this.dgvCurrrentReading.AllowUserToDeleteRows = false;
            this.dgvCurrrentReading.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCurrrentReading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCurrrentReading.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billID,
            this.memberId,
            this.memberName,
            this.creditAmount,
            this.readingDate,
            this.currentReadind});
            this.dgvCurrrentReading.Location = new System.Drawing.Point(31, 133);
            this.dgvCurrrentReading.Name = "dgvCurrrentReading";
            this.dgvCurrrentReading.ReadOnly = true;
            this.dgvCurrrentReading.RowHeadersVisible = false;
            this.dgvCurrrentReading.RowTemplate.Height = 24;
            this.dgvCurrrentReading.Size = new System.Drawing.Size(1117, 432);
            this.dgvCurrrentReading.TabIndex = 0;
            this.dgvCurrrentReading.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrrentReading_CellDoubleClick);
            // 
            // lblSearchBillId
            // 
            this.lblSearchBillId.AutoSize = true;
            this.lblSearchBillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBillId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSearchBillId.Location = new System.Drawing.Point(11, 33);
            this.lblSearchBillId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchBillId.Name = "lblSearchBillId";
            this.lblSearchBillId.Size = new System.Drawing.Size(97, 20);
            this.lblSearchBillId.TabIndex = 8;
            this.lblSearchBillId.Text = "Search By :";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(257, 29);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(186, 30);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // grpSearchBy
            // 
            this.grpSearchBy.Controls.Add(this.cmbSearch);
            this.grpSearchBy.Controls.Add(this.lblSearchBillId);
            this.grpSearchBy.Controls.Add(this.txtSearch);
            this.grpSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearchBy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grpSearchBy.Location = new System.Drawing.Point(31, 26);
            this.grpSearchBy.Name = "grpSearchBy";
            this.grpSearchBy.Size = new System.Drawing.Size(556, 76);
            this.grpSearchBy.TabIndex = 10;
            this.grpSearchBy.TabStop = false;
            // 
            // cmbSearch
            // 
            this.cmbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "Bill ID",
            "Member ID",
            "Member Name"});
            this.cmbSearch.Location = new System.Drawing.Point(95, 29);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(143, 33);
            this.cmbSearch.TabIndex = 10;
            // 
            // billID
            // 
            this.billID.DividerWidth = 2;
            this.billID.HeaderText = "Bill ID";
            this.billID.Name = "billID";
            this.billID.ReadOnly = true;
            this.billID.Width = 120;
            // 
            // memberId
            // 
            this.memberId.DividerWidth = 2;
            this.memberId.HeaderText = "Member ID";
            this.memberId.Name = "memberId";
            this.memberId.ReadOnly = true;
            this.memberId.Width = 120;
            // 
            // memberName
            // 
            this.memberName.DividerWidth = 2;
            this.memberName.HeaderText = "Member Name";
            this.memberName.Name = "memberName";
            this.memberName.ReadOnly = true;
            this.memberName.Width = 348;
            // 
            // creditAmount
            // 
            this.creditAmount.DividerWidth = 2;
            this.creditAmount.HeaderText = "Credit Amount";
            this.creditAmount.Name = "creditAmount";
            this.creditAmount.ReadOnly = true;
            this.creditAmount.Width = 150;
            // 
            // readingDate
            // 
            this.readingDate.DividerWidth = 2;
            this.readingDate.HeaderText = "Reading Date";
            this.readingDate.Name = "readingDate";
            this.readingDate.ReadOnly = true;
            this.readingDate.Width = 201;
            // 
            // currentReadind
            // 
            this.currentReadind.DividerWidth = 2;
            this.currentReadind.HeaderText = "Current Reading";
            this.currentReadind.Name = "currentReadind";
            this.currentReadind.ReadOnly = true;
            this.currentReadind.Width = 175;
            // 
            // UserControlCurrentReadingCur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.grpSearchBy);
            this.Controls.Add(this.dgvCurrrentReading);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlCurrentReadingCur";
            this.Size = new System.Drawing.Size(1798, 1075);
            this.Load += new System.EventHandler(this.UserControlCurrentReadingCur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrrentReading)).EndInit();
            this.grpSearchBy.ResumeLayout(false);
            this.grpSearchBy.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCurrrentReading;
        private System.Windows.Forms.Label lblSearchBillId;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox grpSearchBy;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn billID;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn readingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentReadind;
    }
}
