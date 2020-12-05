using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems.Round1
{
    public class NumOfPairs
    {
        public static void NumOfPairsMain(string[] args)
        {
            //List<KeyValuePair<int, int>> lkvp = new List<KeyValuePair<int, int>>();

            //lkvp.Add(new KeyValuePair<int, int>(6, 6));
            //lkvp.Add(new KeyValuePair<int, int>(3, 9));
            //lkvp.Add(new KeyValuePair<int, int>(6, 6));

            //foreach (var each in lkvp.Distinct().ToList())
            //{
            //    Console.WriteLine($"{each.Key}:{each.Value}");
            //}
            // 6,6,3,9,3,5,1
            Console.WriteLine(NumberOfPairs(new List<int>() { 1, 3, 46, 1, 3, 9 }, 47));

            Console.ReadKey();
        }


        public static int NumberOfPairs(List<int> a, long k)
        {
            List<KeyValuePair<int, int>> lkvp = new List<KeyValuePair<int, int>>();

            a.Sort();

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < a.Count; i++)
            {
                for (int j = a.Count - 1; j >= 0; j--)
                {
                    if (a[i] + a[j] == k)
                    {
                        //if (lkvp.FirstOrDefault(kvp => kvp.Key == i).Key != a[j] && lkvp.FirstOrDefault(kvp => kvp.Value == j).Key != a[i])
                        //    lkvp.Add(new KeyValuePair<int, int>(a[i],a[j]));
                        if (!(dict.ContainsKey(a[i]) && dict.ContainsValue(a[j])))
                            dict.Add(a[i], a[j]);
                    }
                }
            }

            return lkvp.Distinct().Count();
        }
    }
}
