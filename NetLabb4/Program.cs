using SebastiansDictionary_Library;
using System;
using System.IO;

namespace SebastiansDictionary
{
    class Program
    {
        private static string AppLocalPath()
        {
            string appLocalPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appPath = Path.Combine(appLocalPath, "SebastiansDictionary");
            if (!Directory.Exists(appPath))
            {
                Directory.CreateDirectory(appPath);
            }
            return appPath;
        }
        static void Main(string[] args)
        {
            //Hämtar sökvägen för applocal hos användaren. Skapar mapp om den inte finns. 
            AppLocalPath();

            WordList loadedList = WordList.LoadList("Test2");
            //För att lägga till ord, en for som sträcker sig längden av languages.
            //lägg till en array av ord åt gången, inte ett ord i taget. 
            loadedList.Remove(0, "Car");
            
            Console.ReadKey(true);
        }
    }
}
