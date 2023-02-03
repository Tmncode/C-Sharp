﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class CarRentalInteractive : Form
    {
        public CarRentalInteractive()
        {
            InitializeComponent();
        }


    private void CarRentalInteractive_Load(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            double costForDays;
            double costForMiles;
            double sum;
            // Start Here
            costForDays = (Convert.ToDouble(txtNbrOfDays.Text) * Convert.ToDouble(txtFeePerDay.Text));
            costForMiles = (Convert.ToDouble(txtMiles.Text) * Convert.ToDouble(txtFeePerMile.Text));
            sum = costForDays + costForMiles;
            label1.Text = "Total is " + sum.ToString("C");

                
        }
    }
    }

