using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortShortWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи текст: ");
            string text = Console.ReadLine().ToLower();

            char[] symbols = { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            string[] words = text.Split(symbols);

             var words1 = words
            .Where(x => x.Length < 5)
            .OrderBy(w => w)
            .Distinct();

            Console.WriteLine(string.Join(", ", words1));  
        }
    }
}
