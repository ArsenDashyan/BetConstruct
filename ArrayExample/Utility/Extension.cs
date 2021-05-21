using System;

namespace Utility
{
    public static class Extension
    {
        /// <summary>
        /// Initialize array
        /// </summary>
        /// <param name="array">Current array</param>
        public static void InitializeArray(this int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = new Random().Next(1, 100);
                }
            }
        }

        /// <summary>
        /// Initialize array
        /// </summary>
        /// <param name="array">Current array</param>
        public static void InitializeArray(this int[] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = new Random().Next(1, 100);
            }
        }

        /// <summary>
        /// Initialize array
        /// </summary>
        /// <param name="array">Current array</param>
        public static void InitializeArray(this int[][] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i] = new int[i + 3];
                for (int j = 0; j < array[i].Length; j++)
                {
                    array[i][j] = new Random().Next(1, 100);
                }
            }
        }

        /// <summary>
        /// Print array
        /// </summary>
        /// <param name="array">Current array</param>
        public static void PrintArray(this int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Print array
        /// </summary>
        /// <param name="array">Current array</param>
        public static void PrintArray(this int[][] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write($"{array[i][j]}  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Print array
        /// </summary>
        /// <param name="array">Current array</param>
        public static void PrintArray(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                    Console.Write($"{array[i]}, ");
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Get maximum item in input array
        /// </summary>
        /// <param name="array">Input array</param>
        public static int GetMaxItemInArray(this int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

    }
}
