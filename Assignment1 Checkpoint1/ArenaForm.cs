using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment1_Checkpoint1
{
    public partial class ArenaForm : Form
    {
        private DataModule DM; //the references to the DataModule form that holds the data components
        private MainForm frmMenu; //the reference to the main form 
        private CurrencyManager currencyManager; //a reference for a CurrencyManager object
        public ArenaForm(DataModule dm, MainForm mnu)
        {
            InitializeComponent();
            DM = dm; // accept the DataModule references
            frmMenu = mnu; // accept the DataModule and MainForm references
            BindControls();
        }
        // create a method called BindControls that binds the data in the arena table to label and text boxes
        public void BindControls()
        {
            txtArenaID.DataBindings.Add("Text", DM.dsNZST, "Arena.ArenaID");
            txtArenaName.DataBindings.Add("Text", DM.dsNZST, "Arena.ArenaName");
            txtStreetAddress.DataBindings.Add("Text", DM.dsNZST, "Arena.StreetAddress");
            txtSuburb.DataBindings.Add("Text", DM.dsNZST, "Arena.Suburb");
            txtCity.DataBindings.Add("Text", DM.dsNZST, "Arena.City");
            txtPhoneNumber.DataBindings.Add("Text", DM.dsNZST, "Arena.PhoneNumber");
            lstArena.DataSource = DM.dsNZST;
            lstArena.DisplayMember = "Arena.ArenaName";
            lstArena.ValueMember = "Arena.ArenaName";
            currencyManager = (CurrencyManager)this.BindingContext[DM.dsNZST, "ARENA"];
        }
        // set the initial arena form(some controls are visible, some are hidden)
        private void ArenaForm_Load(object sender, EventArgs e)
        {
            SetControlsState(true, true, true, true, true, true, true, true, false, false);
        }

        // create a button click method on the button named btnPrevious
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position > 0)
            {
                --currencyManager.Position;
            }
        }

        // create a button click method on the button named btnNext
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currencyManager.Position < currencyManager.Count - 1)
            {
                ++currencyManager.Position;
            }
        }

        // create a button click method on the button named btnReturn
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        //creat a method to empty the  input  of added arena textboxs
        private void SetAddedArenaEmpty()
        {
            txtAddArenaName.Text = "";
            txtAddStreetAddress.Text = "";
            txtAddSuburb.Text = "";
            txtAddCity.Text = "";
            txtAddPhoneNumber.Text = "";
        }

        //create a method to decide controls state(visibility and operability)
        private void SetControlsState(bool blPevious, bool blNext, bool blAdd, bool blUpdate, bool blDelete, bool blReturn, bool blArena, bool blPnlrena,
          bool blPnlAddArena, bool blPnlUpdateArena)
        {
            btnPrevious.Enabled = blPevious;
            btnNext.Enabled = blNext;
            btnAddArena.Enabled = blAdd;
            btnUpdateArena.Enabled = blUpdate;
            btnDeleteArena.Enabled = blDelete;
            btnReturn.Enabled = blReturn;
            lstArena.Visible = blArena;
            pnlArena.Visible = blPnlrena;
            pnlAddArena.Visible = blPnlAddArena;
            pnlUpdateArena.Visible = blPnlUpdateArena;
        }

        // create a button click method on the button named btnAddArena
        private void btnAddArena_Click(object sender, EventArgs e)
        {
            SetAddedArenaEmpty();
            SetControlsState(false, false, true, false, false, false, false, false, true, false);
        }


        //create a button click method on the button named btnSaveArena
        private void btnSaveArena_Click(object sender, EventArgs e)
        {
            if ((txtAddArenaName.Text == "") || (txtAddStreetAddress.Text == "") || (txtAddSuburb.Text == "")
                  || (txtAddCity.Text == "") || (txtAddPhoneNumber.Text == ""))
            {
                MessageBox.Show("You must type in a Arena name, street address, city, suburb and phone number", "Error");
            }
            // add a new row
            else
            {
                DataRow newArenaRow = DM.dtArena.NewRow();
                newArenaRow["ArenaName"] = txtAddArenaName.Text;
                newArenaRow["StreetAddress"] = txtAddStreetAddress.Text;
                newArenaRow["Suburb"] = txtAddSuburb.Text;
                newArenaRow["City"] = txtAddCity.Text;
                newArenaRow["PhoneNumber"] = txtAddPhoneNumber.Text;
                DM.dtArena.Rows.Add(newArenaRow);
                MessageBox.Show("Arena added successfully", "Success");
                DM.UpdateArena();
                SetAddedArenaEmpty();
            }
        }

        // create a button click method on the button named btnCancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            SetControlsState(true, true, true, true, true, true, true, true, false, false);
        }


        // create a button click method on the button named btnUpdateArena
        private void btnUpdateArena_Click(object sender, EventArgs e)
        {
            SetControlsState(false, false, false, true, false, false, false, false, false, true);
            txtUpdateArenaName.Text = txtArenaName.Text;
            txtUpdateStreetAddress.Text = txtStreetAddress.Text;
            txtUpdateCity.Text = txtCity.Text;
            txtUpdateSuburb.Text = txtSuburb.Text;
            txtUpdatePhoneNumber.Text = txtPhoneNumber.Text;
        }

        // create a button click method on the button named btnSaveChanges
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if ((txtUpdateArenaName.Text == "") || (txtUpdateStreetAddress.Text == "") || (txtUpdateSuburb.Text == "")
                  || (txtUpdateCity.Text == "") || (txtUpdatePhoneNumber.Text == ""))
            {
                MessageBox.Show("You must type in a Arena name, street address, city, suburb and phone number", "Error");
            }
            else
            {
                //Add the text areas
                DataRow updateArenaRow = DM.dtArena.Rows[currencyManager.Position];
                updateArenaRow["ArenaName"] = txtUpdateArenaName.Text;
                updateArenaRow["StreetAddress"] = txtUpdateStreetAddress.Text;
                updateArenaRow["Suburb"] = txtUpdateSuburb.Text;
                updateArenaRow["City"] = txtUpdateCity.Text;
                updateArenaRow["PhoneNumber"] = txtUpdatePhoneNumber.Text;
                //Update the database
                currencyManager.EndCurrentEdit();
                DM.UpdateArena();
                //Give the user a success message
                MessageBox.Show("Arena updated successfully", "Success");
            }
        }

        // Create a button click method on the button named btnUpdateCancel
        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            SetControlsState(true, true, true, true, true, true, true, true, false, false);
        }

        // Create a button click method on the button named btnDeleteArena
        private void btnDeleteArena_Click(object sender, EventArgs e)
        {
            DataRow deleteArenaRow = DM.dtArena.Rows[currencyManager.Position];
            DataRow[] EventRow = DM.dtEvent.Select("ArenaID = " + txtArenaID.Text);
            if (EventRow.Length != 0)
            {
                MessageBox.Show("You may only delete Arenas that are not allocated to events", "Error");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    deleteArenaRow.Delete();
                    DM.UpdateArena();
                }
            }
        }
    }
}
