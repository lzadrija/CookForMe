using CookForMe.Model;
using CookForMe.Model.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CookForMeTests
{
    [TestClass]
    public class FoodsRepositoryTest
    {
        [TestMethod]
        public void Test_AddingOneFood()
        {
            FoodRepository repository = FoodRepository.GetInstance();
            repository.AddFood("Blueberry", "Fruit", "b", 100, 1.0, 1.0, 1.0);

            Assert.IsTrue(repository.IsFoodDefined("Blueberry"));
        }

        [TestMethod]
        public void Test_GetFoodByName()
        {
            FoodRepository repository = FoodRepository.GetInstance();
            repository.AddFood("Water", "Drink", "b", 100, 1.0, 1.0, 1.0);
            Assert.AreEqual("Water", repository.GetFoodByName("Water").Name);
        }

        [TestMethod]
        [ExpectedException(typeof(ItemAlreadyExistsException))]
        public void Test_AddingSameFoodTwice()
        {
            FoodRepository repository = FoodRepository.GetInstance();
            repository.AddFood("Cornstarch", "Cereal products", "b", 100, 1.0, 1.0, 1.0);
            repository.AddFood("Cornstarch", "Cereal products", "b", 100, 1.0, 1.0, 1.0);
        }

        [TestMethod]
        public void Test_FoodExists()
        {
            FoodRepository repository = FoodRepository.GetInstance();
            repository.AddFood("Strawberry", "Fruit", "b", 100, 1.0, 1.0, 1.0);
            Assert.IsTrue(repository.IsFoodDefined("Strawberry"));
        }
    }
}
