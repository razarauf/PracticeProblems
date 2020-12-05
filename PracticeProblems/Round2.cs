using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class Round2
    {
        public struct Point
        {
            public int X { get; private set; }
            public int Y { get; private set; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override string ToString()
            {
                return $"[{X},{Y}]";
            }

            //public override bool Equals(object obj)
            //{
            //    if (X == x && y == Y)
            //    {
            //        return true;
            //    }

            //    return false;
            //}

        }

        public static void Question1()
        {
            numberAmazonTreasureTrucks(5, 4, new int[,] { { 1, 1, 0, 0 }, { 0, 0, 1, 0 }, { 0, 0, 0, 0 }, { 1, 0, 1, 1 }, { 1, 1, 1, 1 } });
        }

        // keep a record of linked clusters 
        // cluster1: [row, col], [row, col], and so on..
        // cluster2: [row, col], [row, col], and so on..

        public static void numberAmazonTreasureTrucks(int rows, int column, int[,] grid)
        {
            // read each element left to right, top to bottom 
            // find element with 1
            // is it linked? -> which way? up, right, down, left? -> follow link 
            // loop until no further link is found or loop (reached already visited coordinate)

            Dictionary<int, List<Point>> clusterFuck = new Dictionary<int, List<Point>>();

            int numberOfClusters = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (grid[i, j] == 1)
                    {
                        List<Point> links = findCluster(i, j, rows, column, grid);

                        if (links.Count > 0)
                        {
                            numberOfClusters++;
                            clusterFuck.Add(numberOfClusters, links);
                        }

                    }
                }
            }


            if (!clusterFuck.ContainsKey(1))
            {
                clusterFuck.Add(1, new List<Point>());
                clusterFuck[1].Add(new Point(3, 0));
                clusterFuck[1].Add(new Point(4, 0));
                clusterFuck[1].Add(new Point(4, 1));
            }
            else
            {
                clusterFuck[1].Add(new Point(1, 3));
            }

            clusterFuck.Add(2, new List<Point>());
            clusterFuck[2].Add(new Point(0, 0));
            clusterFuck[2].Add(new Point(0, 1));

            foreach (int eachKey in clusterFuck.Keys)
            {
                Console.WriteLine($"{eachKey}:{string.Join(", ", clusterFuck[eachKey])}");
            }

            Console.WriteLine(clusterFuck.Keys.Count);

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        if (grid[i, j] == 1)
            //        {
            //            digDeep(i, j, rows, column, grid);
            //        }
            //    }
            //}

            //int onesWCrossHair = 0;

            //Console.WriteLine(onesWCrossHair);

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        Console.Write(grid[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
        }

        public static List<Point> findCluster(int r, int c, int row, int column, int[,] grid)
        {
            //if ((r-1 > 0 && grid[r-1, c] != 1) || (c+1 < column && grid[r, c+1] != 1) || (r+1 < row && grid[r + 1, c] != 1) || (c-1 > 0 && grid[r, c-1] != 1))
            //{
            //    return 1;
            //}
            //else
            //{
            //    return 0;
            //}

            return new List<Point>();

        }

        public static void digDeepHelper()
        {

        }

        public static void howManyOnes(int rows, int column, int[,] grid)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void print2DArray(int rows, int column, int[,] grid)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


        public static void Question2()
        {

        }

        public static void Question2Helper()
        {

        }
    }
}
