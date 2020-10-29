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
        private static void GenericDelegates(int someNumber, Action<string> someText)
        {
            Console.WriteLine("Varför har du ingen biff!?");
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
                    WordList newList = new WordList();
                    newList.Save();
                    newList.Add();
                    break;

                case "-add":
                    break;

                case "-remove":
                    WordList.LoadList(args[1]);
                    
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
                            if (language == listToSort.Languages[i])
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
                    WordList.LoadList(args[1]).Count();
                    break;

                case "-practice":
                    WordList.LoadList(args[1]).GetWordToPractice();
                    break;
            }


            Console.ReadKey(true);
        }
    }
}

