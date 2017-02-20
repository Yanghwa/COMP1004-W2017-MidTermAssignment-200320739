//FileName:FinalForm.cs
//FileType: Visual C# Source file
//Author: Junghwan Yang
//Student ID: 200320739
//Created On: 20/02/2017
//Copy Rights: Junghwan Yang
//Description: This form shows all information of character and print, font change, shows about page
//            

/////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_200320739
{
    public partial class FinalForm : Form
    {
        public JobForm previousForm;
        public FinalForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FinalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("If you want to close, push OK button.", "Warning",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FinalFormFontDialog.ShowDialog() == DialogResult.OK)
            {
                NameLabel.Font = NameTextBox.Font = WeightLabel.Font = WeightTextBox.Font = AgeLabel.Font = AgeTextBox.Font = HealthPointsLabel.Font = HealthPointsTextBox.Font = HeightLabel.Font = HeightTextBox.Font = JobLabel.Font = JobTextBox.Font = RaceLabel.Font = RaceTextBox.Font = STRLabel.Font = STRTextBox.Font = DEXLabel.Font = DEXTextBox.Font = ENDLabel.Font = ENDTextBox.Font = INTLabel.Font = INTTextBox.Font = PERLabel.Font = PERTextBox.Font = CHALabel.Font = CHATextBox.Font = FinalFormFontDialog.Font;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBoxForm aboutForm = new AboutBoxForm();
            aboutForm.ShowDialog();
        }

        public void InitializeFinalForm()
        {
            JobTextBox.Text = previousForm.Job;
            HealthPointsTextBox.Text = previousForm.HealthPoint.ToString();
            RaceTextBox.Text = previousForm.previousForm.Race;
            CharacterPictureBox.Image = previousForm.previousForm.CharacterPictureBox.Image;
            STRTextBox.Text = previousForm.previousForm.RaceAbilities[0].ToString();
            DEXTextBox.Text = previousForm.previousForm.RaceAbilities[1].ToString();
            ENDTextBox.Text = previousForm.previousForm.RaceAbilities[2].ToString();
            INTTextBox.Text = previousForm.previousForm.RaceAbilities[3].ToString();
            PERTextBox.Text = previousForm.previousForm.RaceAbilities[4].ToString();
            CHATextBox.Text = previousForm.previousForm.RaceAbilities[5].ToString();
            

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Name: "+ NameTextBox.Text + "\nAge: " 
                + AgeTextBox.Text + "\nHeight: " + HeightTextBox.Text 
                + "\nWeight: " + WeightTextBox.Text + "\nJob: " 
                + JobTextBox.Text + "\nRace: " + RaceTextBox.Text 
                + "\nHealth Points: " + HealthPointsTextBox.Text + "\nSTR: " 
                + STRTextBox.Text + "\nDEX: " + DEXTextBox.Text 
                + "\nEND: " + ENDTextBox.Text + "\nINT: " + INTTextBox.Text
                + "\nPER: " + PERTextBox.Text + "\nCHA: " + CHATextBox.Text, "All Information");
        }
    }
}
