﻿using SebastiansDictionary_Library;
using System;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;

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
        private static void GenericDelegates(int someNumber, Action<string> someText)
        {
            Console.WriteLine("Varför har du ingen biff!?");
        }
        static void Main(string[] args)
        {
            //Hämtar sökvägen för applocal hos användaren. Skapar mapp om den inte finns. 
            AppLocalPath();

            WordList wordForPractice = WordList.LoadList("SebastiansLista");
        
            wordForPractice.Remove(0, "Cresant");

            wordForPractice.Save();

            wordForPractice.GetWordToPractice();
            //loadedList.Remove(0, "Car");
    
            /*
             * int number = 5;
             * Action<int> numberTrick = (numberInput) =>
            {
                while (numberInput < 100)
                {
                    numberInput *= 2;
                    Console.WriteLine($"Your number is right now {numberInput}");
                }
            };

            numberTrick(number);
            GenericDelegates(number, theText);*/

            //Test2.Add("Bil", "Car", "Auto");
            //Test2.Add("Pojke", "Boy", "Garcon");
            //Test2.Add("Flicka", "Girl", "Fille");
            //Test2.Save();
            //Test2.Count();
            // foreach (string word in wordsToRemove)
            // {
            //     Test2.Remove(0, word);
            // }
            
            

           // Test2.Save();
            
            Console.ReadKey(true);
        }
            //För att lägga till ord, en for som sträcker sig längden av languages.
            //lägg till en array av ord åt gången, inte ett ord i taget. 
    }
}
