using System;

namespace individual_characters_from_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a short sentence, quote, or string of gibberish: ");
            string quote = Console.ReadLine().ToUpper();
            Console.WriteLine();

            foreach (char c in quote)
            {
                Console.WriteLine(c.ToString().ToUpper());
            }
            Console.WriteLine();
            int quoteLength = quote.Length;

            Console.WriteLine("The lenght of the quote is: {0} characters", quoteLength);

            Console.ReadLine();
        }
    }
}
