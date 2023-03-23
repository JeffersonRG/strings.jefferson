using System;

namespace strings_jefferson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Askes user to input a character and assigns input to a variable
            Console.WriteLine("Please input a character!");
            char myChar = Console.ReadKey().KeyChar;
            
            // Checks if the character user entered is a letter
            bool isLetter = Char.IsLetter(myChar);
            
            // Prints the results to console
            Console.WriteLine($"\n{myChar} is a letter: {isLetter}.");
            
            // Asks user a question and saves response to a variable, sentence
            Console.WriteLine("Why do you like video games?");
            string sentence = Console.ReadLine();
            
            // Asks user to enter a word, saves response to a variable called word
            Console.WriteLine("Enter a word");
            string Word = Console.ReadLine();
            
            // Checks if the word is in the sentance
            bool isIn = sentence.Contains(Word);

            // Prints if the word is in the sentance
            Console.WriteLine($"{Word} exists in {sentence}, {isIn}!");
        }
    }
}
