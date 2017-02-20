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
    public partial class RaceForm : Form
    {
        
        public int[] abilityInteger;
        public int[] raceAbilities;
        public RaceForm()
        {
            InitializeComponent();
            


        }
        private void _getAbilitiesFromAbilityForm()
        {
            STRTextBox.Text = (abilityInteger[0]).ToString();
            DEXTextBox.Text = (abilityInteger[1]).ToString();
            ENDTextBox.Text = (abilityInteger[2]).ToString();
            INTTextBox.Text = (abilityInteger[3]).ToString();
            PERTextBox.Text = (abilityInteger[4]).ToString();
            CHATextBox.Text = (abilityInteger[5]).ToString();
        }
        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton raceOption = sender as RadioButton;
            _getAbilitiesFromAbilityForm();
            raceAbilities = (int[])abilityInteger.Clone();
            switch (raceOption.Tag.ToString())
            {
                case "Human":
                    Random random = new Random();
                    
                    for (int i = 0;i < 5; i++)
                    {
                        int randomNumber = random.Next(0, 6);
                        raceAbilities[randomNumber] = abilityInteger[randomNumber] + 1;
                    }
                    STRTextBox.Text = (raceAbilities[0]).ToString();
                    DEXTextBox.Text = (raceAbilities[1]).ToString();
                    ENDTextBox.Text = (raceAbilities[2]).ToString();
                    INTTextBox.Text = (raceAbilities[3]).ToString();
                    PERTextBox.Text = (raceAbilities[4]).ToString();
                    CHATextBox.Text = (raceAbilities[5]).ToString();
                    CharacterPictureBox.Image = global::COMP1004_W2017_MidTermAssgnment_200320739.Properties.Resources.M_Human1;
                    RacialBonusTextBox.Text = "+5 all of Abilities randomly";
                    break;
                case "Dwarf":
                    CharacterPictureBox.Image = global::COMP1004_W2017_MidTermAssgnment_200320739.Properties.Resources.M_Dwarf1;
                    raceAbilities[0] = abilityInteger[0] + 20;
                    raceAbilities[4] = abilityInteger[4] + 20;
                    raceAbilities[5] = abilityInteger[5] - 10;
                    STRTextBox.Text =  (raceAbilities[0]).ToString();
                    PERTextBox.Text = (raceAbilities[4]).ToString();
                    CHATextBox.Text = (raceAbilities[5]).ToString();
                    RacialBonusTextBox.Text = "+20 STR&PER by 20, -10 CHA";
                    break;
                case "Elf":
                    CharacterPictureBox.Image = global::COMP1004_W2017_MidTermAssgnment_200320739.Properties.Resources.M_Elf1;
                    raceAbilities[1] = abilityInteger[1] + 15;
                    raceAbilities[5] = abilityInteger[5] + 15;
                    DEXTextBox.Text = (raceAbilities[1]).ToString();
                    CHATextBox.Text = (raceAbilities[5]).ToString();
                    RacialBonusTextBox.Text = "+15 DEX&CHA";
                    break;
                case "Halfling":
                    CharacterPictureBox.Image = global::COMP1004_W2017_MidTermAssgnment_200320739.Properties.Resources.M_Halfling2;
                    raceAbilities[0] = abilityInteger[0] - 10;
                    raceAbilities[1] = abilityInteger[1] + 20;
                    raceAbilities[3] = abilityInteger[3] + 20;
                    STRTextBox.Text = (raceAbilities[0]).ToString();
                    DEXTextBox.Text = (raceAbilities[1]).ToString();
                    INTTextBox.Text = (raceAbilities[3]).ToString();
                    RacialBonusTextBox.Text = "+20 DEX&INT, -10 STR";
                    break;
            }
            CheckLimitOfAbilities(raceAbilities);

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            JobForm job = new JobForm();
            job.previousForm = this;
            job.Show();
            this.Hide();
        }

        private void CheckLimitOfAbilities(int[] abilites)
        {
            for (int i = 0; i < abilites.Length; i++)
            {
                if (abilites[i] < 3)
                {
                    abilites[i] = 3;
                }
                else if (abilites[i] > 50)
                {
                    abilites[i] = 50;
                }
            }
        }

        private void RaceForm_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
