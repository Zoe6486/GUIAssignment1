using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Assignment1_Checkpoint1
{
    public partial class DataModule : Form
    {
        public DataTable dtArena;
        public DataTable dtChallenge;
        public DataTable dtCompetitor;
        public DataTable dtEvent;
        public DataTable dtEntry;
        public DataView arenaView;
        public DataView challengeView;
        public DataView competitorView;
        public DataView eventView;
        public DataView entryView;

        public DataModule()
        {
            InitializeComponent();
            dsNZST.EnforceConstraints = false;
            daArena.Fill(dsNZST);
  /*          daChallenge.Fill(dsNZST);
            daCompetitor.Fill(dsNZST);
            daEvent.Fill(dsNZST);
            daEntry.Fill(dsNZST);*/
            dtArena = dsNZST.Tables["Arena"];
           /* dtChallenge = dsNZST.Tables["Challenge"];
            dtCompetitor = dsNZST.Tables["Competitor"];
            dtEvent = dsNZST.Tables["Event"];
            dtEntry = dsNZST.Tables["Entry"];*/
            dsNZST.EnforceConstraints = true;

            arenaView = new DataView(dtArena);
            arenaView.Sort = "ArenaID";
        }
        public void UpdateArena()
        {
            daArena.Update(dtArena);
        }

    }
}

