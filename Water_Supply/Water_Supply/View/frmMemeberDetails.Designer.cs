namespace Water_Supply
{
    partial class frmMemeberDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMemeberDetails));
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblNic = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.txtMemNic = new System.Windows.Forms.TextBox();
            this.txtMemAddress = new System.Windows.Forms.TextBox();
            this.txtMemTelephone = new System.Windows.Forms.TextBox();
            this.txtMemName = new System.Windows.Forms.TextBox();
            this.lblDependants = new System.Windows.Forms.Label();
            this.lstDependants = new System.Windows.Forms.ListBox();
            this.txtDependants = new System.Windows.Forms.TextBox();
            this.btnAddDepen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRmvDependants = new System.Windows.Forms.Button();
            this.picMember = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.photoOpenDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(61, 100);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Member Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(61, 44);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(92, 20);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Member ID";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.Location = new System.Drawing.Point(58, 156);
            this.lblTelephone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(91, 20);
            this.lblTelephone.TabIndex = 2;
            this.lblTelephone.Text = "Telephone ";
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNic.Location = new System.Drawing.Point(61, 212);
            this.lblNic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(103, 20);
            this.lblNic.TabIndex = 3;
            this.lblNic.Text = "Member NIC";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(61, 268);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 20);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // txtMemID
            // 
            this.txtMemID.Location = new System.Drawing.Point(180, 41);
            this.txtMemID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Size = new System.Drawing.Size(132, 26);
            this.txtMemID.TabIndex = 5;
            this.txtMemID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMemID_KeyUp);
            // 
            // txtMemNic
            // 
            this.txtMemNic.Location = new System.Drawing.Point(180, 209);
            this.txtMemNic.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemNic.Name = "txtMemNic";
            this.txtMemNic.Size = new System.Drawing.Size(132, 26);
            this.txtMemNic.TabIndex = 8;
            this.txtMemNic.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMemNic_KeyUp);
            // 
            // txtMemAddress
            // 
            this.txtMemAddress.Location = new System.Drawing.Point(180, 265);
            this.txtMemAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemAddress.Name = "txtMemAddress";
            this.txtMemAddress.Size = new System.Drawing.Size(388, 26);
            this.txtMemAddress.TabIndex = 9;
            this.txtMemAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMemAddress_KeyUp);
            // 
            // txtMemTelephone
            // 
            this.txtMemTelephone.Location = new System.Drawing.Point(180, 153);
            this.txtMemTelephone.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemTelephone.Name = "txtMemTelephone";
            this.txtMemTelephone.Size = new System.Drawing.Size(132, 26);
            this.txtMemTelephone.TabIndex = 7;
            this.txtMemTelephone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMemTelephone_KeyUp);
            // 
            // txtMemName
            // 
            this.txtMemName.Location = new System.Drawing.Point(180, 97);
            this.txtMemName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMemName.Name = "txtMemName";
            this.txtMemName.Size = new System.Drawing.Size(228, 26);
            this.txtMemName.TabIndex = 6;
            this.txtMemName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMemName_KeyUp);
            // 
            // lblDependants
            // 
            this.lblDependants.AutoSize = true;
            this.lblDependants.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDependants.Location = new System.Drawing.Point(61, 324);
            this.lblDependants.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDependants.Name = "lblDependants";
            this.lblDependants.Size = new System.Drawing.Size(99, 20);
            this.lblDependants.TabIndex = 18;
            this.lblDependants.Text = "Dependants";
            // 
            // lstDependants
            // 
            this.lstDependants.FormattingEnabled = true;
            this.lstDependants.ItemHeight = 20;
            this.lstDependants.Location = new System.Drawing.Point(180, 356);
            this.lstDependants.Margin = new System.Windows.Forms.Padding(4);
            this.lstDependants.Name = "lstDependants";
            this.lstDependants.Size = new System.Drawing.Size(388, 84);
            this.lstDependants.TabIndex = 13;
            this.lstDependants.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstDependants_KeyUp);
            // 
            // txtDependants
            // 
            this.txtDependants.Location = new System.Drawing.Point(180, 321);
            this.txtDependants.Margin = new System.Windows.Forms.Padding(4);
            this.txtDependants.Name = "txtDependants";
            this.txtDependants.Size = new System.Drawing.Size(291, 26);
            this.txtDependants.TabIndex = 10;
            this.txtDependants.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDependants_KeyUp);
            // 
            // btnAddDepen
            // 
            this.btnAddDepen.Location = new System.Drawing.Point(483, 318);
            this.btnAddDepen.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDepen.Name = "btnAddDepen";
            this.btnAddDepen.Size = new System.Drawing.Size(85, 28);
            this.btnAddDepen.TabIndex = 11;
            this.btnAddDepen.Text = "Add";
            this.btnAddDepen.UseVisualStyleBackColor = true;
            this.btnAddDepen.Click += new System.EventHandler(this.btnAddDepen_Click);
            this.btnAddDepen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnAddDepen_KeyUp);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(35, 525);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 44);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(174, 525);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(124, 44);
            this.btnChange.TabIndex = 16;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(313, 525);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(124, 44);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(452, 525);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 44);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRmvDependants
            // 
            this.btnRmvDependants.Location = new System.Drawing.Point(180, 448);
            this.btnRmvDependants.Margin = new System.Windows.Forms.Padding(4);
            this.btnRmvDependants.Name = "btnRmvDependants";
            this.btnRmvDependants.Size = new System.Drawing.Size(85, 28);
            this.btnRmvDependants.TabIndex = 12;
            this.btnRmvDependants.Text = "Remove";
            this.btnRmvDependants.UseVisualStyleBackColor = true;
            this.btnRmvDependants.Click += new System.EventHandler(this.btnRmvDependants_Click);
            this.btnRmvDependants.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnRmvDependants_KeyUp);
            // 
            // picMember
            // 
            this.picMember.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picMember.InitialImage = ((System.Drawing.Image)(resources.GetObject("picMember.InitialImage")));
            this.picMember.Location = new System.Drawing.Point(438, 41);
            this.picMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMember.Name = "picMember";
            this.picMember.Size = new System.Drawing.Size(130, 130);
            this.picMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMember.TabIndex = 16;
            this.picMember.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(438, 186);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 14;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            this.btnUpload.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnUpload_KeyUp);
            // 
            // photoOpenDialog
            // 
            this.photoOpenDialog.FileName = "photoOpenDialog1";
            this.photoOpenDialog.Filter = "Image Files | *.bmp;*.jpg;*.png;*.jpeg;*.gif;";
            // 
            // frmMemeberDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 585);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.picMember);
            this.Controls.Add(this.btnRmvDependants);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddDepen);
            this.Controls.Add(this.txtDependants);
            this.Controls.Add(this.lstDependants);
            this.Controls.Add(this.lblDependants);
            this.Controls.Add(this.txtMemName);
            this.Controls.Add(this.txtMemTelephone);
            this.Controls.Add(this.txtMemAddress);
            this.Controls.Add(this.txtMemNic);
            this.Controls.Add(this.txtMemID);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblNic);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMemeberDetails";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Details";
            ((System.ComponentModel.ISupportInitialize)(this.picMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.TextBox txtMemNic;
        private System.Windows.Forms.TextBox txtMemAddress;
        private System.Windows.Forms.TextBox txtMemTelephone;
        private System.Windows.Forms.TextBox txtMemName;
        private System.Windows.Forms.Label lblDependants;
        private System.Windows.Forms.ListBox lstDependants;
        private System.Windows.Forms.TextBox txtDependants;
        private System.Windows.Forms.Button btnAddDepen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRmvDependants;
        private System.Windows.Forms.PictureBox picMember;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog photoOpenDialog;
    }
}