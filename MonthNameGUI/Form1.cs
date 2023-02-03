using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonthNameGUI
{
    public partial class MonthsLabel : Form
    {
        enum Months
        {
            JANUARY = 1, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY, AUGUST, SEPTEMBER, OCTOBER,
            NOVEMBER, DECEMBER
        }
        public MonthsLabel()
        {
            InitializeComponent();
        }
       
        private void butComplete_Click(object sender, EventArgs e)
        {
            Months month = (Months)Convert.ToInt32(txtMonthNum.Text);

            txtMonthNum.Text = Convert.ToString(month);
        }
        
    }
}
