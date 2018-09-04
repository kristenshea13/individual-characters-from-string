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
                Console.WriteLine(c);
            }




            Console.ReadLine();
        }
    }
}
