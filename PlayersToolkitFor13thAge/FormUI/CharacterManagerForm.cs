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
        CharacterModel m = new CharacterModel();

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
                    characterLevelInputBox.Text,
                    strengthInputBox.Text,
                    constitutionInputBox.Text,
                    dexterityInputBox.Text,
                    intelligenceInputBox.Text,
                    wisdomInputBox.Text,
                    charismaInputBox.Text);

                foreach ( IDataConnection connection in GlobalConfig.Connections )
                {
                    connection.SaveCharacter(model);
                }
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

            uint level = m.ParsedUint(characterLevelInputBox.Text) ;
            string displayFormat = "+0;-0";
            if ( uint.TryParse(textBox.Text, out uint value) )
            {
                modifier.Text = abilityStat
                    .CalculateModifier(value)
                    .ToString(displayFormat);
                modifierWithLevel.Text = abilityStat
                    .CalculateModifierWithLevel(value, level)
                    .ToString(displayFormat);
            }

            UpdateCombatStats();
        }

        private void UpdateCombatStats() {
            CombatStat combatStat = new CombatStat();

            uint characterLevel = uint.TryParse(characterLevelInputBox.Text, out characterLevel) ? characterLevel : 0 ;

            uint strengthValue = uint.TryParse(strengthInputBox.Text, out strengthValue) ? strengthValue : 0 ;
            uint constitutionValue = uint.TryParse(constitutionInputBox.Text, out constitutionValue) ? constitutionValue : 0 ;
            uint dexterityValue = uint.TryParse(dexterityInputBox.Text, out dexterityValue) ? dexterityValue : 0;
            uint intelligenceValue = uint.TryParse(intelligenceInputBox.Text, out intelligenceValue) ? intelligenceValue : 0 ;
            uint wisdomValue = uint.TryParse(wisdomInputBox.Text, out wisdomValue) ? wisdomValue : 0 ;
            uint charismaValue = uint.TryParse(charismaInputBox.Text, out charismaValue) ? charismaValue : 0 ;

            armorClass.Text = combatStat.CalculateArmorClass(constitutionValue, dexterityValue, wisdomValue, characterLevel).ToString();
            physicalDefense.Text = combatStat.CalculatePhysicalDefense(strengthValue, constitutionValue, dexterityValue, characterLevel).ToString();
            mentalDefense.Text = combatStat.CalculateMentalDefense(intelligenceValue, wisdomValue, charismaValue, characterLevel).ToString();
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

            List<TextBox> textBoxes = new List<TextBox> {
                strengthInputBox,
                constitutionInputBox,
                dexterityInputBox,
                wisdomInputBox,
                intelligenceInputBox,
                charismaInputBox
            };

            List<TextBox> textBoxesParsable = textBoxes
                .Where(x => uint.TryParse(x.Text, out uint parsedValue))
                .ToList();

            if ( textBoxes.Count != textBoxesParsable.Count ) {
                output = false;
            }

            foreach ( var textBox in textBoxes )
            {
                if ( textBox.TextLength == 0 )
                {
                    output = false;
                }
            }

            uint strengthValue = m.ParsedUint(strengthInputBox.Text),
                constitutionValue = m.ParsedUint(constitutionInputBox.Text),
                dexterityValue = m.ParsedUint(dexterityInputBox.Text),
                wisdomValue = m.ParsedUint(wisdomInputBox.Text),
                intelligenceValue = m.ParsedUint(intelligenceInputBox.Text),
                charismaValue = m.ParsedUint(charismaInputBox.Text);

            List<uint> inputValues = new List<uint> {
                strengthValue,
                constitutionValue,
                dexterityValue,
                wisdomValue,
                intelligenceValue,
                charismaValue
            };

            foreach ( var inputValue in inputValues )
            {
                if ( inputValue < 1 )
                {
                    output = false;
                }
            }
            
            if ( characterName.TextLength == 0 || characterClass.TextLength == 0 || characterRace.TextLength == 0 || characterLevelInputBox.TextLength == 0 ) {
                output = false;
            }

            return output;
        }
    }
}
