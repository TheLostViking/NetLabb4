using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace SebastiansDictionary_Library
{
    public class WordList
    {
        public string Name { get; } //Namnet på listan
        public string[] Languages { get; } //Namnen på språken i listan.

        private static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\SebastiansDictionary" + "\\";

        //Lista med ord som ska hålla ordning på orden som läggs till i programmet. 
        private List<Word> words = new List<Word>();

        //Konstruktor
        public WordList()
        {

        }
        public WordList(string name, params string[] languages) //Sätter properties Name och Languages till parametrarnas värden.
        {
            Name = name;
            Languages = languages;
        }
        //Metoder

        //Returnerar array med namn på alla listor som finns lagrade (utan filändelser).
        public static string[] GetList()
        {
            string[] AllLists = Directory.GetFiles(filePath);
            return AllLists;
        }

        //EJ KLAR! Laddar in ordlistan (name anges utan filändelse) och returnerar som WordList.
        public static WordList LoadList(string name)
        {
            string[] loadListLanguage;

            using (StreamReader sr = new StreamReader(filePath + name + ".dat"))
            {
                loadListLanguage = sr.ReadLine().TrimEnd(';').Split(';');
                WordList loadList = new WordList(name, loadListLanguage);

                while (!sr.EndOfStream)
                {
                    string[] translations = sr.ReadLine().TrimEnd(';').Split(';');
                    loadList.Add(translations);
                }
                return loadList;
            }
        }

        //KLAR! Sparar listan till en fil med samma namn som listan och filändelse .dat.
        public void Save()
        {
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
                foreach (Word words in words)
                {
                    foreach (var translations in words.Translations)
                    {
                        sw.Write(translations + ";");
                    }
                    sw.WriteLine();
                }
            }
        }

        //KLAR! Lägger till ord på listan. Kasta ArgumentException om det är fel antal translations.
        //Här läggs ord till på <List>Words, så implementera list.add här.
        public void Add(params string[] translations)
        {
            words.Add(new Word(translations));
        }

        //translation motsvarar index i Languages. Sök igenom språket och ta bort ordet. 
        public bool Remove(int translation, string word)
        {
            WordList listToRemoveFrom = LoadList(Name);
            string[] listOfLanguages = listToRemoveFrom.Languages;

            for (int i = 0; i < listOfLanguages.Length; i++)
            {
                if (translation == i)
                {
                    foreach (var item in words)
                    {
                        foreach (var translations in item.Translations)
                        {
                            if (word == translations)
                            {
                                words.Remove(item);
                            }
                        }
                        break;
                    }
                }
            }
            listToRemoveFrom.Save();
            return true;
        }

                
        
    }

}
    /*
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




