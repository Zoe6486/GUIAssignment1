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
            this.pnlArena = new System.Windows.Forms.Panel();
            this.txtAddArenaName = new System.Windows.Forms.TextBox();
            this.txtAddStreetAddress = new System.Windows.Forms.TextBox();
            this.txtAddPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddSuburb = new System.Windows.Forms.TextBox();
            this.txtAddCity = new System.Windows.Forms.TextBox();
            this.lblAddArenaName = new System.Windows.Forms.Label();
            this.lblAddStreetAddress = new System.Windows.Forms.Label();
            this.lblAddSuburb = new System.Windows.Forms.Label();
            this.lblAddCity = new System.Windows.Forms.Label();
            this.lblAddPhoneNumber = new System.Windows.Forms.Label();
            this.btnSaveArena = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlAddArena = new System.Windows.Forms.Panel();
            this.pnlUpdateArena = new System.Windows.Forms.Panel();
            this.lblUpdateArenaName = new System.Windows.Forms.Label();
            this.lblUpdateStreetAddress = new System.Windows.Forms.Label();
            this.lblUpdateCity = new System.Windows.Forms.Label();
            this.lblUpdateSuburb = new System.Windows.Forms.Label();
            this.lblUpdatePhoneNumber = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.txtUpdateArenaName = new System.Windows.Forms.TextBox();
            this.txtUpdateStreetAddress = new System.Windows.Forms.TextBox();
            this.txtUpdateCity = new System.Windows.Forms.TextBox();
            this.txtUpdateSuburb = new System.Windows.Forms.TextBox();
            this.txtUpdatePhoneNumber = new System.Windows.Forms.TextBox();
            this.pnlArena.SuspendLayout();
            this.pnlAddArena.SuspendLayout();
            this.pnlUpdateArena.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstArena
            // 
            this.lstArena.FormattingEnabled = true;
            this.lstArena.ItemHeight = 25;
            this.lstArena.Location = new System.Drawing.Point(53, 80);
            this.lstArena.Name = "lstArena";
            this.lstArena.Size = new System.Drawing.Size(436, 504);
            this.lstArena.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(53, 623);
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
            this.btnNext.Location = new System.Drawing.Point(288, 623);
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
            this.btnAddArena.Location = new System.Drawing.Point(529, 626);
            this.btnAddArena.Name = "btnAddArena";
            this.btnAddArena.Size = new System.Drawing.Size(203, 64);
            this.btnAddArena.TabIndex = 3;
            this.btnAddArena.Text = "Add Arena";
            this.btnAddArena.UseVisualStyleBackColor = true;
            this.btnAddArena.Click += new System.EventHandler(this.btnAddArena_Click);
            // 
            // btnUpdateArena
            // 
            this.btnUpdateArena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateArena.Location = new System.Drawing.Point(772, 626);
            this.btnUpdateArena.Name = "btnUpdateArena";
            this.btnUpdateArena.Size = new System.Drawing.Size(226, 64);
            this.btnUpdateArena.TabIndex = 4;
            this.btnUpdateArena.Text = "Update Arena";
            this.btnUpdateArena.UseVisualStyleBackColor = true;
            this.btnUpdateArena.Click += new System.EventHandler(this.btnUpdateArena_Click);
            // 
            // btnDeleteArena
            // 
            this.btnDeleteArena.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteArena.Location = new System.Drawing.Point(1034, 626);
            this.btnDeleteArena.Name = "btnDeleteArena";
            this.btnDeleteArena.Size = new System.Drawing.Size(220, 64);
            this.btnDeleteArena.TabIndex = 5;
            this.btnDeleteArena.Text = "Delete Arena";
            this.btnDeleteArena.UseVisualStyleBackColor = true;
            this.btnDeleteArena.Click += new System.EventHandler(this.btnDeleteArena_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(1034, 712);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(220, 64);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblArenaID
            // 
            this.lblArenaID.AutoSize = true;
            this.lblArenaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaID.Location = new System.Drawing.Point(91, 68);
            this.lblArenaID.Name = "lblArenaID";
            this.lblArenaID.Size = new System.Drawing.Size(129, 31);
            this.lblArenaID.TabIndex = 7;
            this.lblArenaID.Text = "Arena ID:";
            // 
            // lblArenaName
            // 
            this.lblArenaName.AutoSize = true;
            this.lblArenaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArenaName.Location = new System.Drawing.Point(47, 146);
            this.lblArenaName.Name = "lblArenaName";
            this.lblArenaName.Size = new System.Drawing.Size(173, 31);
            this.lblArenaName.TabIndex = 8;
            this.lblArenaName.Text = "Arena Name:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress.Location = new System.Drawing.Point(21, 236);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(199, 31);
            this.lblStreetAddress.TabIndex = 9;
            this.lblStreetAddress.Text = "Street address:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuburb.Location = new System.Drawing.Point(111, 325);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(109, 31);
            this.lblSuburb.TabIndex = 10;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(148, 407);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(72, 31);
            this.lblCity.TabIndex = 11;
            this.lblCity.Text = "CIty:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(17, 498);
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
            this.txtArenaID.Location = new System.Drawing.Point(263, 60);
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
            this.txtArenaName.Location = new System.Drawing.Point(263, 146);
            this.txtArenaName.Multiline = true;
            this.txtArenaName.Name = "txtArenaName";
            this.txtArenaName.Size = new System.Drawing.Size(257, 39);
            this.txtArenaName.TabIndex = 14;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.BackColor = System.Drawing.SystemColors.Menu;
            this.txtStreetAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetAddress.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtStreetAddress.Location = new System.Drawing.Point(263, 236);
            this.txtStreetAddress.Multiline = true;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(386, 39);
            this.txtStreetAddress.TabIndex = 15;
            // 
            // txtSuburb
            // 
            this.txtSuburb.BackColor = System.Drawing.SystemColors.Menu;
            this.txtSuburb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuburb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtSuburb.Location = new System.Drawing.Point(263, 323);
            this.txtSuburb.Multiline = true;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(257, 39);
            this.txtSuburb.TabIndex = 16;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.Menu;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCity.Location = new System.Drawing.Point(263, 405);
            this.txtCity.Multiline = true;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(257, 39);
            this.txtCity.TabIndex = 17;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Menu;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPhoneNumber.Location = new System.Drawing.Point(263, 495);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(257, 39);
            this.txtPhoneNumber.TabIndex = 18;
            // 
            // pnlArena
            // 
            this.pnlArena.Controls.Add(this.lblArenaID);
            this.pnlArena.Controls.Add(this.txtPhoneNumber);
            this.pnlArena.Controls.Add(this.txtCity);
            this.pnlArena.Controls.Add(this.txtSuburb);
            this.pnlArena.Controls.Add(this.txtStreetAddress);
            this.pnlArena.Controls.Add(this.txtArenaName);
            this.pnlArena.Controls.Add(this.txtArenaID);
            this.pnlArena.Controls.Add(this.lblPhoneNumber);
            this.pnlArena.Controls.Add(this.lblCity);
            this.pnlArena.Controls.Add(this.lblSuburb);
            this.pnlArena.Controls.Add(this.lblStreetAddress);
            this.pnlArena.Controls.Add(this.lblArenaName);
            this.pnlArena.Location = new System.Drawing.Point(552, 50);
            this.pnlArena.Name = "pnlArena";
            this.pnlArena.Size = new System.Drawing.Size(658, 567);
            this.pnlArena.TabIndex = 19;
            // 
            // txtAddArenaName
            // 
            this.txtAddArenaName.Location = new System.Drawing.Point(203, 25);
            this.txtAddArenaName.Name = "txtAddArenaName";
            this.txtAddArenaName.Size = new System.Drawing.Size(303, 31);
            this.txtAddArenaName.TabIndex = 19;
            // 
            // txtAddStreetAddress
            // 
            this.txtAddStreetAddress.Location = new System.Drawing.Point(203, 111);
            this.txtAddStreetAddress.Name = "txtAddStreetAddress";
            this.txtAddStreetAddress.Size = new System.Drawing.Size(303, 31);
            this.txtAddStreetAddress.TabIndex = 20;
            // 
            // txtAddPhoneNumber
            // 
            this.txtAddPhoneNumber.Location = new System.Drawing.Point(203, 367);
            this.txtAddPhoneNumber.Name = "txtAddPhoneNumber";
            this.txtAddPhoneNumber.Size = new System.Drawing.Size(303, 31);
            this.txtAddPhoneNumber.TabIndex = 21;
            // 
            // txtAddSuburb
            // 
            this.txtAddSuburb.Location = new System.Drawing.Point(203, 210);
            this.txtAddSuburb.Name = "txtAddSuburb";
            this.txtAddSuburb.Size = new System.Drawing.Size(303, 31);
            this.txtAddSuburb.TabIndex = 22;
            // 
            // txtAddCity
            // 
            this.txtAddCity.Location = new System.Drawing.Point(203, 291);
            this.txtAddCity.Name = "txtAddCity";
            this.txtAddCity.Size = new System.Drawing.Size(303, 31);
            this.txtAddCity.TabIndex = 23;
            // 
            // lblAddArenaName
            // 
            this.lblAddArenaName.AutoSize = true;
            this.lblAddArenaName.Location = new System.Drawing.Point(63, 28);
            this.lblAddArenaName.Name = "lblAddArenaName";
            this.lblAddArenaName.Size = new System.Drawing.Size(131, 25);
            this.lblAddArenaName.TabIndex = 24;
            this.lblAddArenaName.Text = "Arena Name";
            // 
            // lblAddStreetAddress
            // 
            this.lblAddStreetAddress.AutoSize = true;
            this.lblAddStreetAddress.Location = new System.Drawing.Point(40, 112);
            this.lblAddStreetAddress.Name = "lblAddStreetAddress";
            this.lblAddStreetAddress.Size = new System.Drawing.Size(154, 25);
            this.lblAddStreetAddress.TabIndex = 25;
            this.lblAddStreetAddress.Text = "Street Address";
            // 
            // lblAddSuburb
            // 
            this.lblAddSuburb.AutoSize = true;
            this.lblAddSuburb.Location = new System.Drawing.Point(113, 210);
            this.lblAddSuburb.Name = "lblAddSuburb";
            this.lblAddSuburb.Size = new System.Drawing.Size(81, 25);
            this.lblAddSuburb.TabIndex = 26;
            this.lblAddSuburb.Text = "Suburb";
            // 
            // lblAddCity
            // 
            this.lblAddCity.AutoSize = true;
            this.lblAddCity.Location = new System.Drawing.Point(133, 294);
            this.lblAddCity.Name = "lblAddCity";
            this.lblAddCity.Size = new System.Drawing.Size(49, 25);
            this.lblAddCity.TabIndex = 27;
            this.lblAddCity.Text = "City";
            // 
            // lblAddPhoneNumber
            // 
            this.lblAddPhoneNumber.AutoSize = true;
            this.lblAddPhoneNumber.Location = new System.Drawing.Point(31, 367);
            this.lblAddPhoneNumber.Name = "lblAddPhoneNumber";
            this.lblAddPhoneNumber.Size = new System.Drawing.Size(155, 25);
            this.lblAddPhoneNumber.TabIndex = 28;
            this.lblAddPhoneNumber.Text = "Phone Number";
            // 
            // btnSaveArena
            // 
            this.btnSaveArena.Location = new System.Drawing.Point(90, 433);
            this.btnSaveArena.Name = "btnSaveArena";
            this.btnSaveArena.Size = new System.Drawing.Size(158, 44);
            this.btnSaveArena.TabIndex = 29;
            this.btnSaveArena.Text = "Save Arena";
            this.btnSaveArena.UseVisualStyleBackColor = true;
            this.btnSaveArena.Click += new System.EventHandler(this.btnSaveArena_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(338, 433);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(158, 44);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlAddArena
            // 
            this.pnlAddArena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddArena.Controls.Add(this.btnSaveArena);
            this.pnlAddArena.Controls.Add(this.btnCancel);
            this.pnlAddArena.Controls.Add(this.lblAddPhoneNumber);
            this.pnlAddArena.Controls.Add(this.txtAddPhoneNumber);
            this.pnlAddArena.Controls.Add(this.lblAddCity);
            this.pnlAddArena.Controls.Add(this.txtAddCity);
            this.pnlAddArena.Controls.Add(this.lblAddSuburb);
            this.pnlAddArena.Controls.Add(this.txtAddSuburb);
            this.pnlAddArena.Controls.Add(this.lblAddStreetAddress);
            this.pnlAddArena.Controls.Add(this.lblAddArenaName);
            this.pnlAddArena.Controls.Add(this.txtAddStreetAddress);
            this.pnlAddArena.Controls.Add(this.txtAddArenaName);
            this.pnlAddArena.Location = new System.Drawing.Point(539, 72);
            this.pnlAddArena.Name = "pnlAddArena";
            this.pnlAddArena.Size = new System.Drawing.Size(574, 506);
            this.pnlAddArena.TabIndex = 31;
            // 
            // pnlUpdateArena
            // 
            this.pnlUpdateArena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUpdateArena.Controls.Add(this.txtUpdatePhoneNumber);
            this.pnlUpdateArena.Controls.Add(this.txtUpdateSuburb);
            this.pnlUpdateArena.Controls.Add(this.txtUpdateCity);
            this.pnlUpdateArena.Controls.Add(this.txtUpdateStreetAddress);
            this.pnlUpdateArena.Controls.Add(this.txtUpdateArenaName);
            this.pnlUpdateArena.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateArena.Controls.Add(this.btnSaveChanges);
            this.pnlUpdateArena.Controls.Add(this.lblUpdatePhoneNumber);
            this.pnlUpdateArena.Controls.Add(this.lblUpdateSuburb);
            this.pnlUpdateArena.Controls.Add(this.lblUpdateCity);
            this.pnlUpdateArena.Controls.Add(this.lblUpdateStreetAddress);
            this.pnlUpdateArena.Controls.Add(this.lblUpdateArenaName);
            this.pnlUpdateArena.Location = new System.Drawing.Point(575, 31);
            this.pnlUpdateArena.Name = "pnlUpdateArena";
            this.pnlUpdateArena.Size = new System.Drawing.Size(622, 568);
            this.pnlUpdateArena.TabIndex = 32;
            // 
            // lblUpdateArenaName
            // 
            this.lblUpdateArenaName.AutoSize = true;
            this.lblUpdateArenaName.Location = new System.Drawing.Point(45, 66);
            this.lblUpdateArenaName.Name = "lblUpdateArenaName";
            this.lblUpdateArenaName.Size = new System.Drawing.Size(137, 25);
            this.lblUpdateArenaName.TabIndex = 0;
            this.lblUpdateArenaName.Text = "Arena Name:";
            // 
            // lblUpdateStreetAddress
            // 
            this.lblUpdateStreetAddress.AutoSize = true;
            this.lblUpdateStreetAddress.Location = new System.Drawing.Point(45, 136);
            this.lblUpdateStreetAddress.Name = "lblUpdateStreetAddress";
            this.lblUpdateStreetAddress.Size = new System.Drawing.Size(160, 25);
            this.lblUpdateStreetAddress.TabIndex = 1;
            this.lblUpdateStreetAddress.Text = "Street Address:";
            // 
            // lblUpdateCity
            // 
            this.lblUpdateCity.AutoSize = true;
            this.lblUpdateCity.Location = new System.Drawing.Point(84, 307);
            this.lblUpdateCity.Name = "lblUpdateCity";
            this.lblUpdateCity.Size = new System.Drawing.Size(55, 25);
            this.lblUpdateCity.TabIndex = 2;
            this.lblUpdateCity.Text = "City:";
            // 
            // lblUpdateSuburb
            // 
            this.lblUpdateSuburb.AutoSize = true;
            this.lblUpdateSuburb.Location = new System.Drawing.Point(64, 223);
            this.lblUpdateSuburb.Name = "lblUpdateSuburb";
            this.lblUpdateSuburb.Size = new System.Drawing.Size(87, 25);
            this.lblUpdateSuburb.TabIndex = 3;
            this.lblUpdateSuburb.Text = "Suburb:";
            // 
            // lblUpdatePhoneNumber
            // 
            this.lblUpdatePhoneNumber.AutoSize = true;
            this.lblUpdatePhoneNumber.Location = new System.Drawing.Point(45, 385);
            this.lblUpdatePhoneNumber.Name = "lblUpdatePhoneNumber";
            this.lblUpdatePhoneNumber.Size = new System.Drawing.Size(161, 25);
            this.lblUpdatePhoneNumber.TabIndex = 4;
            this.lblUpdatePhoneNumber.Text = "Phone Number:";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(43, 479);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(192, 51);
            this.btnSaveChanges.TabIndex = 5;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(363, 476);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(192, 51);
            this.btnUpdateCancel.TabIndex = 6;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // txtUpdateArenaName
            // 
            this.txtUpdateArenaName.Location = new System.Drawing.Point(233, 63);
            this.txtUpdateArenaName.Name = "txtUpdateArenaName";
            this.txtUpdateArenaName.Size = new System.Drawing.Size(333, 31);
            this.txtUpdateArenaName.TabIndex = 7;
            // 
            // txtUpdateStreetAddress
            // 
            this.txtUpdateStreetAddress.Location = new System.Drawing.Point(233, 133);
            this.txtUpdateStreetAddress.Name = "txtUpdateStreetAddress";
            this.txtUpdateStreetAddress.Size = new System.Drawing.Size(333, 31);
            this.txtUpdateStreetAddress.TabIndex = 8;
            // 
            // txtUpdateCity
            // 
            this.txtUpdateCity.Location = new System.Drawing.Point(235, 301);
            this.txtUpdateCity.Name = "txtUpdateCity";
            this.txtUpdateCity.Size = new System.Drawing.Size(333, 31);
            this.txtUpdateCity.TabIndex = 9;
            // 
            // txtUpdateSuburb
            // 
            this.txtUpdateSuburb.Location = new System.Drawing.Point(233, 214);
            this.txtUpdateSuburb.Name = "txtUpdateSuburb";
            this.txtUpdateSuburb.Size = new System.Drawing.Size(333, 31);
            this.txtUpdateSuburb.TabIndex = 10;
            // 
            // txtUpdatePhoneNumber
            // 
            this.txtUpdatePhoneNumber.Location = new System.Drawing.Point(235, 385);
            this.txtUpdatePhoneNumber.Name = "txtUpdatePhoneNumber";
            this.txtUpdatePhoneNumber.Size = new System.Drawing.Size(333, 31);
            this.txtUpdatePhoneNumber.TabIndex = 11;
            // 
            // ArenaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 826);
            this.Controls.Add(this.pnlUpdateArena);
            this.Controls.Add(this.pnlAddArena);
            this.Controls.Add(this.pnlArena);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteArena);
            this.Controls.Add(this.btnUpdateArena);
            this.Controls.Add(this.btnAddArena);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.lstArena);
            this.Name = "ArenaForm";
            this.Text = "Arena Maintenance";
            this.Load += new System.EventHandler(this.ArenaForm_Load);
            this.pnlArena.ResumeLayout(false);
            this.pnlArena.PerformLayout();
            this.pnlAddArena.ResumeLayout(false);
            this.pnlAddArena.PerformLayout();
            this.pnlUpdateArena.ResumeLayout(false);
            this.pnlUpdateArena.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstArena;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddArena;
        private System.Windows.Forms.Button btnUpdateArena;
        private System.Windows.Forms.Button btnDeleteArena;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel pnlArena;
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
        private System.Windows.Forms.Panel pnlAddArena;
        private System.Windows.Forms.Label lblAddPhoneNumber;
        private System.Windows.Forms.Label lblAddCity;
        private System.Windows.Forms.Label lblAddSuburb;
        private System.Windows.Forms.Label lblAddStreetAddress;
        private System.Windows.Forms.Label lblAddArenaName;
        private System.Windows.Forms.TextBox txtAddCity;
        private System.Windows.Forms.TextBox txtAddSuburb;
        private System.Windows.Forms.TextBox txtAddPhoneNumber;
        private System.Windows.Forms.TextBox txtAddStreetAddress;
        private System.Windows.Forms.TextBox txtAddArenaName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveArena;
        private System.Windows.Forms.Panel pnlUpdateArena;
        private System.Windows.Forms.TextBox txtUpdatePhoneNumber;
        private System.Windows.Forms.TextBox txtUpdateSuburb;
        private System.Windows.Forms.TextBox txtUpdateCity;
        private System.Windows.Forms.TextBox txtUpdateStreetAddress;
        private System.Windows.Forms.TextBox txtUpdateArenaName;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Label lblUpdatePhoneNumber;
        private System.Windows.Forms.Label lblUpdateSuburb;
        private System.Windows.Forms.Label lblUpdateCity;
        private System.Windows.Forms.Label lblUpdateStreetAddress;
        private System.Windows.Forms.Label lblUpdateArenaName;
    }
}