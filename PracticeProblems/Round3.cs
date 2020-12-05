using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Round3
    {
        public static void Question1()
        {
            var coord = new List<Tuple<int, int>>();
            coord.Add(new Tuple<int, int>(1, 2));
            coord.Add(new Tuple<int, int>(3, 4));
            coord.Add(new Tuple<int, int>(1, -1));

            var blah = closestLocations(3, coord, 2);

            foreach (var tuple in blah)
            {
                Console.WriteLine($"{tuple.Item1},{tuple.Item2}");
            }

        }

        public static List<Tuple<int, int>> closestLocations(int totalCrates,
                                            List<Tuple<int, int>> allLocations,
                                            int truckCapacity)
        {

            Dictionary<double, Tuple<int, int>> locations = new Dictionary<double, Tuple<int, int>>();

            // WRITE YOUR CODE HERE
            allLocations.Sort((x, y) => getDistance(x.Item1, x.Item2).CompareTo(getDistance(y.Item1, y.Item2)));

            return allLocations.Take(truckCapacity).ToList();
        }

        public static double getDistance(int x, int y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public static void Question2()
        {
            var items = new List<Tuple<string, string>>();
            items.Add(new Tuple<string, string>("Item1", "Item2"));
            items.Add(new Tuple<string, string>("Item3", "Item4"));
            items.Add(new Tuple<string, string>("Item4", "Item5"));
            items.Add(new Tuple<string, string>("Item5", "Item6"));

            var blah = largestItemAssociation(items);

            Console.WriteLine(string.Join(",", blah));

        }

        public static List<string> largestItemAssociation(
                               List<Tuple<string, string>> itemAssociation)
        {
            // WRITE YOUR CODE HERE

            // if item2 == next.item1 -> associated
            
            // TODO multiple links 
            // clear 

            foreach (var blah in itemAssociation)
            {
                Console.WriteLine($"{blah.Item1},{blah.Item2}");
            }

            if (itemAssociation.Count == 0)
            {
                return new List<string>();
            }

            List<string> associations = new List<string>();
            associations.AddRange(new List<string> { itemAssociation[0].Item1, itemAssociation[0].Item2 });

            for (int i = 0; i < itemAssociation.Count; i++)
            {
                if (i + 1 < itemAssociation.Count && itemAssociation[i].Item2 == itemAssociation[i + 1].Item1)
                {
                    List<string> newAssociations = new List<string> { itemAssociation[i].Item1, itemAssociation[i].Item2, itemAssociation[i + 1].Item2 };

                    if (newAssociations.Contains(associations.Last()))
                    {
                        foreach (string eachNewAssociation in newAssociations)
                        {
                            if (!associations.Contains(eachNewAssociation))
                            {
                                associations.Add(eachNewAssociation);
                            }
                        }
                    }
                    else if (newAssociations.Count > associations.Count)
                    {
                        associations = newAssociations;
                    }
                }

                associations.Sort();

            }


            return associations;
        }

    }
}
