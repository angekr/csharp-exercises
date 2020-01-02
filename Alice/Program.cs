using System;

namespace Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped into the book her sister was reading, " +
                "but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice " +
                "'without pictures or conversation?'";
            string lowerSentence = sentence.ToLower();
            Console.WriteLine(sentence);
            Console.WriteLine(" ");
            Console.WriteLine("What word should I search for?");
            string word = Console.ReadLine();
            bool isInside = lowerSentence.Contains(word.ToLower());
            Console.WriteLine("The word " + word + " is in the sentence: " + isInside);
            Console.ReadLine();
        }
    }
}
