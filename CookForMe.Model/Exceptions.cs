using System;

namespace CookForMe.Model
{
    public abstract class CustomException : Exception
    {
        private readonly string _msg;

        protected CustomException(string msg)
        {
            _msg = msg;
        }

        public string GetMessage
        {
            get {return _msg;}
        }
    }

    [Serializable]
    public class PhotoFilenameDoesntExistException : CustomException
    {
        public PhotoFilenameDoesntExistException(String msg)
            : base(msg)
        {
        }
    }

    [Serializable]
    public class PhotoNotUploadedException : Exception
    {
    }

    [Serializable]
    public class ParemeterNegativeOrZeroException : CustomException
    {
        public ParemeterNegativeOrZeroException(String msg)
            : base(msg)
        {
        }
    }

    [Serializable]
    public class InvalidNutritionFactAmountException : CustomException
    {
        public InvalidNutritionFactAmountException(String msg)
            : base(msg)
        {
        }
    }

    [Serializable]
    public class ParemeterEmptyException : Exception
    {
    }

    [Serializable]
    public class MenuNotValidException : Exception
    {
    }

    [Serializable]
    public class MealNotValidException : Exception
    {
    }

    [Serializable]
    public class TryRemoveLastIngredientException : Exception
    {
    }

    [Serializable]
    public class ItemAlreadyExistsException : Exception
    {
    }

    [Serializable]
    public class ItemNotFoundException : Exception
    {
    }

    [Serializable]
    public class InvalidIndexException : Exception
    {
    }

    [Serializable]
    public class InvalidNumberEntryException : Exception
    {
    }
}
