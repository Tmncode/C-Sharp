using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FontSelector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fontNamesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fontSizesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        static Dictionary<string, Font> fontNames = new Dictionary<string, Font>
        {
            {"Arial", new Font ("Arial", 14) },
            {"Bradley Hand ITC", new Font ("Bradley Hand ITC", 14) },
            {"Edwardian Script ITC", new Font ("Edwardian Script ITC", 14) },
            {"Harrington", new Font ("Harrington", 14) }
        };
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (fontNames.TryGetValue(fontNamesListBox.SelectedItem.ToString(), out Font font)) ;
                {
                    displayLabel.Font = new Font(font.Name, int.Parse(fontSizesListBox.SelectedItem.ToString()));
                }
            }
            catch (Exception)
            {

            }
            displayLabel.Text = "Hello";
               
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
