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
        public RaceForm()
        {
            InitializeComponent();
        }

        private void RaceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton raceOption = sender as RadioButton;
            switch(raceOption.Tag.ToString())
            {
                case "Human":
                    CharacterPictureBox.Image = global::COMP1004_W2017_MidTermAssgnment_200320739.Properties.Resources.M_Human1;
                    break;
                case "Dwarf":
                    CharacterPictureBox.Image = global::COMP1004_W2017_MidTermAssgnment_200320739.Properties.Resources.M_Dwarf1;
                    break;
                case "Elf":
                    CharacterPictureBox.Image = global::COMP1004_W2017_MidTermAssgnment_200320739.Properties.Resources.M_Elf1;
                    break;
                case "Halfling":
                    CharacterPictureBox.Image = global::COMP1004_W2017_MidTermAssgnment_200320739.Properties.Resources.M_Halfling2;
                    break;
            }
        }
    }
}
