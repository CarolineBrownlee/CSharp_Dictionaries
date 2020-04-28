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

            // Console.WriteLine(wordsAndDefinitions["Love"]);
            // Console.WriteLine(wordsAndDefinitions["Potty Train"]);

            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            // foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            // {
            //     Console.WriteLine($"The definition of {word.Key} is {word.Value}.");
            // }

            // ===== Practice:  List of Dictionaries About Words =====

            // Make a new list
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            /*
                You want to track the following about each word:
                    word, definition, part of speech, example sentence

                Example of one dictionary in the list:
                {
                    "word": "excited",
                    "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
                    "part of speech": "adjective",
                    "example sentence": "I am excited to learn C#!"
                }
            */

            // Create dictionary to represent a few words
            Dictionary<string, string> excitedWord = new Dictionary<string, string>();

            // // Add each of the 4 bits of data about the word to the Dictionary
            excitedWord.Add("word", "Extraordinary");
            excitedWord.Add("definition", "Something better than ordinary.");
            excitedWord.Add("part of speech", "adjective");
            excitedWord.Add("example sentence", "That child is extraordinary!");

            // Add Dictionary to your `dictionaryOfWords` list
            dictionaryOfWords.Add(excitedWord);

            // create another Dictionary and add that to the list
            Dictionary<string, string> optimisticWord = new Dictionary<string, string>();

            optimisticWord.Add("word", "Positivity");
            optimisticWord.Add("definition", "Looking on the bright side of things.");
            optimisticWord.Add("part of speech", "noun");
            optimisticWord.Add("example sentence", "Her positivity got her through school.");

            dictionaryOfWords.Add(optimisticWord);

            /*
                Iterate your list of dictionaries and output the data, You can use the two foreach() loops below to help you start your iteration.

                Example output for one word in the list of dictionaries:
                    word: excited
                    definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
                    part of speech: adjective
                    example sentence: I am excited to learn C#!
            */

            // Iterate the List of Dictionaries
            // foreach (Dictionary<string, string> word in dictionaryOfWords)
            // {
            //     // Iterate the KeyValuePairs of the Dictionary
            //     foreach (KeyValuePair<string, string> wordData in word)
            //     {
            //         Console.WriteLine($"{wordData.Key}: {wordData.Value}");
            //     }
            // }

            // ===== Practice:  English Idioms =====
            Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();

            idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
            idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
            idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
            idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
            idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
            idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
            idioms.Add("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
            idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
            idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
            idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });

           
            // Iterate the KeyValuePairs of the Dictionary
            foreach (KeyValuePair<string, List<string>> idiom in idioms)
            {
                Console.WriteLine($"{idiom.Key}: {String.Join(" ", idiom.Value)}.");
            }
           
        }
    }
}
