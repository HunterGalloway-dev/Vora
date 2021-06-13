using System;

namespace Problems
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Test data for can jump
            int[][] canJumpInputs = new int[][] {
                new int[] {2,3,1,1,4},
                new int[] {3,2,1,0,4}
            };
            bool[] canJumpOut = new bool[] {
                true,
                false,
            };

            // Test date for coinChange
            int[][] coinChangeInputArrays = new int[][] {
                new int[] {1,2,5},
                new int[] {2},
                new int[] {0}
            };
            int[] coinChangeInputAmounts = new int[] {11,3,0};
            
            int[] coinChangeOutputs = new int[] {3,-1,0};

            // Testing for can jump
            int i;
            for(i = 0; i < canJumpInputs.Length; i++) {
                Console.Write("Can Jump Input: " + canJumpInputs[i]);
                if(!canJumpOut[i] == Solution.CanJump(canJumpInputs[i])) {
                    Console.WriteLine(" Passed!");
                } else {
                    Console.WriteLine(" Failed!");
                }
            }

            // Testing for Solution.CoinChange
            for(i = 0; i < coinChangeInputArrays.Length; i++) {
                if(coinChangeOutputs[i] == Solution.CoinChange(coinChangeInputArrays[i],coinChangeInputAmounts[i]))
                {     
                    Console.WriteLine(" Passed!");
                } else {
                    Console.WriteLine(" Failed!");
                }
            }
        }
    }
}
