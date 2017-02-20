//FileName: JobForm.cs
//FileType: Visual C# Source file
//Author: Junghwan Yang
//Student ID: 200320739
//Created On: 20/02/2017
//Copy Rights: Junghwan Yang
//Description: This form selects job and show health points depending on job
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
    public partial class JobForm : Form
    {
        //PRIVATE INSTANCE VARIABLES
        private bool _checkJob = false;
        private string _job;
        private int _healthPoint;
        
        //Classes ------------------------
        public RaceForm previousForm;
        //CONSTRUCTORS----------------------------------
        public JobForm()
        {
            InitializeComponent();
        }
        //Event Handlers---------------------------
        /// <summary>
        /// this method sends the job infomation to FinalForm when users click next button
        /// shows the warning message if users didn't click any job before going to the next
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickNextButton(object sender, EventArgs e)
        {
            if (!_checkJob)
            {
                DialogResult result = MessageBox.Show("You have to check any job", "Warning",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FinalForm final = new FinalForm();
            this.Hide();
            final.previousForm = this;
            final.InitializeFinalForm();
            final.Show();
            
        }
        /// <summary>
        /// this method detects users click the radio button and shows healthpoints
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckedChangedJobRadioButton(object sender, EventArgs e)
        {
            _checkJob = true;
            RadioButton jobOption = sender as RadioButton;

            switch (jobOption.Tag.ToString())
            {
                case "Soldier":
                    HealthPoint = previousForm.RaceAbilities[2] + 30;
                    Job = "Soldier";
                    break;
                case "Rogue":
                    HealthPoint = previousForm.RaceAbilities[1] + 28;
                    Job = "Rogue";
                    break;
                case "Magicker":
                    HealthPoint = previousForm.RaceAbilities[3] + 15;
                    Job = "Magicker";
                    break;
                case "Cultist":
                    HealthPoint = previousForm.RaceAbilities[5] + 24;
                    Job = "Cultist";
                    break;
            }
            HealthPointTextBox.Text = _healthPoint.ToString();
        }
        /// <summary>
        /// this method shows the warning message when users want to close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormClosingJobForm(object sender, FormClosingEventArgs e)
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
        //functions-------------------------------
        /// <summary>
        /// this method is getter and setter for _job
        /// </summary>
        public string Job
        {
            get
            {
                return _job;
            }
            set
            {
                _job = value;
            }
        }
        
        /// <summary>
        /// this method is getter and setter for _healthPoint
        /// </summary>
        public int HealthPoint
        {
            get
            {
                return _healthPoint;
            }
            set
            {
                _healthPoint = value;
            }

        }
    }
}
