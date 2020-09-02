using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace AllTheVowels
{
    class Program
    {
        static void Main()
        {
            var wordListFile = File.ReadAllLines(@"C:\Users\Myke\source\repos\AllTheVowels\words_alpha.txt");
            var currentWordList = new List<string>(wordListFile);

            var newWordList = new List<string>();

            foreach (var word in currentWordList)
            {
                const string vowels = "aeiou";
                var originalWord = word;
                var wordWithOnlyVowels = new string(word.Where(w => vowels.Contains(w)).ToArray());

                if (wordWithOnlyVowels == vowels)
                {
                    newWordList.Add(originalWord);
                }
            }

            Console.WriteLine(newWordList.Count);

            foreach (var word in newWordList)
            {
                Console.WriteLine(word);
            }
        }
    }
}
