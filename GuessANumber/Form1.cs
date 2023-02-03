using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessANumber
{
    public partial class GuessANumber : Form
    {
        private int randomNumber = new Random().Next(0, 6);
        public GuessANumber()
        {
            InitializeComponent();
        }

        private void rad_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton[] rads = grpRad.Controls.OfType<RadioButton>().ToArray();
            RadioButton correctRad = rads[randomNumber];
            RadioButton selectedRad = rads.FirstOrDefault(x => x.Checked);
            if(selectedRad == correctRad)
            {
                lblHint.Text = "Correct!";
            }
            else
            {
                lblHint.Text = "Try Again!";
            }
        }
    }
}
