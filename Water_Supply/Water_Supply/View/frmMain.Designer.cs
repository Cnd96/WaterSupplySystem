namespace Water_Supply
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Slider = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnCurrentReading = new System.Windows.Forms.Button();
            this.btnBillGenerate = new System.Windows.Forms.Button();
            this.btnBillPayment = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControlAdmin1 = new Water_Supply.UserControlAdmin();
            this.userControl1BillGenerate1 = new Water_Supply.UserControl1BillGenerate();
            this.userControlBillPayment1 = new Water_Supply.UserControlBillPayment();
            this.userControlCurrentReadingCur1 = new Water_Supply.UserControlCurrentReadingCur();
            this.userControlMember1 = new Water_Supply.UserControlMember();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Slider);
            this.panel1.Controls.Add(this.btnAdmin);
            this.panel1.Controls.Add(this.btnMember);
            this.panel1.Controls.Add(this.btnCurrentReading);
            this.panel1.Controls.Add(this.btnBillGenerate);
            this.panel1.Controls.Add(this.btnBillPayment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 750);
            this.panel1.TabIndex = 0;
            // 
            // Slider
            // 
            this.Slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Slider.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Slider.Location = new System.Drawing.Point(-4, 158);
            this.Slider.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(23, 87);
            this.Slider.TabIndex = 5;
            // 
            // btnAdmin
            // 
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAdmin.Location = new System.Drawing.Point(0, 562);
            this.btnAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(228, 103);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnMember
            // 
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnMember.Location = new System.Drawing.Point(0, 460);
            this.btnMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(228, 103);
            this.btnMember.TabIndex = 3;
            this.btnMember.Text = "Members";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnCurrentReading
            // 
            this.btnCurrentReading.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCurrentReading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentReading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCurrentReading.Location = new System.Drawing.Point(0, 358);
            this.btnCurrentReading.Margin = new System.Windows.Forms.Padding(4);
            this.btnCurrentReading.Name = "btnCurrentReading";
            this.btnCurrentReading.Size = new System.Drawing.Size(228, 103);
            this.btnCurrentReading.TabIndex = 2;
            this.btnCurrentReading.Text = "Current Reading";
            this.btnCurrentReading.UseVisualStyleBackColor = true;
            this.btnCurrentReading.Click += new System.EventHandler(this.btnCurrent_Click);
            // 
            // btnBillGenerate
            // 
            this.btnBillGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBillGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBillGenerate.Location = new System.Drawing.Point(0, 256);
            this.btnBillGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnBillGenerate.Name = "btnBillGenerate";
            this.btnBillGenerate.Size = new System.Drawing.Size(228, 103);
            this.btnBillGenerate.TabIndex = 1;
            this.btnBillGenerate.Text = "Bill Generate";
            this.btnBillGenerate.UseVisualStyleBackColor = true;
            this.btnBillGenerate.Click += new System.EventHandler(this.btnBillGenerate_Click);
            // 
            // btnBillPayment
            // 
            this.btnBillPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBillPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBillPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnBillPayment.Location = new System.Drawing.Point(0, 154);
            this.btnBillPayment.Margin = new System.Windows.Forms.Padding(4);
            this.btnBillPayment.Name = "btnBillPayment";
            this.btnBillPayment.Size = new System.Drawing.Size(228, 103);
            this.btnBillPayment.TabIndex = 0;
            this.btnBillPayment.Text = "Bill Payment";
            this.btnBillPayment.UseVisualStyleBackColor = true;
            this.btnBillPayment.Click += new System.EventHandler(this.btnBillPayment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(228, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1143, 62);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // userControlAdmin1
            // 
            this.userControlAdmin1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userControlAdmin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAdmin1.Location = new System.Drawing.Point(0, 0);
            this.userControlAdmin1.Margin = new System.Windows.Forms.Padding(5);
            this.userControlAdmin1.Name = "userControlAdmin1";
            this.userControlAdmin1.Size = new System.Drawing.Size(1371, 750);
            this.userControlAdmin1.TabIndex = 5;
            // 
            // userControl1BillGenerate1
            // 
            this.userControl1BillGenerate1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userControl1BillGenerate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl1BillGenerate1.Location = new System.Drawing.Point(0, 0);
            this.userControl1BillGenerate1.Margin = new System.Windows.Forms.Padding(5);
            this.userControl1BillGenerate1.Name = "userControl1BillGenerate1";
            this.userControl1BillGenerate1.Size = new System.Drawing.Size(1371, 750);
            this.userControl1BillGenerate1.TabIndex = 4;
            // 
            // userControlBillPayment1
            // 
            this.userControlBillPayment1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userControlBillPayment1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlBillPayment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlBillPayment1.Location = new System.Drawing.Point(0, 0);
            this.userControlBillPayment1.Margin = new System.Windows.Forms.Padding(5);
            this.userControlBillPayment1.Name = "userControlBillPayment1";
            this.userControlBillPayment1.Size = new System.Drawing.Size(1371, 750);
            this.userControlBillPayment1.TabIndex = 2;
            // 
            // userControlCurrentReadingCur1
            // 
            this.userControlCurrentReadingCur1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userControlCurrentReadingCur1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlCurrentReadingCur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlCurrentReadingCur1.Location = new System.Drawing.Point(0, 0);
            this.userControlCurrentReadingCur1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.userControlCurrentReadingCur1.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.userControlCurrentReadingCur1.Name = "userControlCurrentReadingCur1";
            this.userControlCurrentReadingCur1.Size = new System.Drawing.Size(1371, 750);
            this.userControlCurrentReadingCur1.TabIndex = 7;
            // 
            // userControlMember1
            // 
            this.userControlMember1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.userControlMember1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlMember1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userControlMember1.Location = new System.Drawing.Point(0, 0);
            this.userControlMember1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.userControlMember1.Name = "userControlMember1";
            this.userControlMember1.Size = new System.Drawing.Size(1371, 750);
            this.userControlMember1.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 750);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControlBillPayment1);
            this.Controls.Add(this.userControlCurrentReadingCur1);
            this.Controls.Add(this.userControlMember1);
            this.Controls.Add(this.userControlAdmin1);
            this.Controls.Add(this.userControl1BillGenerate1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2661, 2449);
            this.Name = "frmMain";
            this.Text = "Water Board";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCurrentReading;
        private System.Windows.Forms.Button btnBillGenerate;
        private System.Windows.Forms.Button btnBillPayment;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControlBillPayment userControlBillPayment1;
        private UserControl1BillGenerate userControl1BillGenerate1;
        private System.Windows.Forms.Label Slider;
        private UserControlAdmin userControlAdmin1;
        private UserControlCurrentReadingCur userControlCurrentReadingCur1;
        private UserControlMember userControlMember1;
    }
}

