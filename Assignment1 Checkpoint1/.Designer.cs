namespace Assignment1_Checkpoint1
{
    partial class ArenaForm
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
            this.lstArena = new System.Windows.Forms.ListBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddArena = new System.Windows.Forms.Button();
            this.btnUpdateArena = new System.Windows.Forms.Button();
            this.btnDeleteArena = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblArenaID = new System.Windows.Forms.Label();
            this.lblArenaName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtArenaID = new System.Windows.Forms.TextBox();
            this.txtArenaName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstArena
            // 
            this.lstArena.FormattingEnabled = true;
            this.lstArena.ItemHeight = 25;
            this.lstArena.Location = new System.Drawing.Point(69, 72);
            this.lstArena.Name = "lstArena";
            this.lstArena.Size = new System.Drawing.Size(436, 504);
            this.lstArena.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(61, 640);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(203, 64);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(295, 640);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(203, 64);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddArena
            // 
            this.btnAddArena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddArena.Location = new System.Drawing.Point(538, 640);
            this.btnAddArena.Name = "btnAddArena";
            this.btnAddArena.Size = new System.Drawing.Size(203, 64);
            this.btnAddArena.TabIndex = 3;
            this.btnAddArena.Text = "Add Arena";
            this.btnAddArena.UseVisualStyleBackColor = true;
            // 
            // btnUpdateArena
            // 
            this.btnUpdateArena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateArena.Location = new System.Drawing.Point(784, 640);
            this.btnUpdateArena.Name = "btnUpdateArena";
            this.btnUpdateArena.Size = new System.Drawing.Size(203, 64);
            this.btnUpdateArena.TabIndex = 4;
            this.btnUpdateArena.Text = "Update Arena";
            this.btnUpdateArena.UseVisualStyleBackColor = true;
            // 
            // btnDeleteArena
            // 
            this.btnDeleteArena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteArena.Location = new System.Drawing.Point(1034, 643);
            this.btnDeleteArena.Name = "btnDeleteArena";
            this.btnDeleteArena.Size = new System.Drawing.Size(203, 64);
            this.btnDeleteArena.TabIndex = 5;
            this.btnDeleteArena.Text = "Delete Arena";
            this.btnDeleteArena.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(1034, 739);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(203, 64);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblArenaID
            // 
            this.lblArenaID.AutoSize = true;
            this.lblArenaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaID.Location = new System.Drawing.Point(620, 93);
            this.lblArenaID.Name = "lblArenaID";
            this.lblArenaID.Size = new System.Drawing.Size(129, 31);
            this.lblArenaID.TabIndex = 7;
            this.lblArenaID.Text = "Arena ID:";
            // 
            // lblArenaName
            // 
            this.lblArenaName.AutoSize = true;
            this.lblArenaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaName.Location = new System.Drawing.Point(576, 179);
            this.lblArenaName.Name = "lblArenaName";
            this.lblArenaName.Size = new System.Drawing.Size(173, 31);
            this.lblArenaName.TabIndex = 8;
            this.lblArenaName.Text = "Arena Name:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress.Location = new System.Drawing.Point(550, 269);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(199, 31);
            this.lblStreetAddress.TabIndex = 9;
            this.lblStreetAddress.Text = "Street address:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuburb.Location = new System.Drawing.Point(640, 358);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(109, 31);
            this.lblSuburb.TabIndex = 10;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(677, 440);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(72, 31);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "CIty:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(546, 531);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(203, 31);
            this.lblPhoneNumber.TabIndex = 12;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // txtArenaID
            // 
            this.txtArenaID.BackColor = System.Drawing.SystemColors.Menu;
            this.txtArenaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArenaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArenaID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtArenaID.Location = new System.Drawing.Point(792, 93);
            this.txtArenaID.Multiline = true;
            this.txtArenaID.Name = "txtArenaID";
            this.txtArenaID.Size = new System.Drawing.Size(173, 39);
            this.txtArenaID.TabIndex = 13;
            // 
            // txtArenaName
            // 
            this.txtArenaName.BackColor = System.Drawing.SystemColors.Menu;
            this.txtArenaName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtArenaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArenaName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtArenaName.Location = new System.Drawing.Point(792, 179);
            this.txtArenaName.Multiline = true;
            this.txtArenaName.Name = "txtArenaName";
            this.txtArenaName.Size = new System.Drawing.Size(173, 39);
            this.txtArenaName.TabIndex = 14;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.BackColor = System.Drawing.SystemColors.Menu;
            this.txtStreetAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetAddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtStreetAddress.Location = new System.Drawing.Point(792, 269);
            this.txtStreetAddress.Multiline = true;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(173, 39);
            this.txtStreetAddress.TabIndex = 15;
            // 
            // txtSuburb
            // 
            this.txtSuburb.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSuburb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuburb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSuburb.Location = new System.Drawing.Point(792, 356);
            this.txtSuburb.Multiline = true;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(173, 39);
            this.txtSuburb.TabIndex = 16;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCity.Location = new System.Drawing.Point(792, 438);
            this.txtCity.Multiline = true;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(173, 39);
            this.txtCity.TabIndex = 17;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPhoneNumber.Location = new System.Drawing.Point(792, 528);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(173, 39);
            this.txtPhoneNumber.TabIndex = 18;
            // 
            // ArenaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 826);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtArenaName);
            this.Controls.Add(this.txtArenaID);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblArenaName);
            this.Controls.Add(this.lblArenaID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteArena);
            this.Controls.Add(this.btnUpdateArena);
            this.Controls.Add(this.btnAddArena);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstArena);
            this.Name = "ArenaForm";
            this.Text = "Arena Maintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstArena;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddArena;
        private System.Windows.Forms.Button btnUpdateArena;
        private System.Windows.Forms.Button btnDeleteArena;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblArenaID;
        private System.Windows.Forms.Label lblArenaName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtArenaID;
        private System.Windows.Forms.TextBox txtArenaName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhoneNumber;
    }
}