using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_Checkpoint1
{
    public partial class MainForm : Form
    {
        private DataModule DM; // the reference to the form that holds the data components
        private ArenaForm frmArena; // the reference to the arena form
        private ChallengeForm frmChallenge; // the reference to the challenge form
        private CompetitorForm frmCompetitor; // the reference to the competitor form
        private CompetitorReportForm frmCompetitorReport; // the reference to the competitor report form
        private EntryForm frmEntry; // the reference to the entry form
        private EventForm frmEvent; // the reference to the visit event form
        private EventReportForm frmEventReport; // the reference to the event report form

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DM = new DataModule(); //create the data module and load the dataset
        }
        

        // create a button click method on the button named btnArena
        private void btnArena_Click(object sender, EventArgs e)
        {
            if (frmArena == null)
            {
                frmArena = new ArenaForm(DM, this);
            }
            frmArena.ShowDialog();
        }

        // create a button click method on the button named btnExit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {

        }
    }
}
