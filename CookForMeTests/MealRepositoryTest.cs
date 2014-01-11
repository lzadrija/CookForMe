using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CookForMe.Model;
using CookForMe.Model.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CookForMeTests
{
    [TestClass]
    public class MealRepositoryTest
    {
        [TestMethod]
        public void Test_AddingOneMeal()
        {
            MealRepository repository = MealRepository.GetInstance();
            repository.AddEmptyMeal("Strawberry Cake Filling", "");

            Assert.IsTrue(repository.IsMealDefined("Strawberry Cake Filling"));
        }

        [TestMethod]
        public void Test_GetMealByName()
        {
            MealRepository repository = MealRepository.GetInstance();
            repository.AddEmptyMeal("A Good Easy Garlic Chicken", "");
            Assert.AreEqual("A Good Easy Garlic Chicken", repository.GetMealByName("A Good Easy Garlic Chicken").Name);
        }

        [TestMethod]
        [ExpectedException(typeof (ItemAlreadyExistsException))]
        public void Test_AddingSameMealTwice()
        {
            MealRepository repository = MealRepository.GetInstance();
            repository.AddEmptyMeal("Onion-Roasted Potatos", "");
            repository.AddEmptyMeal("Onion-Roasted Potatos", "");
        }

        [TestMethod]
        public void Test_MealExists()
        {
            MealRepository repository = MealRepository.GetInstance();
            repository.AddEmptyMeal("Chocolate Mousse", "");
            Assert.IsTrue(repository.IsMealDefined("Chocolate Mousse"));
        }
    }
}