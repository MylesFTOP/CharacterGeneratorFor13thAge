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
        private void saveCharacter_Click(object sender, EventArgs e) {
            if ( ValidateInput() )
            {
                CharacterModel model = new CharacterModel(
                    characterName.Text,
                    characterClass.Text,
                    characterRace.Text,
                    characterLevel.Text);
            }
            else
            {
                MessageBox.Show("Data missing or incorrect. Please check and try again.");
            }
        }

        private void strengthInputBox_TextChanged(object sender, EventArgs e) {
            UpdateModifiers(strengthInputBox, strengthModifier, strengthModifierWithLevel);
        }

        private void constitutionInputBox_TextChanged(object sender, EventArgs e) {
            UpdateModifiers(constitutionInputBox, constitutionModifier, constitutionModifierWithLevel);
        }

        private void dexterityInputBox_TextChanged(object sender, EventArgs e) {
            UpdateModifiers(dexterityInputBox, dexterityModifier, dexterityModifierWithLevel);
        }

        private void intelligenceInputBox_TextChanged(object sender, EventArgs e) {
            UpdateModifiers(intelligenceInputBox, intelligenceModifier, intelligenceModifierWithLevel);
        }

        private void wisdomInputBox_TextChanged(object sender, EventArgs e) {
            UpdateModifiers(wisdomInputBox, wisdomModifier, wisdomModifierWithLevel);
        }

        private void charismaInputBox_TextChanged(object sender, EventArgs e) {
            UpdateModifiers(charismaInputBox, charismaModifier, charismaModifierWithLevel);
        }

        private void UpdateModifiers(TextBox textBox, Label modifier, Label modifierWithLevel) {
            AbilityStat abilityStat = new AbilityStat();
            int level = int.TryParse(characterLevel.Text, out int levelParse) ? levelParse : 0 ;
            string displayFormat = "+0;-0";
            if (uint.TryParse(textBox.Text, out uint value) )
            {
                modifier.Text = abilityStat
                    .CalculateModifier(value)
                    .ToString(displayFormat);
                modifierWithLevel.Text = abilityStat
                    .CalculateModifierWithLevel(value, level)
                    .ToString(displayFormat);
            }
        }

        private void characterLevel_TextChanged(object sender, EventArgs e) {
            UpdateModifiers(strengthInputBox, strengthModifier, strengthModifierWithLevel);
            UpdateModifiers(constitutionInputBox, constitutionModifier, constitutionModifierWithLevel);
            UpdateModifiers(dexterityInputBox, dexterityModifier, dexterityModifierWithLevel);
            UpdateModifiers(intelligenceInputBox, intelligenceModifier, intelligenceModifierWithLevel);
            UpdateModifiers(wisdomInputBox, wisdomModifier, wisdomModifierWithLevel);
            UpdateModifiers(charismaInputBox, charismaModifier, charismaModifierWithLevel);
        }

        private bool ValidateInput() {
            bool output = true;
            uint strengthValue = 0, constitutionValue = 0, dexterityValue = 0, wisdomValue = 0, intelligenceValue = 0, charismaValue = 0 ;

            List<TextBox> textBoxes = new List<TextBox> {
                strengthInputBox,
                constitutionInputBox,
                dexterityInputBox,
                wisdomInputBox,
                intelligenceInputBox,
                charismaInputBox
            };

            List<TextBox> textBoxesParsable = textBoxes
                .Where(x => uint.TryParse(x.Text, out uint parsable))
                .ToList();

            if ( textBoxes.Count != textBoxesParsable.Count ) {
                output = false;
            }

            List<uint> inputValues = new List<uint> {
                strengthValue,
                constitutionValue,
                dexterityValue,
                wisdomValue,
                intelligenceValue,
                charismaValue
            };

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
                output = false;
            }

            return output;
        }

        private void strengthModifier_Click(object sender, EventArgs e) {

        }
    }
}
