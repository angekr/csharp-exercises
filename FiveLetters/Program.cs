using System;
using System.Collections.Generic;

namespace FiveLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> wordlist = new List<string>(){"hello", "goodbye", "hola", "adios", "hallo", "adieu","sayonara" };
            PrintFiveLetWords(wordlist);
            Console.ReadLine();

        }
        private static void PrintFiveLetWords(List<string> words)
        {
            for (int i=0; i < words.Count; i++)
            {
                if (words[i].Length == 5)
                {
                    Console.WriteLine(words[i]);
                }
               
            }
            return;
        }
    }
}
