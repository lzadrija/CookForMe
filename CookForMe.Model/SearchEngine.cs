using System.Collections.Generic;
using System.Linq;

using CookForMe.Model.Repositories;

namespace CookForMe.Model
{
    public class SearchEngine
    {
        private static SearchEngine        _instance;

        private Dictionary<string, string> _recipesData;
        private List<string>               _menusData, 
                                           _ingredientsData;


        public static SearchEngine GetInstance()
        {
            return _instance ?? (_instance = new SearchEngine());
        }


        public void Search(List<string> categories, string searchParametersString, FoodRepository foodRepository, 
                           MealRepository mealRepository, MenuRepository menuRepository)
        {
            ResultIngredientData = ResultMenuData = new List<string>();
            ResultRecipeData = new Dictionary<string, string>();

            if (System.String.Compare(searchParametersString, "", System.StringComparison.Ordinal) == 0 && categories.Count == 0)
            {
                return;
            }

            List<string> searchParameters = searchParametersString.Split(' ').ToList();

            SearchForIngredients(foodRepository, searchParameters);

            if (categories.Count == 0 || categories.Contains("Recipes") || categories.Contains("Daily menus"))
            {
                SearchForRecipes(mealRepository, searchParameters);

                if (categories.Count == 0 || categories.Contains("Daily menus"))
                {
                    SearchForDailyMenus(menuRepository, searchParameters);
                }
            }
        }





        public void SearchForIngredients(FoodRepository foodRepository, List<string> searchParameters)
        {
            _ingredientsData = foodRepository.GetFoodsNameThatContainData(searchParameters);
        }


        public void SearchForRecipes(MealRepository mealRepository, List<string> searchParameters)
        {
            _recipesData = _recipesData = mealRepository.GetMatchingRecipes(_ingredientsData, searchParameters);
        }

        public void SearchForDailyMenus(MenuRepository menuRepository, List<string> searchParameters)
        {
            _menusData = menuRepository.GetMatchingDailyMenus(_recipesData, searchParameters);
        }




        public Dictionary<string, string> ResultRecipeData
        {
            get { return _recipesData; }
            set { _recipesData = value; }
        }

        public List<string> ResultIngredientData
        {
            get {return _ingredientsData; }
            set { _ingredientsData = value; }
        }

        public List<string> ResultMenuData
        {
            get { return _menusData; }
            set { _menusData = value; }
        }
    }
}
