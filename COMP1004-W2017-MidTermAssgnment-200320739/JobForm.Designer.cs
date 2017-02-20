namespace COMP1004_W2017_MidTermAssgnment_200320739
{
    partial class JobForm
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
            this.JobSelectGroupBox = new System.Windows.Forms.GroupBox();
            this.CultistRdioButton = new System.Windows.Forms.RadioButton();
            this.MagickerRadioButton = new System.Windows.Forms.RadioButton();
            this.RogueRadioButton = new System.Windows.Forms.RadioButton();
            this.SoldierRadioButton = new System.Windows.Forms.RadioButton();
            this.HealthPointLabel = new System.Windows.Forms.Label();
            this.HealthPointTextBox = new System.Windows.Forms.TextBox();
            this.JobSelectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(525, 465);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.ClickNextButton);
            // 
            // JobSelectGroupBox
            // 
            this.JobSelectGroupBox.Controls.Add(this.CultistRdioButton);
            this.JobSelectGroupBox.Controls.Add(this.MagickerRadioButton);
            this.JobSelectGroupBox.Controls.Add(this.RogueRadioButton);
            this.JobSelectGroupBox.Controls.Add(this.SoldierRadioButton);
            this.JobSelectGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.JobSelectGroupBox.Location = new System.Drawing.Point(12, 29);
            this.JobSelectGroupBox.Name = "JobSelectGroupBox";
            this.JobSelectGroupBox.Size = new System.Drawing.Size(200, 173);
            this.JobSelectGroupBox.TabIndex = 4;
            this.JobSelectGroupBox.TabStop = false;
            this.JobSelectGroupBox.Text = "Job Select";
            // 
            // CultistRdioButton
            // 
            this.CultistRdioButton.AutoSize = true;
            this.CultistRdioButton.Location = new System.Drawing.Point(7, 118);
            this.CultistRdioButton.Name = "CultistRdioButton";
            this.CultistRdioButton.Size = new System.Drawing.Size(104, 33);
            this.CultistRdioButton.TabIndex = 3;
            this.CultistRdioButton.TabStop = true;
            this.CultistRdioButton.Tag = "Cultist";
            this.CultistRdioButton.Text = "Cultist";
            this.CultistRdioButton.UseVisualStyleBackColor = true;
            this.CultistRdioButton.CheckedChanged += new System.EventHandler(this.CheckedChangedJobRadioButton);
            // 
            // MagickerRadioButton
            // 
            this.MagickerRadioButton.AutoSize = true;
            this.MagickerRadioButton.Location = new System.Drawing.Point(7, 88);
            this.MagickerRadioButton.Name = "MagickerRadioButton";
            this.MagickerRadioButton.Size = new System.Drawing.Size(137, 33);
            this.MagickerRadioButton.TabIndex = 2;
            this.MagickerRadioButton.TabStop = true;
            this.MagickerRadioButton.Tag = "Magicker";
            this.MagickerRadioButton.Text = "Magicker";
            this.MagickerRadioButton.UseVisualStyleBackColor = true;
            this.MagickerRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChangedJobRadioButton);
            // 
            // RogueRadioButton
            // 
            this.RogueRadioButton.AutoSize = true;
            this.RogueRadioButton.Location = new System.Drawing.Point(7, 57);
            this.RogueRadioButton.Name = "RogueRadioButton";
            this.RogueRadioButton.Size = new System.Drawing.Size(110, 33);
            this.RogueRadioButton.TabIndex = 1;
            this.RogueRadioButton.TabStop = true;
            this.RogueRadioButton.Tag = "Rogue";
            this.RogueRadioButton.Text = "Rogue";
            this.RogueRadioButton.UseVisualStyleBackColor = true;
            this.RogueRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChangedJobRadioButton);
            // 
            // SoldierRadioButton
            // 
            this.SoldierRadioButton.AutoSize = true;
            this.SoldierRadioButton.Location = new System.Drawing.Point(7, 26);
            this.SoldierRadioButton.Name = "SoldierRadioButton";
            this.SoldierRadioButton.Size = new System.Drawing.Size(116, 33);
            this.SoldierRadioButton.TabIndex = 0;
            this.SoldierRadioButton.TabStop = true;
            this.SoldierRadioButton.Tag = "Soldier";
            this.SoldierRadioButton.Text = "Soldier";
            this.SoldierRadioButton.UseVisualStyleBackColor = true;
            this.SoldierRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChangedJobRadioButton);
            // 
            // HealthPointLabel
            // 
            this.HealthPointLabel.AutoSize = true;
            this.HealthPointLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.HealthPointLabel.Location = new System.Drawing.Point(259, 39);
            this.HealthPointLabel.Name = "HealthPointLabel";
            this.HealthPointLabel.Size = new System.Drawing.Size(143, 29);
            this.HealthPointLabel.TabIndex = 5;
            this.HealthPointLabel.Text = "Health Point";
            // 
            // HealthPointTextBox
            // 
            this.HealthPointTextBox.BackColor = System.Drawing.Color.White;
            this.HealthPointTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthPointTextBox.Location = new System.Drawing.Point(264, 86);
            this.HealthPointTextBox.Name = "HealthPointTextBox";
            this.HealthPointTextBox.ReadOnly = true;
            this.HealthPointTextBox.Size = new System.Drawing.Size(100, 35);
            this.HealthPointTextBox.TabIndex = 6;
            // 
            // JobForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 508);
            this.Controls.Add(this.HealthPointTextBox);
            this.Controls.Add(this.HealthPointLabel);
            this.Controls.Add(this.JobSelectGroupBox);
            this.Controls.Add(this.NextButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "JobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select the Character\'s Job";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosingJobForm);
            this.JobSelectGroupBox.ResumeLayout(false);
            this.JobSelectGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.GroupBox JobSelectGroupBox;
        private System.Windows.Forms.RadioButton CultistRdioButton;
        private System.Windows.Forms.RadioButton MagickerRadioButton;
        private System.Windows.Forms.RadioButton RogueRadioButton;
        private System.Windows.Forms.RadioButton SoldierRadioButton;
        private System.Windows.Forms.Label HealthPointLabel;
        private System.Windows.Forms.TextBox HealthPointTextBox;
    }
}