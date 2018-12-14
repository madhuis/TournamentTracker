using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentLibrary.Models
{
    public class PrizeModel
    {
        public int Id { get; set; }

        public int PlaceNumber { get; set; }

        public string PlaceName { get; set; }

        public decimal PriceAmount { get; set; }

        public double PricePercentage { get; set; }

        public PrizeModel()
        {
             
        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            int placeNumVal = 0;

            int.TryParse(placeNumber, out placeNumVal);

            PlaceNumber = placeNumVal;

            decimal prizeAmountVal = 0;
            decimal.TryParse(prizeAmount, out prizeAmountVal);

            PriceAmount = prizeAmountVal;

            double PrizePercentageVal = 0;
            double.TryParse(prizePercentage, out PrizePercentageVal);

            PricePercentage = PrizePercentageVal;
        }
    }
}
