using System;


namespace CookForMe.Model
{
    public class CalorieCalculator
    {

        protected static CalorieCalculator Instance = null;

        public static CalorieCalculator GetInstance()
        {
            return Instance ?? (Instance = new CalorieCalculator());
        }


        public int CalculateEnergyValueForAmount(double amount, double defaultAmount, int energyValue)
        {
            if (!NutritionFacts.IsAmountValid(amount))
            {
                throw new ParemeterNegativeOrZeroException("Invalid amount. Amonut cannot be zero or negative");
            }

            var realResult = (amount * (energyValue / defaultAmount));


            var decimalResult = decimal.Round(Convert.ToDecimal(realResult), 0, MidpointRounding.AwayFromZero);

            var energyValueForRequestedAmount = Convert.ToInt32(decimalResult);

            return energyValueForRequestedAmount;
        }
    }
}
