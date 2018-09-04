using System;

namespace individual_characters_from_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a short sentence, quote, or string of gibberish: ");
            string quote = Console.ReadLine().ToUpper().Trim();
            //set quote as a string, converted it to all caps, trimmed extra spaces at the beginning and end
            //so the extra spaces wouldn't print to console or be counted in string length.
            Console.WriteLine();

            //for each loop to print each character in user-entered sentence on a line by itself.
            foreach (char c in quote)
            {
                Console.WriteLine(c.ToString().ToUpper());
            }
            Console.WriteLine();

            //to figure out the length of the quote and then print it to console.
            int quoteLength = quote.Length;

            Console.WriteLine("The lenght of the quote is: {0} characters", quoteLength);

            Console.ReadLine();
        }
    }
}
