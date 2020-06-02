using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private bool ValidateInput() {
            bool output = true;
            uint strengthValue = 0;
            if (!uint.TryParse(strengthInputBox.Text, out strengthValue) ) {
                output = false;
            }
            if (strengthValue < 1) {
                output = false;
            }
            if(strengthInputBox.TextLength == 0) {
                output = false;
            }

            return output;
        }
    }
}
