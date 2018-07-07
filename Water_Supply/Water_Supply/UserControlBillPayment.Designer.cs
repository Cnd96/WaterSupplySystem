namespace Water_Supply
{
    partial class UserControlBillPayment
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
            this.components = new System.ComponentModel.Container();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.lblBillId = new System.Windows.Forms.Label();
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtMemName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtTotalAmnt = new System.Windows.Forms.TextBox();
            this.lblAmnttobePaid = new System.Windows.Forms.Label();
            this.lblDifference = new System.Windows.Forms.Label();
            this.txtAmountPaying = new System.Windows.Forms.TextBox();
            this.lblPaying = new System.Windows.Forms.Label();
            this.txtdiffence = new System.Windows.Forms.TextBox();
            this.lblCr = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSearchBy
            // 
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "Bill ID",
            "Member ID",
            "Member Name"});
            this.cmbSearchBy.Location = new System.Drawing.Point(95, 29);
            this.cmbSearchBy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(156, 33);
            this.cmbSearchBy.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 35);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(97, 20);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search By :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(258, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(280, 30);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(544, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.cmbSearchBy);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(31, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 77);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // txtBillId
            // 
            this.txtBillId.Location = new System.Drawing.Point(352, 168);
            this.txtBillId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.ReadOnly = true;
            this.txtBillId.Size = new System.Drawing.Size(217, 30);
            this.txtBillId.TabIndex = 13;
            // 
            // lblBillId
            // 
            this.lblBillId.AutoSize = true;
            this.lblBillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillId.Location = new System.Drawing.Point(89, 168);
            this.lblBillId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBillId.Name = "lblBillId";
            this.lblBillId.Size = new System.Drawing.Size(61, 25);
            this.lblBillId.TabIndex = 11;
            this.lblBillId.Text = "Bill ID";
            // 
            // txtMemID
            // 
            this.txtMemID.Location = new System.Drawing.Point(353, 223);
            this.txtMemID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.ReadOnly = true;
            this.txtMemID.Size = new System.Drawing.Size(217, 30);
            this.txtMemID.TabIndex = 14;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(89, 223);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(119, 25);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "Memeber ID";
            // 
            // txtMemName
            // 
            this.txtMemName.Location = new System.Drawing.Point(352, 278);
            this.txtMemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemName.Name = "txtMemName";
            this.txtMemName.ReadOnly = true;
            this.txtMemName.Size = new System.Drawing.Size(217, 30);
            this.txtMemName.TabIndex = 16;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(89, 278);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(152, 25);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Memeber Name";
            // 
            // txtTotalAmnt
            // 
            this.txtTotalAmnt.Location = new System.Drawing.Point(353, 333);
            this.txtTotalAmnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalAmnt.Name = "txtTotalAmnt";
            this.txtTotalAmnt.ReadOnly = true;
            this.txtTotalAmnt.Size = new System.Drawing.Size(217, 30);
            this.txtTotalAmnt.TabIndex = 19;
            // 
            // lblAmnttobePaid
            // 
            this.lblAmnttobePaid.AutoSize = true;
            this.lblAmnttobePaid.Location = new System.Drawing.Point(89, 333);
            this.lblAmnttobePaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmnttobePaid.Name = "lblAmnttobePaid";
            this.lblAmnttobePaid.Size = new System.Drawing.Size(110, 25);
            this.lblAmnttobePaid.TabIndex = 18;
            this.lblAmnttobePaid.Text = "Bill Amount";
            // 
            // lblDifference
            // 
            this.lblDifference.AutoSize = true;
            this.lblDifference.Location = new System.Drawing.Point(89, 443);
            this.lblDifference.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDifference.Name = "lblDifference";
            this.lblDifference.Size = new System.Drawing.Size(100, 25);
            this.lblDifference.TabIndex = 18;
            this.lblDifference.Text = "Difference";
            // 
            // txtAmountPaying
            // 
            this.txtAmountPaying.Location = new System.Drawing.Point(353, 387);
            this.txtAmountPaying.Name = "txtAmountPaying";
            this.txtAmountPaying.Size = new System.Drawing.Size(218, 30);
            this.txtAmountPaying.TabIndex = 2;
            // 
            // lblPaying
            // 
            this.lblPaying.AutoSize = true;
            this.lblPaying.Location = new System.Drawing.Point(89, 388);
            this.lblPaying.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPaying.Name = "lblPaying";
            this.lblPaying.Size = new System.Drawing.Size(150, 25);
            this.lblPaying.TabIndex = 18;
            this.lblPaying.Text = "Paying Amount ";
            // 
            // txtdiffence
            // 
            this.txtdiffence.Location = new System.Drawing.Point(352, 438);
            this.txtdiffence.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdiffence.Name = "txtdiffence";
            this.txtdiffence.Size = new System.Drawing.Size(217, 30);
            this.txtdiffence.TabIndex = 19;
            // 
            // lblCr
            // 
            this.lblCr.AutoSize = true;
            this.lblCr.Location = new System.Drawing.Point(584, 443);
            this.lblCr.Name = "lblCr";
            this.lblCr.Size = new System.Drawing.Size(38, 25);
            this.lblCr.TabIndex = 20;
            this.lblCr.Text = "Cr.";
            this.lblCr.Visible = false;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Location = new System.Drawing.Point(352, 519);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(84, 32);
            this.btnEnter.TabIndex = 21;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(1214, 54);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(53, 25);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "Date";
            // 
            // UserControlBillPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblCr);
            this.Controls.Add(this.txtdiffence);
            this.Controls.Add(this.txtTotalAmnt);
            this.Controls.Add(this.lblPaying);
            this.Controls.Add(this.lblDifference);
            this.Controls.Add(this.lblAmnttobePaid);
            this.Controls.Add(this.txtAmountPaying);
            this.Controls.Add(this.txtMemName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBillId);
            this.Controls.Add(this.lblBillId);
            this.Controls.Add(this.txtMemID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlBillPayment";
            this.Size = new System.Drawing.Size(1798, 1075);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.Label lblBillId;
        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtMemName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtTotalAmnt;
        private System.Windows.Forms.Label lblAmnttobePaid;
        private System.Windows.Forms.Label lblDifference;
        private System.Windows.Forms.TextBox txtAmountPaying;
        private System.Windows.Forms.Label lblPaying;
        private System.Windows.Forms.TextBox txtdiffence;
        private System.Windows.Forms.Label lblCr;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
    }
}
