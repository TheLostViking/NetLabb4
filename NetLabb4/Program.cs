using SebastiansDictionary_Library;
using System;
using System.Collections.Generic;
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
        private static string FirstToUpper(string text)
        {
            return text.Substring(0, 1).ToUpper() + text.Substring(1);
        }

        private static void NewList(string[] args)
        {
            List<string> langList = new List<string>();
            for (int i = 2; i < args.Length; i++)
            {
                langList.Add(args[i]);
            }
            string[] languages = langList.ToArray();

            WordList newList = new WordList(args[1], languages);
            newList.Save();
            AddWords(args);
        }
        private static void AddWords(string[] args)
        {
            Console.WriteLine("Press enter with an empty line to exit!");
            WordList addWords = WordList.LoadList(args[1]);

            int numberOfWordsAdded = 0;
            string userInput = "";
            List<string> listOfWords = new List<string>();
            bool t = true;
            while (t == true)
            {
                for (int i = 0; i < addWords.Languages.Length; i++)

                {
                    if (i == 0)
                    {
                        Console.Write($"Enter a word ({FirstToUpper(addWords.Languages[i])}): ");
                        userInput = Console.ReadLine();
                        if (userInput == "")
                        {
                            t = false;
                            break;
                        }
                        listOfWords.Add(userInput);

                    }
                    else if (i > 0)
                    {
                        Console.Write($"Enter the ({FirstToUpper(addWords.Languages[i])}) translation: ");
                        userInput = Console.ReadLine();
                        if (userInput == "")
                        {
                            t = false;
                            break;
                        }
                        listOfWords.Add(userInput);
                    }
                }
                if (t == false)
                {
                    break;
                }
                else
                {
                    numberOfWordsAdded++;
                    string[] addedWords = listOfWords.ToArray();
                    listOfWords.Clear();
                    addWords.Add(addedWords);
                    addWords.Save();
                }
            }
            if (numberOfWordsAdded == 1)
            {
                Console.WriteLine($"{numberOfWordsAdded} word was added to the list!");
            }
            else
                Console.WriteLine($"{numberOfWordsAdded} words was added to the list!");

        }
        static void Main(string[] args)
        {
            //Hämtar sökvägen för applocal hos användaren. Skapar mapp om den inte finns. 
            AppLocalPath();
            if (args.Length == 0)
            {
                Console.WriteLine($"Use any of the following parameters:\n" +
                    $"-lists \n" +
                    $"-new < list name > < language 1 > < language 2 > .. < langauge n >\n" +
                    $"-add < list name >\n" +
                    $"-remove < list name > < language > < word 1 > < word 2 > .. < word n >\n" +
                    $"-words < listname > < sortByLanguage >\n" +
                    $"-count < listname >\n" +
                    $"-practice < listname >");
                return;
            }
            
            switch (args[0])
            {
                case "-lists":
                    WordList.GetList();
                    foreach (var item in WordList.GetList())
                    {
                        Console.WriteLine(Path.GetFileNameWithoutExtension(item));
                    }
                    break;

                case "-new":

                    NewList(args);
                    break;

                case "-add":

                    AddWords(args);
                    break;

                case "-remove":
                    WordList removeWords = WordList.LoadList(args[1]);
                    int translation = 0;
                    for (int i = 0; i < removeWords.Languages.Length; i++)
                    {
                        if (args[2] == removeWords.Languages[i])
                        {
                            translation = i;
                        }
                    }

                    List<string> removeList = new List<string>();
                    for (int i = 3; i < args.Length; i++)
                    {
                        removeList.Add(args[i]);
                    }
                    string[] wordsToRemove = removeList.ToArray();

                    foreach (var item in wordsToRemove)
                    {
                        removeWords.Remove(translation, item);
                    }

                    removeWords.Save();
                    Console.WriteLine($"{wordsToRemove.Length} words were removed from the list!");
                    break;

                case "-words":
                    {
                        WordList listToSort = WordList.LoadList(args[1]);
                        string language = "";
                        if (args.Length == 3)
                        {
                            language = args[2];
                        }
                        else if (args.Length == 2)
                        {
                            language = listToSort.Languages[0];
                        }
                        int languageIndex = 0;

                        for (int i = 0; i < listToSort.Languages.Length; i++)
                        {
                            if (language.ToLower() == listToSort.Languages[i])
                            {
                                languageIndex = i;
                                break;
                            }
                        }

                        int nextColumn = 0;

                        for (int i = 0; i < listToSort.Languages.Length; i++)
                        {
                            Console.Write($"{listToSort.Languages[i].ToUpper(),-20}");
                        }
                        Console.WriteLine();

                        Action<string[]> sortList = (input) =>
                        {
                            if (nextColumn == listToSort.Languages.Length)
                            {
                                Console.WriteLine();
                                nextColumn = 0;
                            }

                            for (int i = 0; i < input.Length; i++)
                            {
                                nextColumn++;
                                Console.Write($"{input[i],-20}");
                            }
                        };

                        listToSort.List(languageIndex, sortList);
                    }
                    break;

                case "-count":
                    Console.WriteLine($"There are {WordList.LoadList(args[1]).Count()} words in this list!");
                    break;

                case "-practice":
                    WordList practiceList = WordList.LoadList(args[1]);

                    int totalAnswers = 0;
                    int correctAnswers = 0;
                    string userInput = "";

                    do
                    {
                        Word word = practiceList.GetWordToPractice();
                        Console.WriteLine($"Translate the {FirstToUpper(practiceList.Languages[word.FromLanguage])}" +
                            $" word {FirstToUpper(word.Translations[word.FromLanguage])}" +
                            $" to {FirstToUpper(practiceList.Languages[word.ToLanguage])}: ");
                        userInput = Console.ReadLine().ToLower();

                        if (userInput == word.Translations[word.ToLanguage])
                        {
                            Console.WriteLine("Correct!");
                            totalAnswers++;
                            correctAnswers++;
                        }
                        else if (userInput == "")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That's the wrong answer!");
                            totalAnswers++;
                        }

                    } while (userInput != "");

                    Console.WriteLine($"You got {correctAnswers} correct answers out of {totalAnswers}");
                    break;
            }

            Console.ReadKey(true);
        }
    }
}

