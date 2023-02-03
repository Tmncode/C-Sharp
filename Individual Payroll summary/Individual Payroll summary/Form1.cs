using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Payroll_summary
{
    public partial class formPayroll : Form
    {
        public formPayroll()
        {
            InitializeComponent();
        }

        private void butComplete_Click(object sender, EventArgs e)
        {

            int hourlyPayRate = Convert.ToInt32(txtPayRate.Text);
            int hourWork = Convert.ToInt32(txtHourWork.Text);
            
            double grossPay = hourlyPayRate * hourWork;
            double federalTaxDeduction = grossPay * 0.15;
            double stateTaxDeduction = grossPay * 0.05;
            double netPay = grossPay - (federalTaxDeduction + stateTaxDeduction);

            txtGrossPay.Text = grossPay.ToString("C");
            txtFedTax.Text = federalTaxDeduction.ToString("C");
            txtStateTax.Text = stateTaxDeduction.ToString("C");
            txtNetPay.Text = netPay.ToString("C");

        }
    }
}
