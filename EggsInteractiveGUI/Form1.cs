using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class eggCalculator : Form
    {
        public eggCalculator()
        {
            InitializeComponent();
        }

        private void calculatorButton_Click(object sender, EventArgs e)
        {
            double hen1, hen2, hen3, hen4, hen5,
                sum, remainder;
            int dozen;

            //
            //Start Here
            //
            hen1 = Convert.ToDouble(txtEggHen1.Text);
            hen2 = Convert.ToDouble(txtEggHen2.Text);
            hen3 = Convert.ToDouble(txtEggHen3.Text);
            hen4 = Convert.ToDouble(txtEggHen4.Text);
            hen5 = Convert.ToDouble(txtEggHen5.Text);
            //
            //
            //
            sum = hen1 + hen2 + hen3 + hen4 + hen5;
            dozen = Convert.ToInt32(sum / 12);
            remainder = sum % 12;
            //
            //
            //
            label1.Text = sum + " total egg " + dozen + " dozen " + remainder + " left over ";
                      
            


        }

        

           
    }
}
