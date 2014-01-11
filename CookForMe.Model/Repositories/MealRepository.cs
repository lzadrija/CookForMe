using System;
using System.Collections.Generic;
using System.Linq;

using CookForMeUtil;

namespace CookForMe.Model.Repositories
{
    public class MealRepository : Subject
    {
        private readonly List<Meal>   _listMeal;
        private static MealRepository _instance;



        public MealRepository()
        {
            _listMeal = new List<Meal>();
        }




        public static MealRepository GetInstance()
        {
            return _instance ?? (_instance = new MealRepository());
        }


        public Meal AddEmptyMeal(String mealName, String description)
        {
            var newMeal = GetMealByName(mealName);

            if (null != newMeal)
            {
                throw new ItemAlreadyExistsException();
            }

            newMeal = new Meal(mealName, description);

            _listMeal.Add(newMeal);

            Notify();

            return newMeal;
        }

        public void AddNewRecipeToMeal(String recipeName, String mealName, int mealIndex,
                                        Dictionary<String, String> ingredients, String preparation)
        {
            var meal = GetMeal(mealName, mealIndex);
            if (null == meal)
            {
                throw new ItemNotFoundException();
            }
            var recipe = new Recipe(recipeName, ingredients, preparation);
            meal.AddRecepie(recipe);

            Notify();
        }

        public void AddNewRecipeWithPicturesToMeal(String recipeName, String mealName, int mealIndex, 
                                                    Dictionary<String, String> ingredients, 
                                                    String preparation, Dictionary<String, String> photoData)
        {
            var meal = GetMeal(mealName, mealIndex);   
            if (null == meal)
            {
                throw new ItemNotFoundException();
            }
            var recipe = new Recipe(recipeName, ingredients, preparation);

            var photos = photoData.Keys.Select(photoName => new Photo(photoName, photoData[photoName])).ToList();
            recipe.Images = photos;

            meal.AddRecepie(recipe);

            Notify();
        }

        private Meal GetMeal(String mealName, int mealIndex)
        {
            if (mealIndex < 0)
            {
                throw new MealNotValidException();
            }
            Meal meal;
            try
            {
                meal = GetMealAt(mealIndex);

                if (String.Compare(meal.Name, mealName, StringComparison.Ordinal) != 0)
                {
                    meal = GetMealByName(mealName);
                }
            }
            catch (InvalidIndexException)
            {
                meal = GetMealByName(mealName);
            }
            return meal;
        }




        public Dictionary<String, List<String>> GetGeneratedDailyMenuData(Dictionary<String, List<String>> 
                                                                                        mealsIngredientsSelectionMap,
                                                                          Dictionary<String, int> mealsNumRecipesMap)
        {
            var mealsMatchingRecipesMap = new Dictionary<String, List<String>>(); 

            var mealNames = mealsIngredientsSelectionMap.Keys.ToList();
            foreach(var mealName in mealNames)
            {
                var meal = GetMealByName(mealName);
                if (null == meal) continue;
                var foodsForMeal = mealsIngredientsSelectionMap[mealName];
                var desiredNumOfRecipes = mealsNumRecipesMap[mealName];
                var recipeIDs = meal.FindRecipesThatContainFood(foodsForMeal, desiredNumOfRecipes);

                if (recipeIDs.Count != 0)
                {
                    mealsMatchingRecipesMap[mealName] = recipeIDs;
                }
            }
            return mealsMatchingRecipesMap;
        }






        public Dictionary<string, string> GetMatchingRecipes(List<string> foodsNames, List<string> searchParameters)
        {
            var matchingRecipesData = new Dictionary<string, string>();
            var matchingRecipes = new List<Recipe>();
            var matchingMeals = new List<Meal>();
            var mealsWithMatchedRecipes = (from meal in _listMeal let numberOfMatchedRecipesInMeal = 
                                meal.GetMatchingRecipeData(matchingRecipes, foodsNames) where numberOfMatchedRecipesInMeal > 0 select meal).ToList();

            foreach(var searchParameter in searchParameters)
            {
                foreach (var meal in _listMeal.Where(meal => !mealsWithMatchedRecipes.Contains(meal)))
                {
                    if (meal.IsDataPartOfName(searchParameter))
                    {
                        matchingMeals.Add(meal);
                    }
                    var numberOfMatchedRecipesInMeal = meal.SetRecipesWithMatchingNames(matchingRecipes, searchParameter);

                    if (numberOfMatchedRecipesInMeal > 0)
                    {
                        mealsWithMatchedRecipes.Add(meal);
                    }
                }
            }

            foreach (var meal in matchingMeals.Where(meal => !mealsWithMatchedRecipes.Contains(meal)))
            {
                meal.SetAllUnmatchedRecipes(matchingRecipes);
            }

            foreach (var recipe in matchingRecipes)
            {
                matchingRecipesData[recipe.Id] = recipe.Name;
            }

            return matchingRecipesData;
        }







        public String GetRecipeNameForMeal(String recipeId, String mealName)
        {
            var recipe = GetRecipeForMeal(recipeId, mealName);

            return recipe.Name;
        }

        public Recipe GetRecipeForMeal(String recipeId, String mealName)
        {
            var meal = GetMealByName(mealName);

            if (null == meal)
            {
                throw new ItemNotFoundException();
            }

            var recipe = meal.GetRecipeById(recipeId);

            if (null == recipe)
            {
                throw new ItemNotFoundException();
            }

            return recipe;
        }

        public Dictionary<String, String> GetRecepieDataForMeal(String mealName)
        {
            var recipesData = new Dictionary<String, String>();

            foreach (var meal in _listMeal.Where(meal => String.Compare(meal.Name, mealName, StringComparison.Ordinal) == 0))
            {
                recipesData = meal.GetRecipeData();
                break;
            }

            return recipesData;
        }

        public Recipe GetRecipeById(string recipeId)
        {
            return _listMeal.Select(meal => meal.GetRecipeById(recipeId)).FirstOrDefault(recipe => null != recipe);
        }

        public Meal GetMealAt(int mealIndex)
        {
            if (mealIndex >= _listMeal.Count)
            {
                throw new InvalidIndexException();
            }
            return _listMeal[mealIndex];
        }

        public Meal GetMealByName (String mealName)
        {
            return _listMeal.FirstOrDefault(meal => String.Compare(meal.Name, mealName, StringComparison.Ordinal) == 0);
        }

        public List<String> GetMealsName()
        {
            return _listMeal.Select(meal => meal.Name).ToList();
        }

        public bool IsMealDefined(string foodName)
        {
            return GetMealByName(foodName) != null;
        }
    }
}
