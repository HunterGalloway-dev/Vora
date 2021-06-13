using System;

// Used namespace of problems as that was my namespace for the project and used a seperate
// file in order to unit test these solutions.
// I included the repo in the email to the entire .NET project if you want to see
// how I tested my code.
namespace Problems
{
    public class Solution
    {
        /// <summary>
        ///     Iterates through nums starting at index 0 and "jumping" through the array by adding the value at the current index
        /// </summary>
        /// <param name="nums">input array</param>
        /// <returns>if you can "jump" through nums (true or false)</returns>
        public static bool CanJump(int[] nums) {
            // Flag to determine if a value of 0 is found in order to break while
            bool zeroFlag = false;

            int i = 0;
            // Iterates through nums and adds the current value of nums at index i
            // to i until i < nums.length while zeroFlag is false
            while(!zeroFlag && i < nums.Length) {
                if(nums[i] == 0) {
                    zeroFlag = true;
                } else {
                    i += nums[i];
                }
            }
            
            // returns true if no zero is found and i is a valid index in nums
            return zeroFlag && i < nums.Length;
        }

        /// <summary>
        ///     Returns the minimal count of the input coins in order to make the certian amount
        /// </summary>
        /// <param name="coins">input coins (considered infinite amount)</param>
        /// <param name="amount">desired amount of change</param>
        /// <returns>the minimal count of coins to make change, -1 if you can not make change</returns>
        public static int CoinChange(int[] coins, int amount) {
            // value to return as there are two cases, it is possible to make
            // change or if it is not
            int ret = 0;

            //  I sorted the array from least to greatest as that is how C#
            // sorts arrays by default and then reveresed the array to
            // get the array in descending order. The purpose is that in doing
            // goes through the minimal path to the desired amount and avoids
            // generating all combinations. In short I did this to optimize in order
            // to create an effcient running solution
            Array.Sort(coins);
            Array.Reverse(coins);

            int cnt = 0;
            int i = 0;

            //  Iterates through coins and decreases amount by the current value at
            // coins[i] only if it keeps amount above or equal to 0, if it cannot do this 
            // it adds one to value i going to the next coin in the coins array. Iteration
            // continues only while i < the length of coins and amount is not 0
            while(i < coins.Length && amount != 0) {
                if(amount - coins[i] > -1) {
                    amount -= coins[i];
                    cnt++;
                } else {
                    i++;
                }
            }

            //  This if statement checks if change could be made or not
            // -1 if it cannot be made, a value of 0 or greater otherwise
            if(amount != 0 && i == coins.Length) {
                ret = -1;
            } else {
                ret = cnt;
            }

            return ret;
        }
    }
}