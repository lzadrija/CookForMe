using System;
using System.Collections.Generic;
using System.Linq;

namespace CookForMe.Model
{
    public class Recipe
    {
        private readonly String                     _name;

        private readonly Dictionary<String, String> _ingredients;
        private String                              _preparation;

        private List<Photo>                         _images;



        public Recipe(String name, Dictionary<String, String> ingredients, String preparation)
        {
            if (IsNameEmpty(name))
            {
                throw new ParemeterEmptyException();
            }
            if (IsIngredientListEmpty(ingredients))
            {
                throw new ParemeterEmptyException();
            }
            if (IsPreparationTextEmpty(preparation))
            {
                throw new ParemeterEmptyException();
            }

            _name = name;
            Id = generateID();

            _ingredients = ingredients;
            _preparation = preparation;

            _images = new List<Photo>();
        }

        public Recipe(String name, Dictionary<String, String> ingredients, String preparation, List<Photo> images)
        {
            if (IsNameEmpty(name))
            {
                throw new ParemeterEmptyException();
            }
            if (IsIngredientListEmpty(ingredients))
            {
                throw new ParemeterEmptyException();
            }
            if (IsPreparationTextEmpty(preparation))
            {
                throw new ParemeterEmptyException();
            }
            _name = name;
            Id = generateID();

            _ingredients = ingredients;
            _preparation = preparation;

            _images = images;
        }





        public int GetNumberOfMatchingFoods(List<String> foodsNameList)
        {
            return foodsNameList.Count(ContainsFood);
        }

        public bool ContainsFood(String foodName)
        {
            return _ingredients.ContainsKey(foodName);
        }

        public Dictionary<String, String>.KeyCollection GetAllFoodFromIngredients()
        {
            return _ingredients.Keys;
        }

        public List<String> GetIngredientsList()
        {
            return _ingredients.Keys.Select(foodName => foodName + ", " + _ingredients[foodName]).ToList();
        }


        public void AddImage (Photo image)
        {
            _images.Add(image);
        }

        public List<String> GetImagesFilenames()
        {
            return _images.Select(photo => photo.Filename).ToList();
        }

        public List<String> GetImagesFilenamesShort()
        {
            return _images.Select(image => Photo.GetShortFileName(image.Filename)).ToList();
        }

        public Photo GetImage(String fileName)
        {
            return _images.FirstOrDefault(photo => String.Compare(photo.Filename, fileName, StringComparison.Ordinal) == 0);
        }

        public Photo GetImageFromSortFilename(String fileNameShort)
        {
            foreach (var image in _images.Where(image => image.Filename.Contains(fileNameShort)))
            {
                return image;
            }
            throw new ItemNotFoundException();
        }

        public String Name
        {
            get { return _name; }
        }

        public List<Photo> Images
        {
            get { return _images; }
            set { _images = value; }
        }

        public Dictionary<String, String> Ingredients
        {
            get { return _ingredients; }
        }

        public String Preparation
        {
            get { return _preparation; }
            set { 
                if (IsPreparationTextEmpty(value))
                {
                    throw new ParemeterEmptyException();
                }
                _preparation = value; 
            }
        }

        public string Id { get; set; }


        private static bool IsNameEmpty(String name)
        {
            return name.Equals("");
        }

        private static bool IsPreparationTextEmpty(String text)
        {
            return text.Equals("");
        }

        private static bool IsIngredientListEmpty(Dictionary<String, String> ingredients)
        {
            return ingredients.Count == 0;
        }

        public bool IsDataPartOfName(String data)
        {
            return (_name.IndexOf(data, 0, StringComparison.CurrentCultureIgnoreCase) != -1);
        }

        public bool ContainsFoods(List<string> foodsNamesToCheck)
        {
            var foodsNames = _ingredients.Keys.ToList();

            return foodsNamesToCheck.Select(foodsNames.Contains).FirstOrDefault(matching => matching);
        }



        private String generateID()
        {
            return Guid.NewGuid().ToString();
        }




        public override bool Equals(Object obj)
        {
            // If searchParameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If searchParameter cannot be cast to Item return false.
            var secondMeal = obj as Recipe;
            if (secondMeal == null)
            {
                return false;
            }

            // Return true if the fields match
            return String.Compare(Id, secondMeal.Id, StringComparison.Ordinal) == 0;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
