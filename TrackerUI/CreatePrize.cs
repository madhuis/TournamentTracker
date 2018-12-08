﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerUI
{
    public partial class CreatePrize : Form
    {
        public CreatePrize()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;
            bool placeNumValidNum = int.TryParse(placeNameValueTextBox.Text, out placeNumber);
            if (placeNumValidNum == false){
                // Equivalent to !placeNumValidNum

                output = false;

            }

            if(placeNumber < 1)
            {
                output = false;
            }

            if(placeNameValueTextBox.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            int prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(PrizeAmountValueTextBox.Text, out prizeAmount);
            bool prizePercentageValid = int.TryParse(PricePercentageValueTextBox.Text, out prizePercentage);

            if (prizeAmountValid == false || prizePercentageValid == false)
            {
                output = false;
            }
            if(prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if(prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
