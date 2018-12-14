using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TournamentLibrary;

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
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(placeNameValueTextBox.Text, placeNumberValueTextBox.Text, 
                    PrizeAmountValueTextBox.Text, PricePercentageValueTextBox.Text);

                foreach(IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }

               

            }
            else
            {
                MessageBox.Show($"This form has invalid information! Please try it again!");
            }

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
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(PrizeAmountValueTextBox.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(PricePercentageValueTextBox.Text, out prizePercentage);

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
