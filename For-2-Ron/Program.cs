using System;

namespace For_2_Ron
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, temp = 0;
            int[] nums = new int[8];

            for(i=0; i<8; i++)
            {
                Console.Write($"Enter num {i+1}: ");
                temp = int.Parse(Console.ReadLine());
                while (temp <= 0)
                {
                    if (temp <= 0)
                    {
                        Console.WriteLine("Invalid input, try again.");
                    }
                    temp = int.Parse(Console.ReadLine());
                }
                nums[i] = temp;
                Console.WriteLine();
                temp = 0;
            }

            for (i = 0; i < 8; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    Console.WriteLine(nums[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
