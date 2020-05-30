namespace FormUI
{
    partial class CharacterManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.headerLabel = new System.Windows.Forms.Label();
            this.characterNameLabel = new System.Windows.Forms.Label();
            this.characterName = new System.Windows.Forms.Label();
            this.characterRace = new System.Windows.Forms.Label();
            this.characterRaceLabel = new System.Windows.Forms.Label();
            this.characterClass = new System.Windows.Forms.Label();
            this.characterClassLabel = new System.Windows.Forms.Label();
            this.characterLevel = new System.Windows.Forms.Label();
            this.characterLevelLabel = new System.Windows.Forms.Label();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.constitutionLabel = new System.Windows.Forms.Label();
            this.wisdomLabel = new System.Windows.Forms.Label();
            this.strengthInputBox = new System.Windows.Forms.TextBox();
            this.constitutionInputBox = new System.Windows.Forms.TextBox();
            this.dexterityInputBox = new System.Windows.Forms.TextBox();
            this.intelligenceInputBox = new System.Windows.Forms.TextBox();
            this.wisdomInputBox = new System.Windows.Forms.TextBox();
            this.charismaInputBox = new System.Windows.Forms.TextBox();
            this.charismaLabel = new System.Windows.Forms.Label();
            this.intelligenceLabel = new System.Windows.Forms.Label();
            this.dexterityLabel = new System.Windows.Forms.Label();
            this.modifiersLabel = new System.Windows.Forms.Label();
            this.modifiersWithLevelLabel = new System.Windows.Forms.Label();
            this.strengthModifier = new System.Windows.Forms.Label();
            this.strengthModifierWithLevel = new System.Windows.Forms.Label();
            this.constitutionModifierWithLevel = new System.Windows.Forms.Label();
            this.constitutionModifier = new System.Windows.Forms.Label();
            this.dexterityModifierWithLevel = new System.Windows.Forms.Label();
            this.dexterityModifier = new System.Windows.Forms.Label();
            this.intelligenceModifierWithLevel = new System.Windows.Forms.Label();
            this.intelligenceModifier = new System.Windows.Forms.Label();
            this.wisdomModifierWithLevel = new System.Windows.Forms.Label();
            this.wisdomModifier = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.Location = new System.Drawing.Point(13, 13);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(466, 50);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "13th Age Character Manager";
            this.headerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // characterNameLabel
            // 
            this.characterNameLabel.AutoSize = true;
            this.characterNameLabel.Location = new System.Drawing.Point(513, 13);
            this.characterNameLabel.Name = "characterNameLabel";
            this.characterNameLabel.Size = new System.Drawing.Size(107, 30);
            this.characterNameLabel.TabIndex = 1;
            this.characterNameLabel.Text = "Character:";
            this.characterNameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // characterName
            // 
            this.characterName.AutoSize = true;
            this.characterName.Location = new System.Drawing.Point(626, 13);
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(88, 30);
            this.characterName.TabIndex = 2;
            this.characterName.Text = "<none>";
            // 
            // characterRace
            // 
            this.characterRace.AutoSize = true;
            this.characterRace.Location = new System.Drawing.Point(945, 13);
            this.characterRace.Name = "characterRace";
            this.characterRace.Size = new System.Drawing.Size(88, 30);
            this.characterRace.TabIndex = 4;
            this.characterRace.Text = "<none>";
            this.characterRace.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // characterRaceLabel
            // 
            this.characterRaceLabel.AutoSize = true;
            this.characterRaceLabel.Location = new System.Drawing.Point(874, 13);
            this.characterRaceLabel.Name = "characterRaceLabel";
            this.characterRaceLabel.Size = new System.Drawing.Size(63, 30);
            this.characterRaceLabel.TabIndex = 3;
            this.characterRaceLabel.Text = "Race:";
            this.characterRaceLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // characterClass
            // 
            this.characterClass.AutoSize = true;
            this.characterClass.Location = new System.Drawing.Point(626, 56);
            this.characterClass.Name = "characterClass";
            this.characterClass.Size = new System.Drawing.Size(88, 30);
            this.characterClass.TabIndex = 6;
            this.characterClass.Text = "<none>";
            // 
            // characterClassLabel
            // 
            this.characterClassLabel.AutoSize = true;
            this.characterClassLabel.Location = new System.Drawing.Point(555, 56);
            this.characterClassLabel.Name = "characterClassLabel";
            this.characterClassLabel.Size = new System.Drawing.Size(65, 30);
            this.characterClassLabel.TabIndex = 5;
            this.characterClassLabel.Text = "Class:";
            // 
            // characterLevel
            // 
            this.characterLevel.AutoSize = true;
            this.characterLevel.Location = new System.Drawing.Point(945, 56);
            this.characterLevel.Name = "characterLevel";
            this.characterLevel.Size = new System.Drawing.Size(88, 30);
            this.characterLevel.TabIndex = 8;
            this.characterLevel.Text = "<none>";
            // 
            // characterLevelLabel
            // 
            this.characterLevelLabel.AutoSize = true;
            this.characterLevelLabel.Location = new System.Drawing.Point(874, 56);
            this.characterLevelLabel.Name = "characterLevelLabel";
            this.characterLevelLabel.Size = new System.Drawing.Size(65, 30);
            this.characterLevelLabel.TabIndex = 7;
            this.characterLevelLabel.Text = "Level:";
            // 
            // strengthLabel
            // 
            this.strengthLabel.AutoSize = true;
            this.strengthLabel.Location = new System.Drawing.Point(128, 115);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(48, 30);
            this.strengthLabel.TabIndex = 9;
            this.strengthLabel.Text = "STR";
            // 
            // constitutionLabel
            // 
            this.constitutionLabel.AutoSize = true;
            this.constitutionLabel.Location = new System.Drawing.Point(186, 114);
            this.constitutionLabel.Name = "constitutionLabel";
            this.constitutionLabel.Size = new System.Drawing.Size(57, 30);
            this.constitutionLabel.TabIndex = 10;
            this.constitutionLabel.Text = "CON";
            // 
            // wisdomLabel
            // 
            this.wisdomLabel.AutoSize = true;
            this.wisdomLabel.Location = new System.Drawing.Point(375, 114);
            this.wisdomLabel.Name = "wisdomLabel";
            this.wisdomLabel.Size = new System.Drawing.Size(50, 30);
            this.wisdomLabel.TabIndex = 11;
            this.wisdomLabel.Text = "WIS";
            // 
            // strengthInputBox
            // 
            this.strengthInputBox.Location = new System.Drawing.Point(131, 148);
            this.strengthInputBox.Name = "strengthInputBox";
            this.strengthInputBox.Size = new System.Drawing.Size(43, 35);
            this.strengthInputBox.TabIndex = 12;
            // 
            // constitutionInputBox
            // 
            this.constitutionInputBox.Location = new System.Drawing.Point(193, 148);
            this.constitutionInputBox.Name = "constitutionInputBox";
            this.constitutionInputBox.Size = new System.Drawing.Size(43, 35);
            this.constitutionInputBox.TabIndex = 13;
            // 
            // dexterityInputBox
            // 
            this.dexterityInputBox.Location = new System.Drawing.Point(255, 148);
            this.dexterityInputBox.Name = "dexterityInputBox";
            this.dexterityInputBox.Size = new System.Drawing.Size(43, 35);
            this.dexterityInputBox.TabIndex = 14;
            // 
            // intelligenceInputBox
            // 
            this.intelligenceInputBox.Location = new System.Drawing.Point(317, 148);
            this.intelligenceInputBox.Name = "intelligenceInputBox";
            this.intelligenceInputBox.Size = new System.Drawing.Size(43, 35);
            this.intelligenceInputBox.TabIndex = 15;
            // 
            // wisdomInputBox
            // 
            this.wisdomInputBox.Location = new System.Drawing.Point(379, 148);
            this.wisdomInputBox.Name = "wisdomInputBox";
            this.wisdomInputBox.Size = new System.Drawing.Size(43, 35);
            this.wisdomInputBox.TabIndex = 16;
            // 
            // charismaInputBox
            // 
            this.charismaInputBox.Location = new System.Drawing.Point(441, 148);
            this.charismaInputBox.Name = "charismaInputBox";
            this.charismaInputBox.Size = new System.Drawing.Size(43, 35);
            this.charismaInputBox.TabIndex = 17;
            // 
            // charismaLabel
            // 
            this.charismaLabel.AutoSize = true;
            this.charismaLabel.Location = new System.Drawing.Point(435, 114);
            this.charismaLabel.Name = "charismaLabel";
            this.charismaLabel.Size = new System.Drawing.Size(55, 30);
            this.charismaLabel.TabIndex = 18;
            this.charismaLabel.Text = "CHA";
            this.charismaLabel.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // intelligenceLabel
            // 
            this.intelligenceLabel.AutoSize = true;
            this.intelligenceLabel.Location = new System.Drawing.Point(315, 114);
            this.intelligenceLabel.Name = "intelligenceLabel";
            this.intelligenceLabel.Size = new System.Drawing.Size(46, 30);
            this.intelligenceLabel.TabIndex = 19;
            this.intelligenceLabel.Text = "INT";
            // 
            // dexterityLabel
            // 
            this.dexterityLabel.AutoSize = true;
            this.dexterityLabel.Location = new System.Drawing.Point(251, 114);
            this.dexterityLabel.Name = "dexterityLabel";
            this.dexterityLabel.Size = new System.Drawing.Size(51, 30);
            this.dexterityLabel.TabIndex = 20;
            this.dexterityLabel.Text = "DEX";
            // 
            // modifiersLabel
            // 
            this.modifiersLabel.AutoSize = true;
            this.modifiersLabel.Location = new System.Drawing.Point(63, 195);
            this.modifiersLabel.Name = "modifiersLabel";
            this.modifiersLabel.Size = new System.Drawing.Size(61, 30);
            this.modifiersLabel.TabIndex = 21;
            this.modifiersLabel.Text = "Mod:";
            this.modifiersLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // modifiersWithLevelLabel
            // 
            this.modifiersWithLevelLabel.AutoSize = true;
            this.modifiersWithLevelLabel.Location = new System.Drawing.Point(17, 237);
            this.modifiersWithLevelLabel.Name = "modifiersWithLevelLabel";
            this.modifiersWithLevelLabel.Size = new System.Drawing.Size(107, 30);
            this.modifiersWithLevelLabel.TabIndex = 22;
            this.modifiersWithLevelLabel.Text = "Mod + lvl:";
            // 
            // strengthModifier
            // 
            this.strengthModifier.AutoSize = true;
            this.strengthModifier.Location = new System.Drawing.Point(126, 195);
            this.strengthModifier.Name = "strengthModifier";
            this.strengthModifier.Size = new System.Drawing.Size(52, 30);
            this.strengthModifier.TabIndex = 23;
            this.strengthModifier.Text = "<0>";
            // 
            // strengthModifierWithLevel
            // 
            this.strengthModifierWithLevel.AutoSize = true;
            this.strengthModifierWithLevel.Location = new System.Drawing.Point(126, 237);
            this.strengthModifierWithLevel.Name = "strengthModifierWithLevel";
            this.strengthModifierWithLevel.Size = new System.Drawing.Size(52, 30);
            this.strengthModifierWithLevel.TabIndex = 24;
            this.strengthModifierWithLevel.Text = "<0>";
            this.strengthModifierWithLevel.Click += new System.EventHandler(this.label5_Click);
            // 
            // constitutionModifierWithLevel
            // 
            this.constitutionModifierWithLevel.AutoSize = true;
            this.constitutionModifierWithLevel.Location = new System.Drawing.Point(188, 237);
            this.constitutionModifierWithLevel.Name = "constitutionModifierWithLevel";
            this.constitutionModifierWithLevel.Size = new System.Drawing.Size(52, 30);
            this.constitutionModifierWithLevel.TabIndex = 26;
            this.constitutionModifierWithLevel.Text = "<0>";
            // 
            // constitutionModifier
            // 
            this.constitutionModifier.AutoSize = true;
            this.constitutionModifier.Location = new System.Drawing.Point(188, 195);
            this.constitutionModifier.Name = "constitutionModifier";
            this.constitutionModifier.Size = new System.Drawing.Size(52, 30);
            this.constitutionModifier.TabIndex = 25;
            this.constitutionModifier.Text = "<0>";
            // 
            // dexterityModifierWithLevel
            // 
            this.dexterityModifierWithLevel.AutoSize = true;
            this.dexterityModifierWithLevel.Location = new System.Drawing.Point(250, 237);
            this.dexterityModifierWithLevel.Name = "dexterityModifierWithLevel";
            this.dexterityModifierWithLevel.Size = new System.Drawing.Size(52, 30);
            this.dexterityModifierWithLevel.TabIndex = 28;
            this.dexterityModifierWithLevel.Text = "<0>";
            // 
            // dexterityModifier
            // 
            this.dexterityModifier.AutoSize = true;
            this.dexterityModifier.Location = new System.Drawing.Point(250, 195);
            this.dexterityModifier.Name = "dexterityModifier";
            this.dexterityModifier.Size = new System.Drawing.Size(52, 30);
            this.dexterityModifier.TabIndex = 27;
            this.dexterityModifier.Text = "<0>";
            // 
            // intelligenceModifierWithLevel
            // 
            this.intelligenceModifierWithLevel.AutoSize = true;
            this.intelligenceModifierWithLevel.Location = new System.Drawing.Point(312, 237);
            this.intelligenceModifierWithLevel.Name = "intelligenceModifierWithLevel";
            this.intelligenceModifierWithLevel.Size = new System.Drawing.Size(52, 30);
            this.intelligenceModifierWithLevel.TabIndex = 30;
            this.intelligenceModifierWithLevel.Text = "<0>";
            // 
            // intelligenceModifier
            // 
            this.intelligenceModifier.AutoSize = true;
            this.intelligenceModifier.Location = new System.Drawing.Point(312, 195);
            this.intelligenceModifier.Name = "intelligenceModifier";
            this.intelligenceModifier.Size = new System.Drawing.Size(52, 30);
            this.intelligenceModifier.TabIndex = 29;
            this.intelligenceModifier.Text = "<0>";
            // 
            // wisdomModifierWithLevel
            // 
            this.wisdomModifierWithLevel.AutoSize = true;
            this.wisdomModifierWithLevel.Location = new System.Drawing.Point(374, 237);
            this.wisdomModifierWithLevel.Name = "wisdomModifierWithLevel";
            this.wisdomModifierWithLevel.Size = new System.Drawing.Size(52, 30);
            this.wisdomModifierWithLevel.TabIndex = 32;
            this.wisdomModifierWithLevel.Text = "<0>";
            // 
            // wisdomModifier
            // 
            this.wisdomModifier.AutoSize = true;
            this.wisdomModifier.Location = new System.Drawing.Point(374, 195);
            this.wisdomModifier.Name = "wisdomModifier";
            this.wisdomModifier.Size = new System.Drawing.Size(52, 30);
            this.wisdomModifier.TabIndex = 31;
            this.wisdomModifier.Text = "<0>";
            this.wisdomModifier.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 30);
            this.label1.TabIndex = 34;
            this.label1.Text = "<0>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "<0>";
            // 
            // CharacterManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1240, 735);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wisdomModifierWithLevel);
            this.Controls.Add(this.wisdomModifier);
            this.Controls.Add(this.intelligenceModifierWithLevel);
            this.Controls.Add(this.intelligenceModifier);
            this.Controls.Add(this.dexterityModifierWithLevel);
            this.Controls.Add(this.dexterityModifier);
            this.Controls.Add(this.constitutionModifierWithLevel);
            this.Controls.Add(this.constitutionModifier);
            this.Controls.Add(this.strengthModifierWithLevel);
            this.Controls.Add(this.strengthModifier);
            this.Controls.Add(this.modifiersWithLevelLabel);
            this.Controls.Add(this.modifiersLabel);
            this.Controls.Add(this.dexterityLabel);
            this.Controls.Add(this.intelligenceLabel);
            this.Controls.Add(this.charismaLabel);
            this.Controls.Add(this.charismaInputBox);
            this.Controls.Add(this.wisdomInputBox);
            this.Controls.Add(this.intelligenceInputBox);
            this.Controls.Add(this.dexterityInputBox);
            this.Controls.Add(this.constitutionInputBox);
            this.Controls.Add(this.strengthInputBox);
            this.Controls.Add(this.wisdomLabel);
            this.Controls.Add(this.constitutionLabel);
            this.Controls.Add(this.strengthLabel);
            this.Controls.Add(this.characterLevel);
            this.Controls.Add(this.characterLevelLabel);
            this.Controls.Add(this.characterClass);
            this.Controls.Add(this.characterClassLabel);
            this.Controls.Add(this.characterRace);
            this.Controls.Add(this.characterRaceLabel);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.characterNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CharacterManagerForm";
            this.Text = "Character Manager";
            this.Load += new System.EventHandler(this.CharacterManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label characterNameLabel;
        private System.Windows.Forms.Label characterName;
        private System.Windows.Forms.Label characterRace;
        private System.Windows.Forms.Label characterRaceLabel;
        private System.Windows.Forms.Label characterClass;
        private System.Windows.Forms.Label characterClassLabel;
        private System.Windows.Forms.Label characterLevel;
        private System.Windows.Forms.Label characterLevelLabel;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Label constitutionLabel;
        private System.Windows.Forms.Label wisdomLabel;
        private System.Windows.Forms.TextBox strengthInputBox;
        private System.Windows.Forms.TextBox constitutionInputBox;
        private System.Windows.Forms.TextBox dexterityInputBox;
        private System.Windows.Forms.TextBox intelligenceInputBox;
        private System.Windows.Forms.TextBox wisdomInputBox;
        private System.Windows.Forms.TextBox charismaInputBox;
        private System.Windows.Forms.Label charismaLabel;
        private System.Windows.Forms.Label intelligenceLabel;
        private System.Windows.Forms.Label dexterityLabel;
        private System.Windows.Forms.Label modifiersLabel;
        private System.Windows.Forms.Label modifiersWithLevelLabel;
        private System.Windows.Forms.Label strengthModifier;
        private System.Windows.Forms.Label strengthModifierWithLevel;
        private System.Windows.Forms.Label constitutionModifierWithLevel;
        private System.Windows.Forms.Label constitutionModifier;
        private System.Windows.Forms.Label dexterityModifierWithLevel;
        private System.Windows.Forms.Label dexterityModifier;
        private System.Windows.Forms.Label intelligenceModifierWithLevel;
        private System.Windows.Forms.Label intelligenceModifier;
        private System.Windows.Forms.Label wisdomModifierWithLevel;
        private System.Windows.Forms.Label wisdomModifier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}