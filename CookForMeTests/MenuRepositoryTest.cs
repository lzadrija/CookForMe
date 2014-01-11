using System;
using System.Collections.Generic;
using System.Linq;
using CookForMe.Model;
using CookForMe.Model.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CookForMeTests
{
    [TestClass]
    public class MenuRepositoryTest
    {
        [TestMethod]
        public void Test_AddingOneMenu()
        {
            MenuRepository repository = MenuRepository.GetInstance();
            Dictionary<String, List<String>> menusForRecipesMap = new Dictionary<string, List<string>>();
            string mealName = "Dinner";
            List<string> recipes = new List<string>();

            menusForRecipesMap[mealName] = recipes;

            repository.AddNewDailyMenu("Sunday's menu", "", menusForRecipesMap);

            Assert.IsTrue(repository.IsMenuDefined("Sunday's menu"));
        }

        [TestMethod]
        public void Test_GetMenuByName()
        {
            MenuRepository repository = MenuRepository.GetInstance();
            Dictionary<String, List<String>> menusForRecipesMap = new Dictionary<string, List<string>>();
            string mealName = "Dinner";
            List<string> recipes = new List<string>();

            menusForRecipesMap[mealName] = recipes;
            repository.AddNewDailyMenu("Heavy menu", "", menusForRecipesMap);
            Assert.AreEqual("Heavy menu", repository.GetMenuByName("Heavy menu").Name);
        }

        [TestMethod]
        [ExpectedException(typeof (ItemAlreadyExistsException))]
        public void Test_AddingSameMenuTwice()
        {
            MenuRepository repository = MenuRepository.GetInstance();
            Dictionary<String, List<String>> menusForRecipesMap = new Dictionary<string, List<string>>();
            string mealName = "Dinner";
            List<string> recipes = new List<string>();

            menusForRecipesMap[mealName] = recipes;
            repository.AddNewDailyMenu("Cold winter's evening menu", "", menusForRecipesMap);
            repository.AddNewDailyMenu("Cold winter's evening menu", "", menusForRecipesMap);
        }

        [TestMethod]
        public void Test_MenuExists()
        {
            MenuRepository repository = MenuRepository.GetInstance();
            Dictionary<String, List<String>> menusForRecipesMap = new Dictionary<string, List<string>>();
            string mealName = "Dinner";
            List<string> recipes = new List<string>();

            menusForRecipesMap[mealName] = recipes;
            repository.AddNewDailyMenu("Quick and easy-to-make menu for cold winter evenings", "",
                                       menusForRecipesMap);
            Assert.IsTrue(repository.IsMenuDefined("Quick and easy-to-make menu for cold winter evenings"));
        }
    }
}