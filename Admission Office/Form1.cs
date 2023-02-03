using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admission_Office
{
    public partial class Admission : Form
    {
        public Admission()
        {
            InitializeComponent();
        }

        private void resultButton_Click(object sender, EventArgs e)
        {
            double averageScore;
            int admissionScore;
            averageScore = Convert.ToDouble(txtHighSchoolAverage.Text);
            admissionScore = Convert.ToInt32(txtAdmission.Text);
            answerLabel.Text = String.Format
                (averageScore >= 3.0 || admissionScore >= 60 ? "Accept" : "Reject" );
        }
    }
}
