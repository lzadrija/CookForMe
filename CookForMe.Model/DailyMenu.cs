using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CookForMe.Model
{
    public class DailyMenu : Item
    {

        private Dictionary<String, List<String>> _mealsForRecipesMap;


        public DailyMenu(String name, String description, Dictionary<String, List<String>> mealsForRecipesMap)
            : base(name, description)
        {
            if (IsMealsForRecipesMapEmpty(mealsForRecipesMap))
            {
                throw new ParemeterEmptyException();
            }
            _mealsForRecipesMap = mealsForRecipesMap;
        }




        public bool ContainsRecipes(List<string> recipesIDs)
        {
            var menusRecipes = _mealsForRecipesMap.Keys.ToList();

            return (from recipeId in recipesIDs from mealName in menusRecipes where 
                                        _mealsForRecipesMap[mealName].Contains(recipeId) select recipeId).Any();
        }





        public bool ContainsRecipeIdForMeal(String mealName, String recipeId)
        {
            return ContainsMeal(mealName) && _mealsForRecipesMap[mealName].Contains(recipeId);
        }

        public bool ContainsMeal(String mealName)
        {
            return _mealsForRecipesMap.ContainsKey(mealName);
        }

        private static bool IsMealsForRecipesMapEmpty(ICollection recepiesMenus)
        {
            return recepiesMenus.Count == 0;
        }

        

        public Dictionary<String, List<String>> MealsForRecipesMap
        {
            get { return _mealsForRecipesMap; }
            set 
            {
                if (IsMealsForRecipesMapEmpty(value))
                {
                    throw new ParemeterEmptyException();
                }
                _mealsForRecipesMap = value; 
            }
        }
    }
}
