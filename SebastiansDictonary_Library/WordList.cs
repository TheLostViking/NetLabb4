﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

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

        //Sätter properties Name och Languages till parametrarnas värden.
        public WordList(string name, params string[] languages) 
        {
            Name = name;
            Languages = languages;
        }
        //Metoder

        //Returnerar array med namn på alla listor som finns lagrade (utan filändelser). //KLAR!
        public static string[] GetList()
        {
            string[] allLists = Directory.GetFiles(filePath);
            return allLists;
        }

        //KLAR! Laddar in ordlistan (name anges utan filändelse) och returnerar som WordList.
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
                        sw.Write(language.ToLower() + ";");
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
                        sw.Write(translations?.ToLower() + ";");
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

        //translation motsvarar index i Languages. Sök igenom språket och ta bort ordet. //KLAR!
        public bool Remove(int translation, string word)
        {
            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Translations.Contains(word))
                {
                    words.RemoveAt(i);
                }
            }
            return true;
        }
        
        //Räknar och returnerar alla ord i listan. //KLAR!
        public int Count()
        {
            int wordsInList = 0;
            foreach (var word in words)
            {
                wordsInList++;
            }
            return wordsInList;
        }

        //sortByTranslation = Vilket språk listan sorteras på.
        //showTranslations = Callback som anropas för varje ord i listan. 
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            List<Word> sortedWords =  words.OrderBy(word => word.Translations[sortByTranslation]).ToList();

                foreach (Word word in sortedWords)
                {
                    showTranslations(word.Translations);
                }
             
        }
        //Returnerar slumpmässigt Word från listan, med slumpmässigt valda FromLanguage och ToLanguage(dock inte samma). //KLAR!
        public Word GetWordToPractice()
        {
            Random rnd = new Random();

            int fromLanguage = rnd.Next(0, Languages.Length);
            int toLanguage = rnd.Next(0, Languages.Length);

            int randomWord = rnd.Next(words.Count);
            Word word = words[randomWord];

            while (fromLanguage == toLanguage)
            {
                toLanguage = rnd.Next(0, Languages.Length);
            }
                          
            Word wordToPractice = new Word(fromLanguage, toLanguage, word.Translations);
            return wordToPractice;
        }
    }
}
    



