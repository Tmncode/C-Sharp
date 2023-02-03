using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class payrollForm : Form
    {
        public payrollForm()
        {
            InitializeComponent();
        }

                     
                      
            private void netPayButton_Click_1(object sender, EventArgs e)
        {
            //
            //
            int hourlyPayRate = Convert.ToInt32(txtHourlyPayRate.Text);
            int hoursWorked = Convert.ToInt32(txtHoursWorked.Text);
            //
            //
            double grossTotalPay = hourlyPayRate * hoursWorked;
            double fedTax = grossTotalPay * 0.15;
            double stateTax = grossTotalPay * .05;
            double netPayTotal = grossTotalPay - (fedTax + stateTax);
            //
            //
            txtTotalGross.Text = grossTotalPay.ToString("C");
            txtFedTax.Text = fedTax.ToString("C");
            txtStateTax.Text = stateTax.ToString("C");
            txtNetPay.Text = netPayTotal.ToString("C");
        }

        private void payrollForm_Load(object sender, EventArgs e)
        {

        }
    }
}
