using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }

        public static List<string> popularNToys(int numToys,
                                     int topToys,
                                     List<string> toys,
                                     int numQuotes, List<string> quotes)
        {
            Dictionary<string, int> toyQuoteCount = new Dictionary<string, int>();

            for (int i = 0; i < numToys; i++)
            {
                Console.WriteLine(quotes.Where(eachQuote => eachQuote.IndexOf(toys[i], StringComparison.OrdinalIgnoreCase) > 0).Count());

                toyQuoteCount.Add(toys[i], quotes.Where(eachQuote => eachQuote.Contains(toys[i])).Count());
            }

            var orderedCount = toyQuoteCount.OrderByDescending(x => x.Value).ToList();

            return orderedCount.Select(kvp => kvp.Key).Take(2).ToList();
        }

    }
}
