using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolkitLibrary;

namespace FormUI
{
    public partial class CharacterManagerForm : Form
    {
        public CharacterManagerForm() {
            InitializeComponent();
        }

        private void CharacterManagerForm_Load(object sender, EventArgs e) {

        }

        private void strengthInputBox_TextChanged(object sender, EventArgs e) {
            UpdateModifiers(strengthInputBox);
        }

        private void UpdateModifiers(TextBox textBox) {
            AbilityStat abilityStat = new AbilityStat();
            int level = int.Parse(characterLevel.Text);
            strengthModifier.Text = abilityStat
                .CalculateModifier(uint.Parse(textBox.Text))
                .ToString();
            strengthModifierWithLevel.Text = abilityStat
                .CalculateModifierWithLevel(uint.Parse(textBox.Text), level)
                .ToString();
        }

        private bool ValidateInput() {
            bool output = true;
            uint strengthValue = 0, constitutionValue = 0, dexterityValue = 0, wisdomValue = 0, intelligenceValue = 0, charismaValue = 0 ;
            
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(strengthInputBox);
            textBoxes.Add(constitutionInputBox);
            textBoxes.Add(dexterityInputBox);
            textBoxes.Add(wisdomInputBox);
            textBoxes.Add(intelligenceInputBox);
            textBoxes.Add(charismaInputBox);

            List<TextBox> textBoxesParsable = textBoxes
                .Where(x => uint.TryParse(x.Text, out uint parsable))
                .ToList();

            if ( textBoxes.Count != textBoxesParsable.Count ) {
                output = false;
            }

            List<uint> inputValues = new List<uint>();
            inputValues.Add(strengthValue);
            inputValues.Add(constitutionValue);
            inputValues.Add(dexterityValue);
            inputValues.Add(wisdomValue);
            inputValues.Add(intelligenceValue);
            inputValues.Add(charismaValue);

            foreach ( var textBox in textBoxes )
            {
                if ( textBox.TextLength == 0 )
                {
                    output = false;
                }
            }

            foreach ( var inputValue in inputValues )
            {
                if ( inputValue < 1 )
                {
                    output = false;
                }
            }
            
            if ( characterName.TextLength == 0 || characterClass.TextLength == 0 || characterRace.TextLength == 0 || characterLevel.TextLength == 0 ) {
                bool length = true;
                output = false;
            }

            return output;
        }

        private void strengthModifier_Click(object sender, EventArgs e) {

        }

        private void saveCharacter_Click(object sender, EventArgs e) {
            if ( ValidateInput() )
            {
                CharacterModel model = new CharacterModel();
            }
            else
            {
                MessageBox.Show("Data missing or incorrect. Please check and try again.");
            }
        }
    }
}
