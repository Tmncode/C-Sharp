using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlorencesFloralCreations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void lstOccasions_SelectedIndexChanged(object sender,EventArgs e)
        {
            lstFlowers.Items.Clear();
            switch (lstFlowers.SelectedIndex)
            {
                case -1:
                    lstFlowers.Visible = false;
                    break;
                case 0:
                    lstFlowers.Items.Add("Red Roses");
                    lstFlowers.Items.Add("Pink snapdragon");
                    lstFlowers.Visible = true;
                    break;
                case 1:
                    lstFlowers.Items.Add("Poppy");
                    lstFlowers.Items.Add("Daisy");
                    lstFlowers.Visible = true;
                    break;
                case 2:
                    lstFlowers.Items.Add("Blanket flower");
                    lstFlowers.Items.Add("Iris");
                    lstFlowers.Visible = true;
                    break;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lstFlowers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCongrats.Visible = false;
            lblCongrats.Text = "Congrats!";
            switch (lstFlowers.SelectedIndex)
            {
                case -1:
                    lblCongrats.Visible = false;
                    break;
                case 0:
                case 1:
                    lblCongrats.Visible = true;
                    break;
            }
        }
    }
}
