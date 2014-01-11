using System;
using System.Collections.Generic;

using CookForMe.Model;
using CookForMe.Model.Repositories;

namespace CookForMe.Controllers
{
    public class MainWindowController 
    {
        private static FoodRepository      _foodRepository;
        private static MealRepository      _mealRepository;
        private static MenuRepository      _menuRepository;

        private static CalorieCalculator   _calorieCalculator;

        private static SearchEngine        _searchEngine;

        private List<string>               _resultsDailyMenuData,
                                           _resultsIngredientsData;
        private Dictionary<string, string> _resultRecipeData;



        public MainWindowController()
        {
            _foodRepository = FoodRepository.GetInstance();
            _mealRepository = MealRepository.GetInstance();
            _menuRepository = MenuRepository.GetInstance();

            _calorieCalculator = CalorieCalculator.GetInstance();

            _searchEngine = SearchEngine.GetInstance();

            _resultsDailyMenuData = new List<string>();
            _resultsIngredientsData = new List<string>();
            _resultRecipeData = new Dictionary<string, string>();

        }



        //INGREDIENTS------------------------------------------------------------------------------------------------------

        public void ShowIngredients(IShow formShowIngredients)
        {
            _foodRepository.Attach(formShowIngredients);

            formShowIngredients.PresentDialog();

            _foodRepository.Detach(formShowIngredients);
        }

        public Food GetIngredientDetails(String ingredientCategory, String ingredientName)
        {
            return _foodRepository.GetFoodByNameAndType(ingredientName, ingredientCategory);
        }

        public Food GetIngredientDetails(String ingredientName)
        {
            return _foodRepository.GetFoodByName(ingredientName);
        }





        public int CalculateCalories(String amountS, double defaultAmount, int energyValue)
        {
            int result;
            try
            {
                var amount = Convert.ToDouble(amountS);

                result = _calorieCalculator.CalculateEnergyValueForAmount(amount, defaultAmount, energyValue);
            }
            catch (FormatException)
            {
                throw new InvalidNumberEntryException();
            }

            return result;
        }




        public void AddIngredient(IShow formAddIngredient)
        {
            _foodRepository.Attach(formAddIngredient);

            formAddIngredient.PresentDialog();

            _foodRepository.Detach(formAddIngredient);

        }

        public void CreateNewIngredient(String name, String description, String foodType, String energyValueS, 
                                        String amountS, String proteinAmountS, String fatAmountS, String photoFilename, 
                                        String photoCaption)
        {
            if (String.Compare(photoFilename, "", StringComparison.Ordinal) == 0 && 
                            String.Compare(photoCaption, "", StringComparison.Ordinal) != 0)
            {
                throw new PhotoNotUploadedException();
            }

            try
            {
                var energyValue = Convert.ToInt32(energyValueS);
                var amount = Convert.ToDouble(amountS);
                var proteinAmount = Convert.ToDouble(proteinAmountS);
                var fatAmount = Convert.ToDouble(fatAmountS);

                if (String.Compare(photoFilename, "", StringComparison.Ordinal) == 0)
                {
                    _foodRepository.AddFood(name, description, foodType, energyValue, amount,
                                               proteinAmount, fatAmount);
                }
                else
                {
                    _foodRepository.AddFoodWithPicture(name, description, foodType, energyValue, amount,
                                               proteinAmount, fatAmount, photoFilename, photoCaption);
                }
            }
            catch (FormatException)
            {
                throw new InvalidNumberEntryException();
            }
        }
        






        //RECEPIES------------------------------------------------------------------------------------------------------

        public void AddRecepie(IShow formAddRecipe)
        {
            _mealRepository.Attach(formAddRecipe);
            _foodRepository.Attach(formAddRecipe);

            formAddRecipe.PresentDialog();

            _mealRepository.Detach(formAddRecipe);
            _foodRepository.Detach(formAddRecipe);
        }

        public void AddMeal(String mealName, String description)
        {
            _mealRepository.AddEmptyMeal(mealName, description);
        }

        public void CreateNewRecipe(String recipeName, String mealName, int mealIndex,
                                    Dictionary<String, String> ingredients,
                                    String preparation, Dictionary<String, String> photoData)
        {
            if (photoData.Count == 0)
            {
                _mealRepository.AddNewRecipeToMeal(recipeName, mealName, mealIndex, ingredients, preparation);
            }
            else
            {
                _mealRepository.AddNewRecipeWithPicturesToMeal(recipeName, mealName, mealIndex, ingredients, 
                                                                preparation, photoData);
            }
        }


        public void ShowRecipes(IShow formShowRecipes)
        {

            _mealRepository.Attach(formShowRecipes);
            _foodRepository.Attach(formShowRecipes);

            formShowRecipes.PresentDialog();

            _mealRepository.Detach(formShowRecipes);
            _foodRepository.Detach(formShowRecipes);
        }

        public Recipe GetRecipeDetails(String recipeId, String mealName)
        {
            return _mealRepository.GetRecipeForMeal (recipeId, mealName);
        }

        public Recipe GetRecipeDetails(String recipeId)
        {
            return _mealRepository.GetRecipeById(recipeId);
        }






        //DAILY MENUS------------------------------------------------------------------------------------------------------

        public void AddNewDailyMenu(IShow formAddDailyMenu)
        {
            _mealRepository.Attach(formAddDailyMenu);

            formAddDailyMenu.PresentDialog();

            _mealRepository.Detach(formAddDailyMenu);
        }

        public void CreateDailyMenu(String name, String description, 
                                    Dictionary<String, List<String>> mealsForRecipesMap)
        {
            _menuRepository.AddNewDailyMenu(name, description, mealsForRecipesMap);
        }



        public void ShowDailyMenus(IShow formShowDailyMenus)
        {
            _menuRepository.Attach(formShowDailyMenus);

            formShowDailyMenus.PresentDialog();

            _menuRepository.Detach(formShowDailyMenus);
        }

         public void DeleteDailyMenu(String menuName)
        {
            _menuRepository.DeleteDailyMenu(menuName);
        }



        public DailyMenu GetDailyMenu(String menuName)
        {
            var menu = _menuRepository.GetMenuByName(menuName);

            if(null == menu)
            {
                throw new ItemNotFoundException();
            }

            return menu;
        }

        public void UpdateDailyMenu(String menuName, String description, Dictionary<String, List<String>> mealsForRecipesMap)
        {
            _menuRepository.UpdateDailyMenu(menuName, description, mealsForRecipesMap);
        }



        public void CollectDataForMenuGeneration(IShow formGenerateDailyMenu)
        {

            _mealRepository.Attach(formGenerateDailyMenu);
            _foodRepository.Attach(formGenerateDailyMenu);

            formGenerateDailyMenu.PresentDialog();

            _mealRepository.Detach(formGenerateDailyMenu);
            _foodRepository.Detach(formGenerateDailyMenu);
        }

        public Dictionary<String, List<String>> GenerateDailyMenu(Dictionary<String, List<String>> mealsIngredientsSelectionMap,
                                                                  Dictionary<String, int> mealsNumRecipesMap)
        {
            var mealsMatchingRecipesMap = _mealRepository.GetGeneratedDailyMenuData(mealsIngredientsSelectionMap, mealsNumRecipesMap);

            return mealsMatchingRecipesMap;
        }





        //SEARCH----------------------------------------------------------------------------------------------------------------

        public void Search(IShow formSearch)
        {
            _menuRepository.Attach(formSearch);

            formSearch.PresentDialog();

            _menuRepository.Detach(formSearch);
        }

        public void PerformSearch(List<string> categories, String searchParametersString)
        {
            _resultsDailyMenuData = new List<string>();
            _resultsIngredientsData = new List<string>();
            _resultRecipeData = new Dictionary<string, string>();

            _searchEngine.Search(categories, searchParametersString, _foodRepository, _mealRepository, _menuRepository);

           _resultRecipeData = _searchEngine.ResultRecipeData;
           _resultsIngredientsData = _searchEngine.ResultIngredientData;
           _resultsDailyMenuData = _searchEngine.ResultMenuData;
        }


        public Dictionary<string, string> GetResultRecipeData()
        {
            return _resultRecipeData; 
        }

        public List<string> GetResultIngredientData()
        {
            return _resultsIngredientsData;
        }

        public List<string> GetResultMenuData()
        {
            return _resultsDailyMenuData; 
        }
    }
}
