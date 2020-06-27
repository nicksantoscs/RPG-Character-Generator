//Character Creator App
//Nicholas Santos
//April 16, 2020
//This purpose of this application is to automatically generate attributes to create a custom
//character for the user.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace COMP1004_F2016_Mid_Term_Exam
{
    public partial class AbilityGeneratorForm : Form
    {
        // private Instance Object
        private Random _random;



        public AbilityGeneratorForm()
        {
            InitializeComponent();
        }

        private Int32 Roll()
        {
            // create new empty list
            List<Int32> numbers = new List<Int32>();
            int result = 0;

            // roll 4 dice
            for (int count = 0; count < 4; count++)
            {
                int generatedNumber = this._random.Next(0, 6) + 1;
                numbers.Add(generatedNumber);
            }

            // drop the lowest die
            numbers.Remove(numbers.Min());

            // add the numbers to the result

            foreach (int number in numbers)
            {
                result += number;
            }

            // lambda expression equivalent
            //result = numbers.Sum(number => number);

            return result;
        }

        private void GenerateAbilities()
        {
            StrengthTextBox.Text = this.Roll().ToString();
            DexterityTextBox.Text = this.Roll().ToString();
            ConstitutionTextBox.Text = this.Roll().ToString();
            IntelligenceTextBox.Text = this.Roll().ToString();
            WisdomTextBox.Text = this.Roll().ToString();
            CharismaTextBox.Text = this.Roll().ToString();
        }


        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateAbilities();
        }

        private void GeneratorForm_Load(object sender, EventArgs e)
        {
            this._random = new Random(); // initialize random number object

            GenerateAbilities();

        }


        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = Program.character;

            character.Strength = StrengthTextBox.Text;
            character.Dexterity = DexterityTextBox.Text;
            character.Constitution = ConstitutionTextBox.Text;
            character.Intelligence = IntelligenceTextBox.Text;
            character.Wisdom = WisdomTextBox.Text;
            character.Charisma = CharismaTextBox.Text;

            // Step 1 - Hide the parent form
            this.Hide();

            // Step 2 - Instantiate an object for the form type
            // you are going to next
            RaceAndClassForm raceAndClassForm = new RaceAndClassForm();

            // Step 3 - create a property in the next form that 
            // we will use to point to this form
            // e.g. public AbilityGeneratorForm previousForm;

            // Step 4 - point this form to the parent Form 
            // property in the next form
            raceAndClassForm.previousForm = this;

            // Step 5 - Show the next form
            raceAndClassForm.Show();
        }
    }
}
