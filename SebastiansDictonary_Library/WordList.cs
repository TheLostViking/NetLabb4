using SebastiansDictonary_Library;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SebastiansDictionary_Library
{
    public class WordList
    {
        public string Name { get; } //Namnet på listan
        public string[] Languages { get; } //Namnen på språken i listan.

        private static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\SebastiansDictionary" + "\\";
        

        //Lista med ord som ska hålla ordning på orden som läggs till i programmet. 
        private List<Word>Words = new List<Word>();
        //Konstruktor
       
        public WordList(string name, params string[] languages) //Sätter properties Name och Languages till parametrarnas värden.
        {            
            Name = name;
            Languages = languages;
        }
        //Metoder
        public static string[] GetList() //Returnerar array med namn på alla listor som finns lagrade (utan filändelser).
        {
            string[] AllLists = Directory.GetFiles(filePath);
            return AllLists;
        }
        public static WordList LoadList(string name)
        {
            //Laddar in ordlistan (name anges utan filändelse) och returnerar som WordList.
            WordList loadList = new WordList(name);
            string loadListName = loadList.Name;
            string[] loadListLanguage = loadList.Languages;

            using (StreamReader sr = new StreamReader(filePath + name + ".dat"))
            {
                sr.ReadLine();
                
            }
       
            return loadList;
        }
        public void Save()
        {   //Sparar listan till en fil med samma namn som listan och filändelse .dat.
            string nameOfFile = Name;
            string listName = nameOfFile + ".dat";

            if (!File.Exists(filePath + listName))
            {
                using (StreamWriter sw = new StreamWriter(filePath + listName))
                {
                    sw.WriteLine();
                }
            }
            
            if (File.Exists(filePath + listName))
            {
                using (StreamWriter sw = new StreamWriter(filePath + listName))
                {
                    foreach (var language in Languages)
                    {
                        sw.Write(language + ";");
                    }
                    sw.WriteLine();
                }
            }
            

            using (StreamWriter sw = new StreamWriter(filePath + listName, true))
            {
                foreach (Word words in Words)
                {
                    foreach (var translations in words.Translations)
                    {
                        sw.Write(translations + ";");
                    }
                    sw.WriteLine();
                }
            }          
            
        }
                
        public void Add(params string[] translations)
        {
            //Lägger till ord på listan. Kasta ArgumentException om det är fel antal translations.
            //Här läggs ord till på <List>Words, så implementera list.add här. 
            Words.Add(new Word(translations));
        }
        /*
             public bool Remove(int translation, string word)
             {
                 //translation motsvarar index i Languages. Sök igenom språket och ta bort ordet. 
             }
             public int Count()
             {
                 //Räknar och returnerar alla ord i listan. 
             }
             public void List(int sortByTranslation, Action<string[]> showTranslations)
             {
                 //sortByTranslation = Vilket språk listan sorteras på.
                 //showTranslations = Callback som anropas för varje ord i listan. 
             }
             public Word GetWordToPractice()
             {
                 //Returnerar slumpmässigt Word från listan, med slumpmässigt valda FromLanguage och ToLanguage(dock inte samma).
             }*/
        
    }
    
}
