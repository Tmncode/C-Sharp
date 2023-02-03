using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace RecentlyVisitedSites
{

    public partial class RecentlyVisitedSites : Form
    {      
        public RecentlyVisitedSites()
        {
            InitializeComponent();
        }

        private void lnkOne_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)    
            => Process.Start(new Uri("http://www.google.com/").ToString());
        private void lnkOne_MouseHover(object sender, EventArgs e)
            => lblInfo.Text = "search engine";
        private void lnkTwo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start(new Uri("http://www.wikipedia.org/").ToString());
        private void lnkTwo_MouseHover(object sender, EventArgs e)
            => lblInfo.Text = "wiki news";
        private void lnkThree_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
            => Process.Start(new Uri("http://www.microsoft/").ToString());
        private void lnkThree_MouseHover(object sender, EventArgs e)
            => lblInfo.Text = "Computer Company";

        private void RecentlyVisitedSites_Load(object sender, EventArgs e)
        {

        }
    }
}
