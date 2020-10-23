using SebastiansDictionary_Library;
using System;
using System.IO;
using System.Net.Http.Headers;

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

            if (args.Length == 0)
            {
                Console.WriteLine($"Use any of the following parameters: \n" +
                    $"-lists \n" +
                    $"-new <list name> <language 1> <language 2>... <language n> \n" +
                    $"-add <list name> \n" +
                    $"-remove <list name> <language> <word 1> <word 2>... <word n> \n" +
                    $"-count <list name> \n" +
                    $"-practice <list name>");
            }
            else
            {
                switch (args[0])
                {
                    case "-lists":

                        foreach (var item in WordList.GetList())
                        {
                            Console.WriteLine(Path.GetFileNameWithoutExtension(item));
                        }
                        break;

                    case "-new":

                        break;
                    case "-add":
                        WordList.LoadList(args[1]).Add();
                        break;
                    case "-remove":
                        WordList.LoadList(args[1]).Remove(int.Parse(args[2]), args[3]);
                        break;
                    case "-words":
                        WordList listToSort = WordList.LoadList(args[1]);
                        string language = args[2];
                        int langIndex = 0;

                        for (int i = 0; i < listToSort.Languages.Length; i++)
                        {
                            if (language == listToSort.Languages[i])
                            {
                                langIndex = i;
                                break;
                            }
                        }

                        for (int i = 0; i < listToSort.Languages.Length; i++)
                        {
                            Console.Write($"{listToSort.Languages[i],-10}");
                        }

                        Console.WriteLine();
                        int newColumn = 0;
                        Action<string[]> sortedWords = (input) =>
                        {
                            if (newColumn == listToSort.Languages.Length)
                            {
                                Console.WriteLine();
                                newColumn = 0;
                            }

                            for (int i = 0; i < input.Length; i++)
                            {
                                newColumn++;
                                Console.Write($"{input[i], -10}");
                            }
                        };
                        listToSort.List(langIndex, sortedWords);
                        break;
                    case "-count":
                        Console.WriteLine(WordList.LoadList(args[1]).Count());
                        break;

                    case "-practice":
                        WordList.LoadList(args[1]).GetWordToPractice();
                        break;
                }
            }

            Console.ReadKey(true);
        }
        // Args 0 = det första argumentet, t.ex "-lists", "-new" osv.
        //Sen hantera args som den array det är och nyttja de kommande inputsen för att definera exakt vad som händer.
    }
}
