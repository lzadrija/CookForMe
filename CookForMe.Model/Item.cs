using System;

namespace CookForMe.Model
{
    public abstract class Item
    {
// ReSharper disable InconsistentNaming
        protected String name;
// ReSharper restore InconsistentNaming
// ReSharper disable InconsistentNaming
        protected String description;
// ReSharper restore InconsistentNaming


        protected Item(String name, String description)
        {
            if (IsNameEmpty(name))
            {
                throw new ParemeterEmptyException();
            }
            this.name = name;
            this.description = description;
        }




        public bool IsDataPartOfName(String data)
        {
            return (name.IndexOf(data, 0, StringComparison.CurrentCultureIgnoreCase) != -1);
        }


        public bool IsDataEqualToNameIgnoreCase(String data)
        {
            return (string.Equals(name, data, StringComparison.OrdinalIgnoreCase));
        }


        public String Name
        {
            get { return name; }
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }



        private static bool IsNameEmpty(String name)
        {
            return name.Equals("");
        }



        public override bool Equals(Object obj)
        {
            // If searchParameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If searchParameter cannot be cast to Item return false.
            var secondMeal = obj as Item;
            if (secondMeal == null)
            {
                return false;
            }

            // Return true if the fields match
            return String.Compare(Name, secondMeal.Name, StringComparison.Ordinal) == 0;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
