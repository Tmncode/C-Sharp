using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordsOfWisdom
{
    public partial class QuoteForm : Form
    {
        public QuoteForm()
        {
            InitializeComponent();
        }

        private void QuoteForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            label3.BackColor = Color.White;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            label4.BackColor = Color.White;
        }
    }
}