using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    public static class CellCompete
    {
        public static void CellCompeteInput()
        {
            int[] states = new int[8] { 0, 1, 1, 0, 1, 1, 0, 1 };

            Console.WriteLine(string.Join(",", Main(states, 1)));
        }

        public static int[] Main(int[] states, int days)
        {
            // INSERT YOUR CODE HERE
            for (int i = 0; i < days; i++)
            {
                states = CellCompeteHelper(states, new int[states.Length]);
            }
            return states;
        }

        public static int[] CellCompeteHelper(int[] states, int[] returnedStates)
        {
            returnedStates[0] = states[1];
            returnedStates[7] = states[6];

            for (int i = 1; i < states.Length - 1; i++)
            {
                returnedStates[i] = ProcessXOR(
                    states[i - 1] == 1 ? true : false,
                    states[i + 1] == 1 ? true : false);
            }

            return returnedStates;
        }

        public static int ProcessXOR(bool state1, bool state2)
        {
            return state1 ^ state2 == true ? 1 : 0;
        }
    }
}
