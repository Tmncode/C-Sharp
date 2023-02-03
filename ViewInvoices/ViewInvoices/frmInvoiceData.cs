using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ViewInvoices
{
    public partial class frmInvoiceData : Form
    {
        const char DELIM = ',';
        const string FILENAME = @"D:\C#\CSharp.Chapter.14\Invoices.txt";
        string recordIn;
        string[] fields;
        static FileStream file = new FileStream(FILENAME, 
            FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(file);
        public frmInvoiceData()
        {
            InitializeComponent();
        }

        private void lblInstruction_Click(object sender, EventArgs e)
        {

        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            try
            {
                recordIn = reader.ReadLine();
                fields = recordIn.Split(DELIM);
                invoiceBox.Text = fields[0];
                nameBox.Text = fields[1];
                amountBox.Text = fields[2];
            }
            catch (NullReferenceException)
            {
                lblInstruction.Text = "You have viewed\nall the records";
                viewButton.Enabled = false;
            }
        }

        private void frmInvoiceData_Load(object sender, EventArgs e)
        {

        }
    }
}
