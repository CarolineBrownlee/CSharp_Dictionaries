using System;
using System.Collections.Generic;

namespace Common_Types_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // ===== Practice:  Dictionary of Words =====
            /*
                Create a dictionary with key value pairs to
                represent words (key) and its definition (value)
            */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>() {

                {"software engineer", "someone who writes software"},
                {"family", "a collection of individuals who love each other"},
                {"mother", "a woman who takes care of her children"}

            };

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Travel", "To go away on an adventure to exerience new things");
            wordsAndDefinitions.Add("Potty Train", "Mental exhaustion teaching a toddler to use the bathroom");
            wordsAndDefinitions.Add("Love", "Taking care of what matters the most and doing the right thing");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */

                Console.WriteLine(wordsAndDefinitions["Love"]);
                Console.WriteLine(wordsAndDefinitions["Potty Train"]);
            
            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}.");
            }

            // ===== Practice:  List of Dictionaries About Words =====
        }
    }
}
