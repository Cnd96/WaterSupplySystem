namespace Water_Supply
{
    partial class frmCurrentReading
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMemName = new System.Windows.Forms.TextBox();
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBillId = new System.Windows.Forms.Label();
            this.txtBillId = new System.Windows.Forms.TextBox();
            this.lblPrevReading = new System.Windows.Forms.Label();
            this.txtPrevReading = new System.Windows.Forms.TextBox();
            this.lblCredit = new System.Windows.Forms.Label();
            this.txtCreditValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentReading = new System.Windows.Forms.TextBox();
            this.lblAmountHasToPAy = new System.Windows.Forms.Label();
            this.txtAmountThisPeriod = new System.Windows.Forms.TextBox();
            this.lbAmntEntered = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtAmntEntered = new System.Windows.Forms.TextBox();
            this.txtTotalAmnt = new System.Windows.Forms.TextBox();
            this.lblBillingdate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtMemName
            // 
            this.txtMemName.Location = new System.Drawing.Point(208, 83);
            this.txtMemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemName.Name = "txtMemName";
            this.txtMemName.ReadOnly = true;
            this.txtMemName.Size = new System.Drawing.Size(325, 26);
            this.txtMemName.TabIndex = 11;
            // 
            // txtMemID
            // 
            this.txtMemID.Location = new System.Drawing.Point(436, 32);
            this.txtMemID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.ReadOnly = true;
            this.txtMemID.Size = new System.Drawing.Size(97, 26);
            this.txtMemID.TabIndex = 10;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(330, 35);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(101, 20);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Memeber ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(45, 86);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(128, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Memeber Name";
            // 
            // lblBillId
            // 
            this.lblBillId.AutoSize = true;
            this.lblBillId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBillId.Location = new System.Drawing.Point(45, 35);
            this.lblBillId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBillId.Name = "lblBillId";
            this.lblBillId.Size = new System.Drawing.Size(55, 20);
            this.lblBillId.TabIndex = 0;
            this.lblBillId.Text = "Bill ID";
            // 
            // txtBillId
            // 
            this.txtBillId.Location = new System.Drawing.Point(101, 32);
            this.txtBillId.Margin = new System.Windows.Forms.Padding(4);
            this.txtBillId.Name = "txtBillId";
            this.txtBillId.ReadOnly = true;
            this.txtBillId.Size = new System.Drawing.Size(132, 26);
            this.txtBillId.TabIndex = 9;
            // 
            // lblPrevReading
            // 
            this.lblPrevReading.AutoSize = true;
            this.lblPrevReading.Location = new System.Drawing.Point(45, 188);
            this.lblPrevReading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrevReading.Name = "lblPrevReading";
            this.lblPrevReading.Size = new System.Drawing.Size(108, 20);
            this.lblPrevReading.TabIndex = 4;
            this.lblPrevReading.Text = "Last Reading";
            // 
            // txtPrevReading
            // 
            this.txtPrevReading.Location = new System.Drawing.Point(208, 188);
            this.txtPrevReading.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrevReading.Name = "txtPrevReading";
            this.txtPrevReading.ReadOnly = true;
            this.txtPrevReading.Size = new System.Drawing.Size(112, 26);
            this.txtPrevReading.TabIndex = 13;
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Location = new System.Drawing.Point(45, 137);
            this.lblCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(101, 20);
            this.lblCredit.TabIndex = 3;
            this.lblCredit.Text = "Credit Value";
            // 
            // txtCreditValue
            // 
            this.txtCreditValue.Location = new System.Drawing.Point(208, 133);
            this.txtCreditValue.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditValue.Name = "txtCreditValue";
            this.txtCreditValue.ReadOnly = true;
            this.txtCreditValue.Size = new System.Drawing.Size(112, 26);
            this.txtCreditValue.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Reading";
            // 
            // txtCurrentReading
            // 
            this.txtCurrentReading.Location = new System.Drawing.Point(208, 239);
            this.txtCurrentReading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCurrentReading.Name = "txtCurrentReading";
            this.txtCurrentReading.Size = new System.Drawing.Size(112, 26);
            this.txtCurrentReading.TabIndex = 14;
            this.txtCurrentReading.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCurrentReading_KeyPress);
            this.txtCurrentReading.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCurrentReading_KeyUp);
            // 
            // lblAmountHasToPAy
            // 
            this.lblAmountHasToPAy.AutoSize = true;
            this.lblAmountHasToPAy.Location = new System.Drawing.Point(45, 290);
            this.lblAmountHasToPAy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmountHasToPAy.Name = "lblAmountHasToPAy";
            this.lblAmountHasToPAy.Size = new System.Drawing.Size(186, 20);
            this.lblAmountHasToPAy.TabIndex = 6;
            this.lblAmountHasToPAy.Text = "Amount For This Period";
            // 
            // txtAmountThisPeriod
            // 
            this.txtAmountThisPeriod.Location = new System.Drawing.Point(208, 290);
            this.txtAmountThisPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmountThisPeriod.Name = "txtAmountThisPeriod";
            this.txtAmountThisPeriod.ReadOnly = true;
            this.txtAmountThisPeriod.Size = new System.Drawing.Size(112, 26);
            this.txtAmountThisPeriod.TabIndex = 20;
            // 
            // lbAmntEntered
            // 
            this.lbAmntEntered.AutoSize = true;
            this.lbAmntEntered.Location = new System.Drawing.Point(45, 341);
            this.lbAmntEntered.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAmntEntered.Name = "lbAmntEntered";
            this.lbAmntEntered.Size = new System.Drawing.Size(199, 20);
            this.lbAmntEntered.TabIndex = 7;
            this.lbAmntEntered.Text = "Amount entered in the bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 392);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total amount to be paid";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(256, 460);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // txtAmntEntered
            // 
            this.txtAmntEntered.Location = new System.Drawing.Point(208, 338);
            this.txtAmntEntered.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAmntEntered.Name = "txtAmntEntered";
            this.txtAmntEntered.Size = new System.Drawing.Size(112, 26);
            this.txtAmntEntered.TabIndex = 16;
            this.txtAmntEntered.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAmntEntered_KeyUp);
            // 
            // txtTotalAmnt
            // 
            this.txtTotalAmnt.Location = new System.Drawing.Point(208, 389);
            this.txtTotalAmnt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalAmnt.Name = "txtTotalAmnt";
            this.txtTotalAmnt.Size = new System.Drawing.Size(112, 26);
            this.txtTotalAmnt.TabIndex = 17;
            // 
            // lblBillingdate
            // 
            this.lblBillingdate.AutoSize = true;
            this.lblBillingdate.Location = new System.Drawing.Point(330, 239);
            this.lblBillingdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBillingdate.Name = "lblBillingdate";
            this.lblBillingdate.Size = new System.Drawing.Size(111, 20);
            this.lblBillingdate.TabIndex = 4;
            this.lblBillingdate.Text = "Date Reading";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(436, 237);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 26);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // frmCurrentReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 517);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtTotalAmnt);
            this.Controls.Add(this.txtAmntEntered);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbAmntEntered);
            this.Controls.Add(this.lblAmountHasToPAy);
            this.Controls.Add(this.txtCurrentReading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCreditValue);
            this.Controls.Add(this.txtAmountThisPeriod);
            this.Controls.Add(this.txtPrevReading);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblBillingdate);
            this.Controls.Add(this.lblPrevReading);
            this.Controls.Add(this.txtBillId);
            this.Controls.Add(this.lblBillId);
            this.Controls.Add(this.txtMemName);
            this.Controls.Add(this.txtMemID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCurrentReading";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Current Reading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMemName;
        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBillId;
        private System.Windows.Forms.TextBox txtBillId;
        private System.Windows.Forms.Label lblPrevReading;
        private System.Windows.Forms.TextBox txtPrevReading;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.TextBox txtCreditValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrentReading;
        private System.Windows.Forms.Label lblAmountHasToPAy;
        private System.Windows.Forms.TextBox txtAmountThisPeriod;
        private System.Windows.Forms.Label lbAmntEntered;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtAmntEntered;
        private System.Windows.Forms.TextBox txtTotalAmnt;
        private System.Windows.Forms.Label lblBillingdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}