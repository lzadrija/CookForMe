using System;
using System.Collections.Generic;
using System.Linq;
using CookForMeUtil;

namespace CookForMe.Model.Repositories
{
    public class FoodRepository : Subject
    {
        private readonly Dictionary<String, List<Food>> _mapFood;
        private static FoodRepository _instance;


        private FoodRepository()
        {
            _mapFood = new Dictionary<String, List<Food>>();
        }

        public static FoodRepository GetInstance()
        {
            return _instance ?? (_instance = new FoodRepository());
        }


        public void AddFood(String name, String description, String foodType, int energyValue, double amount,
                            double proteinAmount, double fatAmount)
        {
            var foodNutritionFacts = new NutritionFacts(energyValue, amount, proteinAmount, fatAmount);

            var food = new Food(name, description, foodType, foodNutritionFacts);

            AddFoodToMap(food, foodType);

            Notify();
        }

        public void AddFoodWithPicture(String name, String description, String foodType, int energyValue, double amount,
                                       double proteinAmount, double fatAmount, String filename, String caption)
        {
            var foodNutritionFacts = new NutritionFacts(energyValue, amount, proteinAmount, fatAmount);

            var foodPhoto = new Photo(filename, caption);

            var food = new Food(name, description, foodType, foodNutritionFacts, foodPhoto);

            AddFoodToMap(food, foodType);

            Notify();
        }

        private void AddFoodToMap(Food food, String foodType)
        {
            if (IsFoodDefined(food.Name))
            {
                throw new ItemAlreadyExistsException();
            }

            if (IsFoodTypeDefined(foodType))
            {
                _mapFood[foodType].Add(food);
            }
            else
            {
                var foodsForFoodType = new List<Food> {food};
                _mapFood[foodType] = foodsForFoodType;
            }
        }


        public List<String> GetFoodsNameThatContainData(List<string> dataToCheckList)
        {
            var foodTypes = _mapFood.Keys.ToList();

            var matchingFoodNamesByType = new Dictionary<string, List<string>>();
            var matchingFoodTypes = new List<string>();

            //find out if food type or food match parameters
            foreach (var dataToCheck in dataToCheckList)
            {
                foreach (var foodType in foodTypes)
                {
                    if (foodType.IndexOf(dataToCheck, 0, StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        if (!matchingFoodNamesByType.Keys.Contains(foodType))
                        {
                            matchingFoodTypes.Add(foodType);
                            matchingFoodNamesByType[foodType] = new List<string>();
                            break;
                        }
                    }
                    var foodsForFoodType = _mapFood[foodType];

                    var isFoodMatch = false;
                    var check = dataToCheck;
                    foreach (var food in foodsForFoodType.Where(food => food.IsDataEqualToNameIgnoreCase(check)))
                    {
                        if (matchingFoodNamesByType.Keys.Contains(foodType))
                        {
                            matchingFoodNamesByType[foodType].Add(food.Name);
                        }
                        else
                        {
                            var matchingFoodNamesForType = new List<string> {food.Name};
                            matchingFoodNamesByType[foodType] = matchingFoodNamesForType;
                        }
                        isFoodMatch = true;
                        break;
                    }
                    if (isFoodMatch)
                    {
                        break;
                    }
                }
            }
            //if one search searchParameter was equal to food type, and no match was found for foods of that type - take all foods of
            //that type - eg. searchParameter = "fruit" - all fruits are searched for
            foreach (var matchingFoodType in matchingFoodNamesByType.Keys.ToList().Where(
                                                            matchingFoodType => matchingFoodNamesByType[matchingFoodType].Count == 0))
            {
                matchingFoodNamesByType[matchingFoodType] = GetFoodNamesByType(matchingFoodType);
            }
            //put dictionary values in a list to return
            var matchingFoodNames = new List<String>();
            foreach (var matchingFoodType in matchingFoodNamesByType.Keys.ToList())
            {
                matchingFoodNames.AddRange(matchingFoodNamesByType[matchingFoodType]);
            }
            return matchingFoodNames;
        }


        public List<String> GetFoodNamesByType(String foodType)
        {
            if (!IsFoodTypeDefined(foodType))
            {
                throw new ItemNotFoundException();
            }

            return _mapFood[foodType].Select(food => food.Name).ToList();
        }

        public Dictionary<String, List<Food>>.KeyCollection GetFoodTypes()
        {
            return _mapFood.Keys;
        }

        public Food GetFoodByNameAndType(String foodName, String foodType)
        {
            if (!IsFoodTypeDefined(foodType))
            {
                throw new ItemNotFoundException();
            }
            var foodsForType = _mapFood[foodType];

            foreach (var food in foodsForType.Where(food => String.Compare(food.Name, foodName, StringComparison.Ordinal) == 0))
            {
                return food;
            }

            throw new ItemNotFoundException();
        }

        public Food GetFoodByName(String foodName)
        {
            var foodTypes = _mapFood.Keys;

            foreach (var food in from foodType in foodTypes select _mapFood[foodType] 
                        into foods from food in foods where 
                        String.Compare(food.Name, foodName, StringComparison.Ordinal) == 0 select food)
            {
                return food;
            }
            throw new ItemNotFoundException();
        }

        public List<String> GetFoodsName()
        {
            var foodTypes = _mapFood.Keys;

            var foods = new List<String>();
            foreach (var foodType in foodTypes)
            {
                foods.AddRange(GetFoodNamesByType(foodType));
            }
            return foods;
        }


        public bool IsFoodTypeDefined(String foodType)
        {
            var foodTypes = _mapFood.Keys;

            return foodTypes.Contains(foodType);
        }

        public bool IsFoodDefined(string foodName)
        {
            try
            {
                GetFoodByName(foodName);
                return true;
            }
            catch (ItemNotFoundException)
            {
                return false;
            }
        }

        public Dictionary<String, List<Food>> Foods
        {
            get { return _mapFood; }
        }
    }
}