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

        private void btnAddArena_Click(object sender, EventArgs e)
        {
            txtArenaID.Text = null;
            DataRow newArenaRow = DM.dtArena.NewRow();

            if ((txtArenaID.Text == "") || (txtArenaName.Text == "") || (txtStreetAddress.Text == "") || (txtCity.Text == "") || (txtPhoneNumber.Text == "") || (txtSuburb.Text == ""))
            {
                MessageBox.Show("You must type in a Arena name, street address and phone number", "Error");
            }
            else
            {
                newArenaRow["Arena ID"] = Convert.ToDouble(txtArenaID.Text);
                newArenaRow["Arena Name"] = txtArenaName.Text;
                newArenaRow["StreetAddress"] = txtStreetAddress.Text;
                newArenaRow["Suburb"] = txtSuburb.Text;
                newArenaRow["City"] = txtCity.Text;
                newArenaRow["Phone Number"] = txtPhoneNumber.Text;
                DM.dtArena.Rows.Add(newArenaRow);
                MessageBox.Show("Arena added successfully", "Success");
                DM.UpdateArena();
            }
        }

        
    }
}
