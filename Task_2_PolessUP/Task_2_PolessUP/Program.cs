using System;
using System.IO;

namespace Task_2_PolessUP
{
    class Program
    {
        static int[] Nums(int[] nums,int target)
        {
            // массив для записи индексов необходимых элементов
            int[] mass =new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    
                    if (i!=j && nums[i] + nums[j] == target)
                    {
                        mass[1] = nums[i];
                        mass[0] = nums[j];
                    }
                    
                }
            }
            return mass;
        }
        static void PrintMass(int[] vs)
        {
            foreach (int x in vs)
            {
                Console.Write(x+", ");
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[5] { 1, 2, 3, 4, 5 };
            int[] b = Nums(a, 10);
            PrintMass(b);
        }

    }
}
