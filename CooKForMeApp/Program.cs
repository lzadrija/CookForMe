using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

using CookForMe.Controllers;
using CookForMe.Model;
using CookForMe.Model.Repositories;

namespace CookForMeApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var mainWindowController = new MainWindowController();

            FillFoodRepositoryWithData();
            FillMealRepositoryWithData();
            FillMenuRepositoryWithData();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMainWindow(mainWindowController));
        }




        private static void FillFoodRepositoryWithData()
        {
            var repository = FoodRepository.GetInstance();
            var reader = File.OpenText("testData/testDataFood.txt");
            var line = reader.ReadLine();

            // ReSharper disable PossibleNullReferenceException
            while (line != null)
            {
                if (string.Equals(line.Trim(), "New item", StringComparison.OrdinalIgnoreCase))
                {
                    line = reader.ReadLine();
                    if (line != null && line.Trim().IndexOf("Picture", 0, StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        var pictureData = line.Split('_');

                        string name = reader.ReadLine().Trim(), foodType = reader.ReadLine().Trim();

                        var nutritionFacts = reader.ReadLine().Trim().Split(' ');
                        var description = reader.ReadLine().Trim();

                        repository.AddFoodWithPicture(name, description, foodType, Convert.ToInt32(nutritionFacts[1]),
                                                      Convert.ToDouble(nutritionFacts[0]), Convert.ToDouble(nutritionFacts[2]),
                                                      Convert.ToDouble(nutritionFacts[3]), pictureData[1], pictureData[3]);
                    }
                    else
                    {
                        if (line != null)
                        {
                            string name = line.Trim(), foodType = reader.ReadLine().Trim();
                            var nutritionFacts = reader.ReadLine().Trim().Split(' ');
                            var description = reader.ReadLine().Trim();

                            repository.AddFood(name, description, foodType, Convert.ToInt32(nutritionFacts[1]),
                                               Convert.ToDouble(nutritionFacts[0]), Convert.ToDouble(nutritionFacts[2]),
                                               Convert.ToDouble(nutritionFacts[3]));
                        }
                    }
                }
                line = reader.ReadLine();
            }
            reader.Close();
        }

        private static void FillMealRepositoryWithData()
        {
            var repository = MealRepository.GetInstance();
            var hasPicture = false;
            var photoData = new Dictionary<string, string>();
            var ingredients = new Dictionary<string, string>();

            var reader = File.OpenText("testData/testDataRecepie.txt");
            var line = reader.ReadLine();
            while (line != null)
            {
                if (string.Equals(line.Trim(), "New item", StringComparison.OrdinalIgnoreCase))
                {
                    var mealsForRecipe = new List<Meal>();

                    line = reader.ReadLine();
                    while (line != null && line.Trim().IndexOf("Picture", 0, StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        hasPicture = true;
                        var pictureData = line.Split('_');
                        photoData[pictureData[1]] = pictureData[3];
                        line = reader.ReadLine();
                    }
                    if (line != null)
                    {
                        var name = line.Trim();
                        var id = reader.ReadLine().Trim();

                        line = reader.ReadLine().Trim();

                        while (line.IndexOf("Ingredients", 0, StringComparison.CurrentCultureIgnoreCase) == -1)
                        {
                            var mealDescription = "";
                            string mealName;
                            if (line.Contains('_'))
                            {
                                var mealData = line.Split('_');
                                mealName = mealData[0];
                                mealDescription = mealData[1];
                            }
                            else
                            {
                                mealName = line;
                            }

                            var meal = repository.GetMealByName(mealName) ??
                                       repository.AddEmptyMeal(mealName, mealDescription);

                            mealsForRecipe.Add(meal);

                            line = reader.ReadLine().Trim();
                        }

                        var ingredientsData = reader.ReadLine().Trim().Split(',');
                        foreach (var ingredientParts in ingredientsData.Select(ingredient => ingredient.Trim().Split('_')))
                        {
                            ingredients[ingredientParts[0]] = ingredientParts[1];
                        }

                        var preparation = reader.ReadLine().Trim();

                        var recipe = new Recipe(name, ingredients, preparation) { Id = id };

                        if (hasPicture)
                        {
                            var data = photoData;
                            var photos = photoData.Keys.Select(photoName => new Photo(photoName, data[photoName])).ToList();
                            recipe.Images = photos;

                            foreach (var meal in mealsForRecipe)
                            {
                                meal.AddRecepie(recipe);
                            }
                        }
                        else
                        {
                            foreach (var meal in mealsForRecipe)
                            {
                                meal.AddRecepie(recipe);
                            }
                        }
                    }
                }
                photoData = new Dictionary<string, string>();
                ingredients = new Dictionary<string, string>();
                hasPicture = false;
                line = reader.ReadLine();
            }
            reader.Close();
        }

        private static void FillMenuRepositoryWithData()
        {
            var repository = MenuRepository.GetInstance();
            var reader = File.OpenText("testData/testDataDailyMenu.txt");
            var line = reader.ReadLine();
            while (line != null)
            {
                if (!string.Equals(line.Trim(), "New item", StringComparison.OrdinalIgnoreCase)) continue;

                string name = reader.ReadLine().Trim(), description = reader.ReadLine().Trim();

                var menusForRecipesMap = new Dictionary<String, List<String>>();

                line = reader.ReadLine();
                while (!string.Equals(line.Trim(), "New item", StringComparison.OrdinalIgnoreCase))
                {
                    var mealRecipesArray = line.Split('_');
                    var mealName = mealRecipesArray[0];

                    var recipes = mealRecipesArray[1].Split(',');

                    menusForRecipesMap[mealName] = recipes.ToList();
                    line = reader.ReadLine();

                    if (null == line)
                    {
                        break;
                    }
                }
                repository.AddNewDailyMenu(name, description, menusForRecipesMap);
            }
        }
    }
}
