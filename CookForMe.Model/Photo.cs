using System;
using System.Linq;

namespace CookForMe.Model
{  
    public class Photo
    {
        private readonly String _filename;


        public Photo(String filename, String caption) 
        {
            _filename = filename;
            Caption = caption;
        }


        public static String GetShortFileName(String filename)
        {
            var fileNameParts = filename.Split('\\');
            return fileNameParts.Last();
        }


        public String Filename
        {
            get { return _filename; }
        }

        public string Caption { get; set; }
    }
}
