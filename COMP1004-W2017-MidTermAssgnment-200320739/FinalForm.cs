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
        //Classes-----------------------
        public JobForm previousForm;
        //CONSTRUCTOR---------------
        public FinalForm()
        {
            InitializeComponent();
        }
        //Event Handlers ---------------------------------
        /// <summary>
        /// this method makes exit button on the menu can exit the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickExitToolStripMenuItem(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        /// <summary>
        /// this method shows font change box when users click the font on the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickFontToolStripMenuItem(object sender, EventArgs e)
        {
            if (FinalFormFontDialog.ShowDialog() == DialogResult.OK)
            {
                NameLabel.Font = NameTextBox.Font = WeightLabel.Font = WeightTextBox.Font = AgeLabel.Font = AgeTextBox.Font = HealthPointsLabel.Font = HealthPointsTextBox.Font = HeightLabel.Font = HeightTextBox.Font = JobLabel.Font = JobTextBox.Font = RaceLabel.Font = RaceTextBox.Font = STRLabel.Font = STRTextBox.Font = DEXLabel.Font = DEXTextBox.Font = ENDLabel.Font = ENDTextBox.Font = INTLabel.Font = INTTextBox.Font = PERLabel.Font = PERTextBox.Font = CHALabel.Font = CHATextBox.Font = FinalFormFontDialog.Font;
            }
        }
        /// <summary>
        /// this method shows aboutbox inlcuing author information when users click about on the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickAboutToolStripMenuItem(object sender, EventArgs e)
        {
            AboutBoxForm aboutForm = new AboutBoxForm();
            aboutForm.ShowDialog();
        }
        
        /// <summary>
        /// this method shows all information using final form information, when users click the print on the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickPrintToolStripMenuItem(object sender, EventArgs e)
        {
            if(CheckEmptyValue(NameTextBox.Text) && CheckEmptyValue(AgeTextBox.Text) && CheckEmptyValue(HeightTextBox.Text) && CheckEmptyValue(WeightTextBox.Text))
            {
                MessageBox.Show("Name: " + NameTextBox.Text + "\nAge: "
                + AgeTextBox.Text + "\nHeight: " + HeightTextBox.Text
                + "\nWeight: " + WeightTextBox.Text + "\nJob: "
                + JobTextBox.Text + "\nRace: " + RaceTextBox.Text
                + "\nHealth Points: " + HealthPointsTextBox.Text + "\nSTR: "
                + STRTextBox.Text + "\nDEX: " + DEXTextBox.Text
                + "\nEND: " + ENDTextBox.Text + "\nINT: " + INTTextBox.Text
                + "\nPER: " + PERTextBox.Text + "\nCHA: " + CHATextBox.Text, "All Information");
            }
            else
            {
                MessageBox.Show("You're missing one of these values: Name, Age, Weight, Height","Missing somthing!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
         /// <summary>
        /// this method shows the warning message when users want to close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormClosingFinalForm(object sender, FormClosingEventArgs e)
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
        /// <summary>
        /// this method allows only number(no decimal) on the age, height, weight text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateOnlyNumber(object sender, KeyPressEventArgs e)
        {
            //only number and "." allowed
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back ))
            {
                e.Handled = true;
            }
        }
        //functions---------------------------
        /// <summary>
        /// this method shows all information to the final form, using previous forms
        /// </summary>
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

        /// <summary>
        /// this method check if string is empty
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private bool CheckEmptyValue(string text)
        {
            if(string.IsNullOrWhiteSpace(text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
