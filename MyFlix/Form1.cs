using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFlix
{
    public partial class Form1 : Form
    {
        private const double PER_MOVIE_PRICE = 1.99;
        private double price = 1.99;
        public Form1()
        {
            InitializeComponent();
        }

        private void movieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {                   
        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            int count = movieListBox.SelectedItems.Count;
            movieLabel.Text = "Your total price is: " + count * 1.99 + " for " + count + " selection ";
            movieLabel.Visible = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
