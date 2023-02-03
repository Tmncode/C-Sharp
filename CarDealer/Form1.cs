using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealer
{
    public partial class CarDealerForm : Form
    {
        public CarDealerForm()
        {
            InitializeComponent();
        }

        private void CarDealerForm_Load(object sender, EventArgs e)
        {

        }

        private void tundraCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tundraCheckBox.Checked)
            {
                TundraInfoForm tundraInfoForm = new TundraInfoForm();
                tundraInfoForm.ShowDialog();
                tundraCheckBox.Checked = false;
            }
        }

        private void focusCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (focusCheckBox.Checked)
            {
                FocusInfoForm focusInfoForm = new FocusInfoForm();
                focusInfoForm.ShowDialog();
                focusCheckBox.Checked = false;
            }
        }

        private void camryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (camryCheckBox.Checked)
            {
                CamryInfoForm camryInfoForm = new CamryInfoForm();
                camryInfoForm.ShowDialog();
                camryCheckBox.Checked = false;
            }
        }
    }
}
