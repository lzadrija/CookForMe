using System;

namespace CookForMe.Model
{
    public class Food : Item
    {
        private readonly String         _foodType;
        private readonly NutritionFacts _nutritionFacts;

        private Photo                   _image;



        public Food(String name, String description, String foodType, NutritionFacts nutritionFacts)
            : base(name, description)
        {
            if (IsFoodTypeEmpty(foodType))
            {
                throw new ParemeterEmptyException();
            }
            _foodType = foodType;
            _nutritionFacts = nutritionFacts;
            _image = null;
        }

        public Food(String name, String description, String foodType, NutritionFacts nutritionFacts, Photo image)
            : base(name, description)
        {
            if (IsFoodTypeEmpty(foodType))
            {
                throw new ParemeterEmptyException();
            }
            _foodType = foodType;
            _nutritionFacts = nutritionFacts;
            _image = image;
        }




        public double GetProteinAmount()
        {
            return _nutritionFacts.ProteinAmount;
        }

        public double GetFatAmount()
        {
            return _nutritionFacts.FatAmount;
        }

        public int GetEnergyValue()
        {
            return _nutritionFacts.EnergyValue;
        }

        public double GetDefaultAmount()
        {
            return _nutritionFacts.Amount;
        }




       
        public String FoodType
        {
            get { return _foodType; }
        }

        public NutritionFacts FoodNutritionFacts
        {
            get { return _nutritionFacts; }
        }

        public Photo Image
        {
            get { return _image; }
            set { _image = value; }
        }



        public bool IsImageSet()
        {
            return _image != null;
        }

        private static bool IsFoodTypeEmpty(String foodType)
        {
            return foodType.Equals("");
        }
    }
}
