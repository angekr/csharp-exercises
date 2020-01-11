using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> countChars = new Dictionary<char, int>();

            //This was to test the hard coded string
            string str2 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin.Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat.Donec sit amet suscipit metus, non lobortis massa.Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            //This line would take the input from the user
            Console.WriteLine("Enter a string to evaluate:");
            string str = Console.ReadLine();
            Console.WriteLine(str);

            //This line added to make it case-insensitive
            str = str.ToLower();

            //This loop iterates each letter of the string
            for (int i = 0; i < str.Length; i++)
            {
                int cal = 0;

                //This nested loop compares the current (i) letter to every other letter in the string
                for (int j = i; j < str.Length; j++)
                {
                    //adds one to the count if there is a match, but also makes sure there is not already a count for that letter
                    if (str[i] == str[j] && countChars.ContainsKey(str[j]) == false)
                    {
                        cal++;
                    }

                }

                //If there isnt already a count for this character, then creates a key/value pair for the dictionary
                if (countChars.ContainsKey(str[i])== false)
                {
                    countChars.Add(str[i], cal);
                }
            }
            Console.WriteLine("Here are your results:");
            foreach(KeyValuePair<char,int> countChar in countChars)
            {
                Console.WriteLine(countChar.Key + " : " + countChar.Value);
            }

          
            Console.ReadLine();
        }
    }
}
