using System;
using System.Collections.Generic;
using System.Linq;

namespace WordUnscramber1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueWordUnscramble = true;
            do
            {
                Console.WriteLine("Please enter the option - F for File and M for Manual");
                var option = Console.ReadLine() ?? string.Empty;

                switch (option.ToUpper())
                {
                    case "F":
                        Console.Write("Enter scrambled words file name ");
                        ExecuteScrambleWordsInFileScenerio();
                        break;
                    case "M":
                        Console.Write("Enter scrambled words manually ");
                        ExecuteScrambleWordsManualEntryScenerio();
                        break;
                    default:
                        Console.Write("Option was not recognized");
                        break;
                }

                var continueDecision = string.Empty;
                do
                {
                    Console.WriteLine("Do you want to continue? Y/N");
                    continueDecision = (Console.ReadLine() ?? string.Empty);

                } while (
                    !continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase)
                    && !continueDecision.Equals("N", StringComparison.OrdinalIgnoreCase)
                        );

                continueWordUnscramble = continueDecision.Equals("Y", StringComparison.OrdinalIgnoreCase);

            } while (continueWordUnscramble);
        }

        private static void ExecuteScrambleWordsManualEntryScenerio()
        {
            var manualInput = Console.ReadLine() ?? string.Empty;
            string[] scrambleWords = manualInput.Split(',');
            DisplayMatchUnscrambleWords(scrambleWords);
        }


        private static void ExecuteScrambleWordsInFileScenerio()
        {
            var fileName = Console.ReadLine() ?? string.Empty;
            string[] scrambleWords = _fileReader.Read(fileName);
            DisplayMatchUnscrambleWords(scrambleWords);
        }

        private static void DisplayMatchUnscrambleWords(string[] scrambleWords)
        {
            string[] wordList = _fileReader.Read(wordListFileName);

            List<MatchedWord> matchedWords = wordMatcher.Match();

            if (matchedWords.Any())
            {
                foreach (var matchedWord in matchedWords)
                {

                }
            }
        }
    }
}
