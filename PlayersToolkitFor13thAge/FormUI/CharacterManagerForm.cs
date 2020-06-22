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

        string defaultDisplayValue = "<0>";

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

        private void characterLevel_TextChanged(object sender, EventArgs e) {
            UpdateModifiers(strengthInputBox, strengthModifier, strengthModifierWithLevel);
            UpdateModifiers(constitutionInputBox, constitutionModifier, constitutionModifierWithLevel);
            UpdateModifiers(dexterityInputBox, dexterityModifier, dexterityModifierWithLevel);
            UpdateModifiers(intelligenceInputBox, intelligenceModifier, intelligenceModifierWithLevel);
            UpdateModifiers(wisdomInputBox, wisdomModifier, wisdomModifierWithLevel);
            UpdateModifiers(charismaInputBox, charismaModifier, charismaModifierWithLevel);
        }

        private void UpdateModifiers(TextBox textBox, Label modifier, Label modifierWithLevel) {
            AbilityStat abilityStat = new AbilityStat();

            string displayFormat = "+0;-0";

            uint characterLevel = uint.TryParse(characterLevelInputBox.Text, out characterLevel) ? characterLevel : 0 ;

            if ( uint.TryParse(textBox.Text, out uint value) )
            {
                modifier.Text = abilityStat.CalculateModifier(value).ToString(displayFormat);
                modifierWithLevel.Text = abilityStat.CalculateModifierWithLevel(value, characterLevel).ToString(displayFormat);
            }
            else
            {
                modifier.Text = defaultDisplayValue;
                modifierWithLevel.Text = defaultDisplayValue;
            }

            UpdateCombatStats();
            UpdateHitPoints();
        }

        private void UpdateCombatStats() {
            CombatStat combatStat = new CombatStat();

            uint characterLevel = uint.TryParse(characterLevelInputBox.Text, out characterLevel) ? characterLevel : 0 ;

            bool strengthValueValid = uint.TryParse(strengthInputBox.Text, out uint strengthValue);
            bool constitutionValueValid = uint.TryParse(constitutionInputBox.Text, out uint constitutionValue);
            bool dexterityValueValid = uint.TryParse(dexterityInputBox.Text, out uint dexterityValue);
            bool intelligenceValueValid = uint.TryParse(intelligenceInputBox.Text, out uint intelligenceValue);
            bool wisdomValueValid = uint.TryParse(wisdomInputBox.Text, out uint wisdomValue);
            bool charismaValueValid = uint.TryParse(charismaInputBox.Text, out uint charismaValue);

            armorClass.Text = ( constitutionValueValid || dexterityValueValid || wisdomValueValid ) ? 
                combatStat.CalculateArmorClass(constitutionValue, dexterityValue, wisdomValue, characterLevel).ToString() : defaultDisplayValue ;

            physicalDefense.Text = ( strengthValueValid || constitutionValueValid || dexterityValueValid ) ? 
                combatStat.CalculatePhysicalDefense(strengthValue, constitutionValue, dexterityValue, characterLevel).ToString() : defaultDisplayValue ;
            
            mentalDefense.Text = ( intelligenceValueValid || wisdomValueValid || charismaValueValid ) ?
                combatStat.CalculateMentalDefense(intelligenceValue, wisdomValue, charismaValue, characterLevel).ToString() : defaultDisplayValue ;
        }

        private void UpdateHitPoints() {
            bool characterLevelValid = uint.TryParse(characterLevelInputBox.Text, out uint characterLevel);
            bool constitutionValueValid = uint.TryParse(constitutionInputBox.Text, out uint constitutionValue);

            hitPoints.Text = (characterLevelValid || constitutionValueValid) ?
                m.CalculateHitPoints(constitutionValue, characterLevel).ToString() : defaultDisplayValue ;
        }

        private bool ValidateInput() {
            bool inputIsValid = true;

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

            if ( textBoxes.Count != textBoxesParsable.Count ) 
            {
                inputIsValid = false;
            }

            foreach ( var textBox in textBoxes )
            {
                if ( textBox.TextLength == 0 )
                {
                    inputIsValid = false;
                }
            }

            uint strengthValue = uint.TryParse(strengthInputBox.Text, out strengthValue) ? strengthValue : 0 ;
            uint constitutionValue = uint.TryParse(constitutionInputBox.Text, out constitutionValue) ? constitutionValue : 0 ;
            uint dexterityValue = uint.TryParse(dexterityInputBox.Text, out dexterityValue) ? dexterityValue : 0 ;
            uint wisdomValue = uint.TryParse(wisdomInputBox.Text, out wisdomValue) ? wisdomValue : 0 ;
            uint intelligenceValue = uint.TryParse(intelligenceInputBox.Text, out intelligenceValue) ? intelligenceValue : 0 ;
            uint charismaValue = uint.TryParse(charismaInputBox.Text, out charismaValue) ? charismaValue : 0 ;

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
                    inputIsValid = false;
                }
            }
            
            if ( characterName.TextLength == 0 || characterClass.TextLength == 0 || characterRace.TextLength == 0 || characterLevelInputBox.TextLength == 0 ) {
                inputIsValid = false;
            }

            return inputIsValid;
        }
    }
}
