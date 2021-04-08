using System;

namespace Manipulating_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[6] { 0, 2, 4, 6, 8, 10 };
            int[] b = new int[5] { 1, 3, 5, 7, 9 };
            int[] c = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Rotate(a, 2);
        }
        public static int Sum(int[] z)
        {
            int sum = 0;
            for (int i = 0; i < z.Length; i++)
            {
                sum += z.Length;
            }
            return sum;
        }
        public static double Avg(int[] nums)
        {
            int result = 0;
            foreach (int num in nums)
            {
                result += num;
            }
            return result / nums.Length;
        }
        public static void Reverse(int[] nums)
        {
            Array.Reverse(nums); 
            foreach (int l in nums)
            {
                Console.WriteLine(l);
            }
        }
        public static int Max(int[] nums)
        {
            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        public static void Rotate(int[] nums, int rotate)
        {
            for (int i = 0; i < nums.Length - rotate; i++)
            {
                int j;
                for (int k = 0; k < nums.Length - 1; k++)
                {
                    j = nums[k];
                    nums[k] = nums[nums.Length - 1];
                    nums[nums.Length - 1] = j;
                }

            }
            foreach (int l in nums)
            {
                Console.WriteLine(l);
            }

        }
        public static void Sort(int[] nums)
        {
            //Array.Sort(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
           
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] < nums[j]) // > is a reverse
                    {
                        int temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
                
            }
            foreach (int item in nums)
            {
                Console.WriteLine(item);
            }
        }
    }
}
