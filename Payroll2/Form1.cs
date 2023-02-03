using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll2
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

        private void netPayButton_Click(object sender, EventArgs e)
        {

        }

        private void grossPayButton_Click(object sender, EventArgs e)
        {
            double hourlyPayRate, hoursWorked, grossPay, netPay, sum;
            double fedTotal, stateTotal;
            double fedTaxRate = 0.015, stateTaxRate = 0.05;
            //
            //
            hourlyPayRate = Convert.ToDouble(txtHourlyPayRate.Text);
            hoursWorked = Convert.ToDouble(txtHoursWorked.Text);                                     
            sum = hourlyPayRate * hoursWorked; 
            
        }

       

        
    }
}
