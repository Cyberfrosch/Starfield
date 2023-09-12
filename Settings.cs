using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson1
{
    public partial class Settings : Form
    {
        private Starfield _starfield;

        public Settings(Starfield starfield)
        {
            InitializeComponent();
            _starfield = starfield;

            // apply default values
            tbStarSize.Value = _starfield.starSize;
            tbSpeed.Value = _starfield.speed;
            tbStarsNumber.Value = _starfield.starsNumber / 1000;

            lbStarSizeValue.Text = tbStarSize.Value.ToString();
            lbSpeedValue.Text = tbSpeed.Value.ToString();
            lbStarsNumberValue.Text = tbStarsNumber.Value.ToString();

            KeyPreview = true;
        }

        private void Color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialogBackground = new ColorDialog();

            if (colorDialogBackground.ShowDialog() == DialogResult.OK)
            {
                _starfield.colorBackground = colorDialogBackground.Color;
            }
        }

        private void TBStarSize_Scroll(object sender, EventArgs e)
        {
            _starfield.starSize = tbStarSize.Value;
            lbStarSizeValue.Text = tbStarSize.Value.ToString();
        }

        private void TBSpeed_Scroll(object sender, EventArgs e)
        {
            _starfield.speed = tbSpeed.Value;
            lbSpeedValue.Text = tbSpeed.Value.ToString();
        }

        private void tbStarsNumber_Scroll(object sender, EventArgs e)
        {
            _starfield.starsNumber = tbStarsNumber.Value * 1000;
            lbStarsNumberValue.Text = tbStarsNumber.Value.ToString();
        }

        private void BtClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Settings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        public void Settings_Load(object sender, EventArgs e)
        {
            if (_starfield.flagRun)
            {
                tbStarsNumber.Enabled = false;
            }
            else
            {
                tbStarsNumber.Enabled = true;
            }
        }
    }
}
