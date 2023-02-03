using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiveColors
{
    public partial class changeColorForm : Form
    {
        public changeColorForm()
        {
            InitializeComponent();
        }

        private void changeColorForm_Load(object sender, EventArgs e)
        {

        }

        private void changeColorButton1_Click(object sender, EventArgs e)
        {           
            this.BackColor = Color.Blue;           
        }

        private void changeColorButton2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void changeColorButton3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void changeColorButton4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Lime;
        }

        private void changeColorButton5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Purple;
        }
    }
}
