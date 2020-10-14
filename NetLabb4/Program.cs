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

            WordList.GetList();
            foreach (string i in WordList.GetList())
            {
                Console.WriteLine(Path.GetFileNameWithoutExtension(i));
            }

            //WordList test2 = new WordList("Test2", "Engelska", "Svenska");
            //string[] testWords = { "Car", "bil" };
            //string[] testwords2 = { "Boy", "pojke" };
            //test2.Add(testWords);
            //test2.Add(testwords2);
            //test2.Save();


            //Switch-statement för argumenten som skrivs in.


            Console.ReadKey(true);
        }
    }
}
