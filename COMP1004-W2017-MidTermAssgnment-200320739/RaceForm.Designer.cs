namespace COMP1004_W2017_MidTermAssgnment_200320739
{
    partial class RaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
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
        private void InitializeComponent()
        {
            this.NextButton = new System.Windows.Forms.Button();
            this.RacialBonusLabel = new System.Windows.Forms.Label();
            this.RacialBonusTextBox = new System.Windows.Forms.TextBox();
            this.RaceSelectGroupBox = new System.Windows.Forms.GroupBox();
            this.HalflingRadioButton = new System.Windows.Forms.RadioButton();
            this.ElfRadioButton = new System.Windows.Forms.RadioButton();
            this.DwarfRadioButton = new System.Windows.Forms.RadioButton();
            this.HumanRadioButton = new System.Windows.Forms.RadioButton();
            this.CharacterPictureBox = new System.Windows.Forms.PictureBox();
            this.RaceSelectGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(525, 465);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.ClickNextButton);
            // 
            // RacialBonusLabel
            // 
            this.RacialBonusLabel.AutoSize = true;
            this.RacialBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RacialBonusLabel.Location = new System.Drawing.Point(236, 366);
            this.RacialBonusLabel.Name = "RacialBonusLabel";
            this.RacialBonusLabel.Size = new System.Drawing.Size(166, 29);
            this.RacialBonusLabel.TabIndex = 6;
            this.RacialBonusLabel.Text = "Racial Bonus";
            // 
            // RacialBonusTextBox
            // 
            this.RacialBonusTextBox.BackColor = System.Drawing.Color.White;
            this.RacialBonusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RacialBonusTextBox.Location = new System.Drawing.Point(242, 400);
            this.RacialBonusTextBox.Name = "RacialBonusTextBox";
            this.RacialBonusTextBox.ReadOnly = true;
            this.RacialBonusTextBox.Size = new System.Drawing.Size(287, 39);
            this.RacialBonusTextBox.TabIndex = 7;
            // 
            // RaceSelectGroupBox
            // 
            this.RaceSelectGroupBox.Controls.Add(this.HalflingRadioButton);
            this.RaceSelectGroupBox.Controls.Add(this.ElfRadioButton);
            this.RaceSelectGroupBox.Controls.Add(this.DwarfRadioButton);
            this.RaceSelectGroupBox.Controls.Add(this.HumanRadioButton);
            this.RaceSelectGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceSelectGroupBox.Location = new System.Drawing.Point(12, 84);
            this.RaceSelectGroupBox.Name = "RaceSelectGroupBox";
            this.RaceSelectGroupBox.Size = new System.Drawing.Size(200, 151);
            this.RaceSelectGroupBox.TabIndex = 8;
            this.RaceSelectGroupBox.TabStop = false;
            this.RaceSelectGroupBox.Text = "Race Select";
            // 
            // HalflingRadioButton
            // 
            this.HalflingRadioButton.AutoSize = true;
            this.HalflingRadioButton.Location = new System.Drawing.Point(7, 118);
            this.HalflingRadioButton.Name = "HalflingRadioButton";
            this.HalflingRadioButton.Size = new System.Drawing.Size(119, 33);
            this.HalflingRadioButton.TabIndex = 3;
            this.HalflingRadioButton.Tag = "Halfling";
            this.HalflingRadioButton.Text = "Halfling";
            this.HalflingRadioButton.UseVisualStyleBackColor = true;
            this.HalflingRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChangedRaceRadioButton);
            // 
            // ElfRadioButton
            // 
            this.ElfRadioButton.AutoSize = true;
            this.ElfRadioButton.Location = new System.Drawing.Point(7, 88);
            this.ElfRadioButton.Name = "ElfRadioButton";
            this.ElfRadioButton.Size = new System.Drawing.Size(66, 33);
            this.ElfRadioButton.TabIndex = 2;
            this.ElfRadioButton.Tag = "Elf";
            this.ElfRadioButton.Text = "Elf";
            this.ElfRadioButton.UseVisualStyleBackColor = true;
            this.ElfRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChangedRaceRadioButton);
            // 
            // DwarfRadioButton
            // 
            this.DwarfRadioButton.AutoSize = true;
            this.DwarfRadioButton.Location = new System.Drawing.Point(7, 57);
            this.DwarfRadioButton.Name = "DwarfRadioButton";
            this.DwarfRadioButton.Size = new System.Drawing.Size(100, 33);
            this.DwarfRadioButton.TabIndex = 1;
            this.DwarfRadioButton.Tag = "Dwarf";
            this.DwarfRadioButton.Text = "Dwarf";
            this.DwarfRadioButton.UseVisualStyleBackColor = true;
            this.DwarfRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChangedRaceRadioButton);
            // 
            // HumanRadioButton
            // 
            this.HumanRadioButton.AutoSize = true;
            this.HumanRadioButton.Location = new System.Drawing.Point(7, 26);
            this.HumanRadioButton.Name = "HumanRadioButton";
            this.HumanRadioButton.Size = new System.Drawing.Size(114, 33);
            this.HumanRadioButton.TabIndex = 0;
            this.HumanRadioButton.Tag = "Human";
            this.HumanRadioButton.Text = "Human";
            this.HumanRadioButton.UseVisualStyleBackColor = true;
            this.HumanRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChangedRaceRadioButton);
            // 
            // CharacterPictureBox
            // 
            this.CharacterPictureBox.Location = new System.Drawing.Point(242, 84);
            this.CharacterPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.CharacterPictureBox.Name = "CharacterPictureBox";
            this.CharacterPictureBox.Size = new System.Drawing.Size(290, 262);
            this.CharacterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CharacterPictureBox.TabIndex = 5;
            this.CharacterPictureBox.TabStop = false;
            // 
            // RaceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.RaceSelectGroupBox);
            this.Controls.Add(this.RacialBonusTextBox);
            this.Controls.Add(this.RacialBonusLabel);
            this.Controls.Add(this.CharacterPictureBox);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Character Race";
            this.RaceSelectGroupBox.ResumeLayout(false);
            this.RaceSelectGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox CharacterPictureBox;
        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Label RacialBonusLabel;
        private System.Windows.Forms.TextBox RacialBonusTextBox;
        private System.Windows.Forms.GroupBox RaceSelectGroupBox;
        private System.Windows.Forms.RadioButton HalflingRadioButton;
        private System.Windows.Forms.RadioButton ElfRadioButton;
        private System.Windows.Forms.RadioButton DwarfRadioButton;
        private System.Windows.Forms.RadioButton HumanRadioButton;
    }
}