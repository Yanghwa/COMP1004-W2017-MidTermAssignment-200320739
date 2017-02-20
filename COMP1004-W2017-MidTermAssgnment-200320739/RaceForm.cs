//FileName: RaceForm.cs
//FileType: Visual C# Source file
//Author: Junghwan Yang
//Student ID: 200320739
//Created On: 20/02/2017
//Copy Rights: Junghwan Yang
//Description: This form selects race, and shows increase bonus status or decrease status depending on race
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
    public partial class RaceForm : Form
    {
        private bool _checkRace = false;
        private int[] _abilityInteger;
        public int[] AbilityInteger
        {
            get
            {
                return _abilityInteger;
            }
            set
            {
                _abilityInteger = value;
            }
        }
        private int[] _raceAbilities;
        public int[] RaceAbilities
        {
            get
            {
                return _raceAbilities;
            }
            set
            {
                _raceAbilities = value;
            }
        }
        private string _race;
        public string Race
        {
            get
            {
                return _race;
            }
            set
            {
                _race = value;
            }
        }
        public RaceForm()
        {
            InitializeComponent();
            


        }
        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _checkRace = true;
            RadioButton raceOption = sender as RadioButton;
            _raceAbilities = (int[])_abilityInteger.Clone();
            switch (raceOption.Tag.ToString())
            {
                case "Human":
                    Random random = new Random();
                    
                    for (int i = 0;i < 5; i++)
                    {
                        int randomNumber = random.Next(0, 6);
                        _raceAbilities[randomNumber] = _abilityInteger[randomNumber] + 1;
                    }
                    CharacterPictureBox.Image = global::COMP1004_W2017_MidTermAssgnment_200320739.Properties.Resources.M_Human1;
                    RacialBonusTextBox.Text = "+5 all of Abilities randomly";

                    Race = "Human";
                    break;
                case "Dwarf":
                    CharacterPictureBox.Image = global::COMP1004_W2017_MidTermAssgnment_200320739.Properties.Resources.M_Dwarf1;
                    _raceAbilities[0] = _abilityInteger[0] + 20;
                    _raceAbilities[4] = _abilityInteger[4] + 20;
                    _raceAbilities[5] = _abilityInteger[5] - 10;
                    
                    RacialBonusTextBox.Text = "+20 STR&PER by 20, -10 CHA";
                    Race = "Dwarf";
                    break;
                case "Elf":
                    CharacterPictureBox.Image = global::COMP1004_W2017_MidTermAssgnment_200320739.Properties.Resources.M_Elf1;
                    _raceAbilities[1] = _abilityInteger[1] + 15;
                    _raceAbilities[5] = _abilityInteger[5] + 15;
                    RacialBonusTextBox.Text = "+15 DEX&CHA";
                    Race = "Elf";
                    break;
                case "Halfling":
                    CharacterPictureBox.Image = global::COMP1004_W2017_MidTermAssgnment_200320739.Properties.Resources.M_Halfling2;
                    _raceAbilities[0] = _abilityInteger[0] - 10;
                    _raceAbilities[1] = _abilityInteger[1] + 20;
                    _raceAbilities[3] = _abilityInteger[3] + 20;
                    RacialBonusTextBox.Text = "+20 DEX&INT, -10 STR";
                    Race = "Halfling";
                    break;
            }
            CheckLimitOfAbilities(_raceAbilities);

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if(!_checkRace)
            {
                DialogResult result = MessageBox.Show("You have to check any race", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
