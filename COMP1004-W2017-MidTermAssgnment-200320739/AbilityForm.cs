//FileName: AbilityForm.cs
//FileType: Visual C# Source file
//Author: Junghwan Yang
//Student ID: 200320739
//Created On: 20/02/2017
//Copy Rights: Junghwan Yang
//Description: This form creates abilities using random -> 3 to 30
//            

/////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssgnment_200320739
{
    public partial class AbilityForm : Form
    {
        // Random Number object
        Random random = new Random();
        //PRIVATE INSTANCE VARIABLES
        private List<TextBox> _abilities;
        private int[] _abilityInteger = new int[6];
        private bool _checkRoll = false;
        
        //CONSTRUCTOR-------------------------------
        public AbilityForm()
        {
            InitializeComponent();

            this._abilities = new List<TextBox>();
            this.InitializeAbilities();
        }
        //Event Handelers---------------------------
        /// <summary>
        /// This method simulates the rolling of three 10-sided dice
        /// </summary>
        /// <returns>
        /// This method returns a number between 3 and 30 (The result of rolling 3d10)
        /// </returns>
        private int Roll3D10()
        {
            int result = 0;
            for (int dice = 0; dice < 3; dice++)
            {
                result += random.Next(1, 11);
            }
            return result;
        }
        /// <summary>
        /// This method executes Roll3D10 method, so set every abilities as a number between 3 and 30
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickRollButton(object sender, EventArgs e)
        {
            Debug.WriteLine(Roll3D10().ToString());
            for (int ability = 0; ability < this._abilities.Count; ability++)
            {
                // roll 3d10 and assign the value to a temp variable
                int currentRoll = this.Roll3D10();

                // assign the current roll to the current ability and show in the textbox
                this._abilityInteger[ability] = currentRoll;
                this._abilities[ability].Text = currentRoll.ToString();
            }
            _checkRoll = true;
        }
        /// <summary>
        /// this method sends the abilities infomation to RaceFrom when users click next button
        /// shows the warning message if users didn't click the roll button before going to the next
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickNextButton(object sender, EventArgs e)
        {
            if(!_checkRoll)
            {
                DialogResult result = MessageBox.Show("You have to roll at least once", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            RaceForm race = new RaceForm();
            race.AbilityInteger = this._abilityInteger;
            this.Hide();
            race.Show();
        }
        
        private void InitializeAbilities()
        {
            this._abilities.Add(STRTextBox);
            this._abilities.Add(DEXTextBox);
            this._abilities.Add(ENDTextBox);
            this._abilities.Add(INTTextBox);
            this._abilities.Add(PERTextBox);
            this._abilities.Add(CHATextBox);
        }
        
    }
}
