using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems.Others
{
    public static class GenGCD
    {
        public static void GenGCDMain(string[] args)
        {
            // { 2, 4, 6, 8, 10}
            // { 2, 3, 4, 5, 6 }
            int[] arr = new int[5] { 5, 10, 15, 20, 25 };

            Console.WriteLine(string.Join(",", generalizedGCD(5, arr)));

            Console.ReadKey();

        }

        public static int generalizedGCD(int num, int[] arr)
        {
            int gcd = 1;
            // WRITE YOUR CODE HERE
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] % arr[i] != 0)
                        break;
                    if (arr[j] != arr[i])
                        gcd = arr[i];
                }
            }
            return gcd;
        }
    }
}
