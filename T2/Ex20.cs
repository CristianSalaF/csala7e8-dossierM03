using System.ComponentModel;

namespace T2
{
    internal class Ex20
    {
        internal static void Exercise(string[] args)
        {
            const string TxtNumberPrompt = "Introdueix el número {0}: ";
            const string TxtMaxNumber = "El número més gran és: {0}";
            const string TxtMinNumber = "El número més petit és: {0}";
            const string TxtAverage = "La mitjana dels números és: {0}";
            const string TxtPressToExit = "Prem qualsevol tecla per sortir...";
            const int NumsArraySize = 8;

            int[] nums = new int[NumsArraySize];
            int suma = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(TxtNumberPrompt, i+1);
                nums[i] = int.Parse(Console.ReadLine());
                suma += nums[i];
            }

            int maxNumber = GetHighestLowestNum(nums, true);
            int minNumber = GetHighestLowestNum(nums, false);
            float average = suma / nums.Length;

            Console.WriteLine(TxtMaxNumber, maxNumber);
            Console.WriteLine(TxtMinNumber, minNumber);
            Console.WriteLine(TxtAverage, average);

            Console.WriteLine(TxtPressToExit);
            Console.ReadKey();
        }

        private static int GetHighestLowestNum(int[] nums, bool highest)
        {
            int result = nums[0];
            foreach (int num in nums)
            {
                // If highest is true, it looks for the maximum number
                if (highest && num > result)
                {
                    result = num;
                }
                // If highest is false, it looks for the minimum number
                else if (!highest && num < result)
                {
                    result = num;
                }
            }

            return result;
        }
    }
}
