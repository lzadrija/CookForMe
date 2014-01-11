
namespace CookForMe.Model
{
    public class NutritionFacts
    {
        private readonly double _proteinAmount;
        private readonly double _fatAmount;
        private readonly int _energyValue;

        private readonly double _amount;




        public NutritionFacts(int energyValue, double amount, double proteinAmount, double fatAmount)
        {
            if (!isEnergyValueValid(energyValue))
            {
                throw new InvalidNutritionFactAmountException("Invalid energy value amount. Energy value cannot be negative");
            }
            if (!IsAmountValid(amount))
            {
                throw new ParemeterNegativeOrZeroException("Invalid amount. Amonut cannot be zero or negative");
            }
            if (!isNutritionFactAmountValid(proteinAmount))
            {
                throw new InvalidNutritionFactAmountException("Invalid protein amount. Protein amount cannot be negative");
            }
            if (!isNutritionFactAmountValid(fatAmount))
            {
                throw new InvalidNutritionFactAmountException("Invalid fat amount. Fat amount cannot be negative");
            }
            _energyValue = energyValue;
            _amount = amount;
            _proteinAmount = proteinAmount;
            _fatAmount = fatAmount;
        }




        public double ProteinAmount
        {
            get { return _proteinAmount; }
        }

        public double FatAmount
        {
            get { return _fatAmount; }
        }

        public int EnergyValue
        {
            get { return _energyValue; }
        }

        public double Amount
        {
            get { return _amount; }
        }





        private bool isEnergyValueValid(int value)
        {
            return value >= 0;
        }

        public static bool IsAmountValid(double amount)
        {
            return amount >= 0;
        }

        private bool isNutritionFactAmountValid(double nutritionAmount)
        {
            return nutritionAmount >= 0;
        }
    }
}