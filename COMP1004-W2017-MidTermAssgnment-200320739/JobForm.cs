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
        public RaceForm previousForm;
        private int _healthPoint;
        public JobForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            FinalForm final = new FinalForm();
            final.Show();
            this.Hide();
        }

        private void JobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton jobOption = sender as RadioButton;

            switch (jobOption.Tag.ToString())
            {
                case "Soldier":
                    _healthPoint = previousForm.raceAbilities[2] + 30;
                    break;
                case "Rogue":
                    _healthPoint = previousForm.raceAbilities[1] + 28;
                    break;
                case "Magicker":
                    _healthPoint = previousForm.raceAbilities[3] + 15;
                    break;
                case "Cultist":
                    _healthPoint = previousForm.raceAbilities[5] + 24;
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
