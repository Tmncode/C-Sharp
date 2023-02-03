using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;

namespace ShowFileInfo
{
   
    public partial class ShowFileInfo : Form
    {   
        public ShowFileInfo()
        { 
            InitializeComponent();
        }
        private void ShowFileInfo_Load(object sender, EventArgs e)
        {
            checkDirectories.Items.AddRange(Directory.GetFiles(@"D:\C#\CSharp.Chapter.14\My_Directory"));
        }

        private void checkDirectories_SelectedIndexChanged(object sender, EventArgs e)
        {
            //While selecting an item in the listbox, we have to take that name in a string 
            String listFile = checkDirectories.Text.ToString();
            //after that , we can get the create date of the file
            DateTime creation = File.GetCreationTime(listFile);
            //lastly assign that creation date to the label. Then it will show the creation time for each file
            lblCreation.Text = creation.ToString();
        }
    }
}
