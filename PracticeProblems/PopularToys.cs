using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems.Round1
{
    class PopularToys
    {
        public static long WaitingTime3(List<int> tickets, int p)
        {
            LinkedList<int> ticketsLL = new LinkedList<int>(tickets.AsEnumerable<int>());

            long stepCounter = 0;

            while (ticketsLL.Count > 0)
            {
                if (ticketsLL.First() == 1)
                {
                    if (p == 0 && ticketsLL.First() == 1)
                        return stepCounter + 1;
                    else
                        ticketsLL.RemoveFirst();
                }
                else
                {
                    ticketsLL.AddLast(ticketsLL.First() - 1);
                    ticketsLL.RemoveFirst();
                }

                stepCounter++;

                if (p == 0)
                    p = ticketsLL.Count - 1;
                else
                    p--;
            }

            return stepCounter;

        }

        public static string MergeStrings(string a, string b)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < a.Count() + b.Count(); i++)
            {
                if (i < a.Count())
                    sb.Append(a[i]);

                if (i < b.Count())
                    sb.Append(b[i]);
            }

            return sb.ToString();
        }

        public static List<string> PopularNToys(int numToys,
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
