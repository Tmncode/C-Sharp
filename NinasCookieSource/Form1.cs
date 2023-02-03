using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NinasCookieSource
{
    public partial class Form1 : Form
    {
        double accumulate;

        public Form1()
        {
            InitializeComponent();
            //Add to listbox
            this.cookieListBox.Items.AddRange(new Object[]
            {
                 "1/2 dozen", "1 dozen", "2 dozen", "3 dozen"
            });

            //Set the minimum calender date to today
            monthCalendar1.MinDate = DateTime.Today;
            deliveryLabel.Text = "Cookies delivered on: " + monthCalendar1.SelectionStart.AddDays(3).ToShortDateString();

            //create event handler for radio button is changed
            chocolateRadioButton.CheckedChanged += new EventHandler(chocolateRadioButton_CheckedChanged);
            oatmealRadioButton.CheckedChanged += new EventHandler(oatmealRadioButton_CheckedChanged);
            wafferRadioButton.CheckedChanged += new EventHandler(wafferRadioButton_CheckedChanged);
            cookieListBox.SelectedIndexChanged += new EventHandler(cookieListBox_SelectedIndexChanged);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            //declare variables
            double price = 0;

            //try and catch exceptions
            try
            {
                if ((chocolateRadioButton.Checked == false) && (oatmealRadioButton.Checked == false) && (wafferRadioButton.Checked == false))
                {
                    throw new ArgumentException();
                }

                try
                {
                    if (cookieListBox.SelectedIndex == -1) throw new ArgumentException();
                    //give price based on what items chosen
                    if (oatmealRadioButton.Checked == true)
                    {
                        if (cookieListBox.SelectedIndex == 0)
                        {
                            price = 3.99;
                        }
                        else if (cookieListBox.SelectedIndex == 1)
                        {
                            price = 6.99;
                        }
                        else if (cookieListBox.SelectedIndex == 2)
                        {
                            price = 12.99;
                        }
                        else
                        {
                            price = 15.99;
                        }
                    }
                    else if (chocolateRadioButton.Checked == true)
                    {
                        if (cookieListBox.SelectedIndex == 0)
                        {
                            price = 4.99;
                        }
                        else if (cookieListBox.SelectedIndex == 1)
                        {
                            price = 8.99;
                        }
                        else if (cookieListBox.SelectedIndex == 2)
                        {
                            price = 12.99;
                        }
                        else
                        {
                            price = 16.99;
                        }
                    }
                    else
                    {
                        if (cookieListBox.SelectedIndex == 0)
                        {
                            price = 3.99;
                        }
                        else if (cookieListBox.SelectedIndex == 1)
                        {
                            price = 7.99;
                        }
                        else if (cookieListBox.SelectedIndex == 2)
                        {
                            price = 12.99;
                        }
                        else
                        {
                            price = 16.99;
                        }
                    }
                    //display price and calculate accumulate
                    cookieTextBox.Text = price.ToString("C");
                    accumulate += price;
                    accumulateTextBox.Text = accumulate.ToString("C");
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Choose a quantity of cookie.", "Missing purchase detail.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
            catch (ArgumentException)
            {
                MessageBox.Show("Choose a type of cookie.", "Missing purchase detail.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //clear the price textbox when different button chosen
        private void RadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            cookieTextBox.Clear();
        }

        //clear the form
        private void clearButton_Click_1(object sender, EventArgs e)
        {
            cookieTextBox.Clear();
            accumulateTextBox.Clear();
            cookieListBox.SelectedIndex = -1;
            chocolateRadioButton.Checked = false;
            oatmealRadioButton.Checked = false;
            wafferRadioButton.Checked = false;
            monthCalendar1.ShowToday = true;
            deliveryLabel.Text = "Cookies delivered on: " + DateTime.Today.AddDays(3).ToShortDateString();
        }
        //close the form
        private void closeButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        // show the delivery date on the label
        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            const int DAYS_TO_ADD = 3;
            deliveryLabel.Text = "Cookies delivered on: " + monthCalendar1.SelectionStart.AddDays(DAYS_TO_ADD).ToShortDateString();
        }
       
        private void cookieTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chocolateRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void oatmealRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void wafferRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cookieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
    

