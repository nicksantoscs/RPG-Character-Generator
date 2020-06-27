//Character Creator App
//Nicholas Santos
//April 16, 2020
//This purpose of this application is to automatically generate attributes to create a custom
//character for the user.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace COMP1004_F2016_Mid_Term_Exam
{
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        
        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();
        }
        /**
         * This method fills in each textbox with the values saved to the
         * Program.character object from the previous forms. 
         * */
        private void FinalForm_Load(object sender, EventArgs e)
        {
            firstNameTextBox.Text = Program.character.firstName;
            LastNameTextBox.Text = Program.character.lastName;
            raceTextBox.Text = Program.character.Race;
            StrengthTextBox.Text = Program.character.Strength;
            DexterityTextBox.Text = Program.character.Dexterity;
            ConstitutionTextBox.Text = Program.character.Constitution;
            IntelligenceTextBox.Text = Program.character.Intelligence;
            WisdomTextBox.Text = Program.character.Wisdom;
            CharismaTextBox.Text = Program.character.Charisma;
        }

        /**
         * Closes the application
         * */

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
