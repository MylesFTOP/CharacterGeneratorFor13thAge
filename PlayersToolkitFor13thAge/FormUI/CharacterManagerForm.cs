using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ToolkitLibrary;

namespace FormUI
{
    public partial class CharacterManagerForm : Form
    {
        CharacterModel model = Factory.CreateCharacterModel();
        AbilityStat abilityStat = Factory.CreateAbilityStat();
        CombatStat combatStat = Factory.CreateCombatStat();

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
                    charismaInputBox.Text,
                    hitPoints.Text);

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

            string displayFormat = "+0;-0";
            // TODO: Extract this duplicate code for input box parsing
            bool characterLevelValid = InputHandler.ParseUint(characterLevelInputBox.Text, out uint characterLevel);

            if ( InputHandler.ParseUint(textBox.Text, out uint value) )
            {
                modifier.Text = abilityStat
                    .CalculateModifier(value)
                    .ToString(displayFormat);

                modifierWithLevel.Text = abilityStat
                    .CalculateModifierWithLevel(value, characterLevel)
                    .ToString(displayFormat);
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
            // TODO: Extract this duplicate code for input box parsing
            bool characterLevelValid = InputHandler.ParseUint(characterLevelInputBox.Text, out uint characterLevel);

            bool strengthValueValid = InputHandler.ParseUint(strengthInputBox.Text, out uint strengthValue);
            bool constitutionValueValid = InputHandler.ParseUint(constitutionInputBox.Text, out uint constitutionValue);
            bool dexterityValueValid = InputHandler.ParseUint(dexterityInputBox.Text, out uint dexterityValue);
            bool intelligenceValueValid = InputHandler.ParseUint(intelligenceInputBox.Text, out uint intelligenceValue);
            bool wisdomValueValid = InputHandler.ParseUint(wisdomInputBox.Text, out uint wisdomValue);
            bool charismaValueValid = InputHandler.ParseUint(charismaInputBox.Text, out uint charismaValue);

            armorClass.Text = ( constitutionValueValid || dexterityValueValid || wisdomValueValid || characterLevelValid ) ? 
                combatStat.CalculateArmorClass(constitutionValue, dexterityValue, wisdomValue, characterLevel).ToString() : defaultDisplayValue ;

            physicalDefense.Text = ( strengthValueValid || constitutionValueValid || dexterityValueValid || characterLevelValid ) ? 
                combatStat.CalculatePhysicalDefense(strengthValue, constitutionValue, dexterityValue, characterLevel).ToString() : defaultDisplayValue ;
            
            mentalDefense.Text = ( intelligenceValueValid || wisdomValueValid || charismaValueValid || characterLevelValid ) ?
                combatStat.CalculateMentalDefense(intelligenceValue, wisdomValue, charismaValue, characterLevel).ToString() : defaultDisplayValue ;
        }

        private void UpdateHitPoints() {
            bool characterLevelValid = InputHandler.ParseUint(characterLevelInputBox.Text, out uint characterLevel);
            bool constitutionValueValid = InputHandler.ParseUint(constitutionInputBox.Text, out uint constitutionValue);

            hitPoints.Text = (characterLevelValid || constitutionValueValid) ?
                model.CalculateHitPoints(constitutionValue, (int)characterLevel).ToString() : defaultDisplayValue ;
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
                .Where(x => InputHandler.ParseUint(x.Text, out uint parsedValue))
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

            // TODO: Extract this duplicate code for input box parsing
            bool strengthValueValid = InputHandler.ParseUint(strengthInputBox.Text, out uint strengthValue);
            bool constitutionValueValid = InputHandler.ParseUint(constitutionInputBox.Text, out uint constitutionValue);
            bool dexterityValueValid = InputHandler.ParseUint(dexterityInputBox.Text, out uint dexterityValue);
            bool intelligenceValueValid = InputHandler.ParseUint(intelligenceInputBox.Text, out uint intelligenceValue);
            bool wisdomValueValid = InputHandler.ParseUint(wisdomInputBox.Text, out uint wisdomValue);
            bool charismaValueValid = InputHandler.ParseUint(charismaInputBox.Text, out uint charismaValue);

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
