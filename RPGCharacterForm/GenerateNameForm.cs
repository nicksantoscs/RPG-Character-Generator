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
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        /**
         * This method runs through the list of first and last names and saves the
         * selected name in the Program.character object
         * */

        private void GenerateNames(object sender, EventArgs e)
        {
            var generate = new Random();
            int list = generate.Next(0, FirstNameListBox.Items.Count - 1);

            firstNameTextBox.Text = FirstNameListBox.Items[list].ToString();
            lastNameTextBox.Text = LastNameListBox.Items[list].ToString();

            Program.character.firstName = firstNameTextBox.Text;
            Program.character.lastName = lastNameTextBox.Text;
        }

        /**
         * Proceeds to the abilityGenerator form.
         * */
        private void NextButton_Click(object sender, EventArgs e)
        {
            AbilityGeneratorForm abilityGenerator = new AbilityGeneratorForm();
            abilityGenerator.Show();
            this.Hide();
        }
    }
}
