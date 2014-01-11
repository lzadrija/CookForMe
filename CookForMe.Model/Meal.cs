using System;
using System.Collections.Generic;
using System.Linq;

namespace CookForMe.Model
{
    public class Meal : Item
    {
        private List<Recipe> _recepies;



        public Meal(String name, String description)
            : base(name, description)
        {
            _recepies = new List<Recipe>();
        }



        public List<String> FindRecipesThatContainFood(List<String> foodList, int desiredNumOfRecipes)
        {
            var matchingRecipesMap = new Dictionary<string, int>();

            if(foodList.Count == 0)
            {
                return GetRecipeData().Keys.ToList();
            }

            foreach(var recipe in _recepies)
            {
                var numberOfMatchingFoodsForRecipe = recipe.GetNumberOfMatchingFoods(foodList);

                if(numberOfMatchingFoodsForRecipe > 0)
                {
                    matchingRecipesMap[recipe.Id] = numberOfMatchingFoodsForRecipe;
                }
            }
            var foodsCountList = matchingRecipesMap.Keys.ToList();

            var recipes = new List<String>();
            int[] recipeCounter = {0};
            foreach (var foodId in foodsCountList.TakeWhile(foodId => desiredNumOfRecipes != recipeCounter[0]))
            {
                recipes.Add(foodId);
                recipeCounter[0]++;
            }
            return recipes;
        }





        public int GetMatchingRecipeData(List<Recipe> matchedRecipes, List<string> foodsNames)
        {
            var numberOfMatchedRecipes = 0;

            foreach(Recipe recipe in _recepies)
            {
                if (matchedRecipes.Contains(recipe))
                {
                    numberOfMatchedRecipes++;
                    continue;
                }
                if (recipe.ContainsFoods(foodsNames))
                {
                    numberOfMatchedRecipes++;
                    matchedRecipes.Add(recipe);
                }
            }
            return numberOfMatchedRecipes;
        }



       
        public int SetRecipesWithMatchingNames (List<Recipe> matchedRecipes, String dataToCheck)
        {
            var numberOfMatchedRecipes = 0;

            foreach (Recipe recipe in _recepies)
            {
                if (matchedRecipes.Contains(recipe))
                {
                    numberOfMatchedRecipes++;
                    continue;
                }
                if (recipe.IsDataPartOfName(dataToCheck))
                {
                    numberOfMatchedRecipes++;
                    matchedRecipes.Add(recipe);
                }
            }
            return numberOfMatchedRecipes;
        }



        public void SetAllUnmatchedRecipes(List<Recipe> matchedRecipes)
        {
            foreach (Recipe recipe in _recepies)
            {
                if (!matchedRecipes.Contains(recipe))
                {
                    matchedRecipes.Add(recipe);
                }
            }
        }




        public void AddRecepie(Recipe recepie)
        {
            _recepies.Add(recepie);
        }

        public void RemoveRecepie(Recipe recepie)
        {
            bool isRecepieRemoved = _recepies.Remove(recepie);

            if (!isRecepieRemoved)
            {
                throw new ItemNotFoundException();
            }
        }

        public bool ContainsRecepie(Recipe recepie)
        {
            return _recepies.Contains(recepie);
        }





        public Dictionary<String, String> GetRecipeData()
        {
            return _recepies.ToDictionary(recipe => recipe.Id, recipe => recipe.Name);
        }

        public Recipe GetRecipeById(String recipeId)
        {
            return _recepies.FirstOrDefault(recipe => String.Compare(recipe.Id, recipeId, StringComparison.Ordinal) == 0);
        }


        public List<Recipe> Recepies
        {
            get { return _recepies; }
            set { _recepies = value; }
        }
    }
}
