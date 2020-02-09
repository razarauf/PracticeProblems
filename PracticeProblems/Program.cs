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
            int[] states = new int[8] { 0, 1, 1, 0, 1, 1, 0, 1 };

            Console.WriteLine(string.Join(",", cellCompete(states, 1)));

            Console.ReadKey();
        }

        public static int[] cellCompete(int[] states, int days)
        {
            // INSERT YOUR CODE HERE
            for (int i = 0; i < days; i++)
            {
                states = cellCompeteHelper(states, new int[states.Length]);
            }
            return states;
        }

        public static int[] cellCompeteHelper(int[] states, int[] returnedStates)
        {
            returnedStates[0] = states[1];
            returnedStates[7] = states[6];

            for (int i = 1; i < states.Length - 1; i++)
            {
                returnedStates[i] = processXOR(
                    states[i - 1] == 1 ? true : false,
                    states[i + 1] == 1 ? true : false);
            }

            return returnedStates;
        }

        public static int processXOR(bool state1, bool state2)
        {
            return state1 ^ state2 == true ? 1 : 0;
        }
    }
}
