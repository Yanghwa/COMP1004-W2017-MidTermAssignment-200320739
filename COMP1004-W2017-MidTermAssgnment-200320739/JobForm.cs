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
        private bool _checkJob = false;
        public RaceForm previousForm;
        
        private string _job;
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
        private int _healthPoint;
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
        public JobForm()
        {
            InitializeComponent();
            
            
        }

        private void NextButton_Click(object sender, EventArgs e)
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

        private void JobRadioButton_CheckedChanged(object sender, EventArgs e)
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

        private void JobForm_FormClosing(object sender, FormClosingEventArgs e)
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
