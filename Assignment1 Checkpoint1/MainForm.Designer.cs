namespace Assignment1_Checkpoint1
{
    partial class MainForm
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
            this.grpMaintenance = new System.Windows.Forms.GroupBox();
            this.btnEntry = new System.Windows.Forms.Button();
            this.btnCompetitor = new System.Windows.Forms.Button();
            this.btnArena = new System.Windows.Forms.Button();
            this.btnChallenge = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCompetitorReport = new System.Windows.Forms.Button();
            this.btnEventReport = new System.Windows.Forms.Button();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.grpMaintenance.SuspendLayout();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMaintenance
            // 
            this.grpMaintenance.Controls.Add(this.btnEntry);
            this.grpMaintenance.Controls.Add(this.btnCompetitor);
            this.grpMaintenance.Controls.Add(this.btnArena);
            this.grpMaintenance.Controls.Add(this.btnChallenge);
            this.grpMaintenance.Controls.Add(this.btnEvent);
            this.grpMaintenance.Location = new System.Drawing.Point(56, 69);
            this.grpMaintenance.Name = "grpMaintenance";
            this.grpMaintenance.Size = new System.Drawing.Size(369, 595);
            this.grpMaintenance.TabIndex = 0;
            this.grpMaintenance.TabStop = false;
            this.grpMaintenance.Text = "Maintenance";
            // 
            // btnEntry
            // 
            this.btnEntry.Location = new System.Drawing.Point(39, 451);
            this.btnEntry.Name = "btnEntry";
            this.btnEntry.Size = new System.Drawing.Size(277, 83);
            this.btnEntry.TabIndex = 4;
            this.btnEntry.Text = "Enter Competitor into Challege";
            this.btnEntry.UseVisualStyleBackColor = true;
            // 
            // btnCompetitor
            // 
            this.btnCompetitor.Location = new System.Drawing.Point(39, 329);
            this.btnCompetitor.Name = "btnCompetitor";
            this.btnCompetitor.Size = new System.Drawing.Size(277, 61);
            this.btnCompetitor.TabIndex = 3;
            this.btnCompetitor.Text = "Competitor Maintenance";
            this.btnCompetitor.UseVisualStyleBackColor = true;
            // 
            // btnArena
            // 
            this.btnArena.Location = new System.Drawing.Point(39, 48);
            this.btnArena.Name = "btnArena";
            this.btnArena.Size = new System.Drawing.Size(277, 61);
            this.btnArena.TabIndex = 0;
            this.btnArena.Text = "Arena Maintenance";
            this.btnArena.UseVisualStyleBackColor = true;
            this.btnArena.Click += new System.EventHandler(this.btnArena_Click);
            // 
            // btnChallenge
            // 
            this.btnChallenge.Location = new System.Drawing.Point(39, 235);
            this.btnChallenge.Name = "btnChallenge";
            this.btnChallenge.Size = new System.Drawing.Size(277, 61);
            this.btnChallenge.TabIndex = 2;
            this.btnChallenge.Text = "Challenge Maintenance";
            this.btnChallenge.UseVisualStyleBackColor = true;
            // 
            // btnEvent
            // 
            this.btnEvent.Location = new System.Drawing.Point(39, 146);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(277, 61);
            this.btnEvent.TabIndex = 1;
            this.btnEvent.Text = "Event Maintenance";
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.btnExit);
            this.grpReport.Controls.Add(this.btnCompetitorReport);
            this.grpReport.Controls.Add(this.btnEventReport);
            this.grpReport.Location = new System.Drawing.Point(487, 69);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(369, 595);
            this.grpReport.TabIndex = 1;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Reporting";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(47, 473);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(277, 61);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCompetitorReport
            // 
            this.btnCompetitorReport.Location = new System.Drawing.Point(47, 146);
            this.btnCompetitorReport.Name = "btnCompetitorReport";
            this.btnCompetitorReport.Size = new System.Drawing.Size(277, 61);
            this.btnCompetitorReport.TabIndex = 6;
            this.btnCompetitorReport.Text = "Competitor Report";
            this.btnCompetitorReport.UseVisualStyleBackColor = true;
            // 
            // btnEventReport
            // 
            this.btnEventReport.Location = new System.Drawing.Point(47, 48);
            this.btnEventReport.Name = "btnEventReport";
            this.btnEventReport.Size = new System.Drawing.Size(277, 61);
            this.btnEventReport.TabIndex = 5;
            this.btnEventReport.Text = "Event Report";
            this.btnEventReport.UseVisualStyleBackColor = true;
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 731);
            this.Controls.Add(this.grpReport);
            this.Controls.Add(this.grpMaintenance);
            this.Name = "MainForm";
            this.Text = "Main Menue";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMaintenance.ResumeLayout(false);
            this.grpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMaintenance;
        private System.Windows.Forms.Button btnEntry;
        private System.Windows.Forms.Button btnCompetitor;
        private System.Windows.Forms.Button btnArena;
        private System.Windows.Forms.Button btnChallenge;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCompetitorReport;
        private System.Windows.Forms.Button btnEventReport;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
    }
}

