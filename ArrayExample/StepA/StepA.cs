using System;

namespace Step
{
    public class StepA
    {
        //Example 1

        /// <summary>
        /// Check the input number multiple items count
        /// </summary>
        /// <param name="array">Array with the cheked</param>
        /// <param name="pivot">Number with the cheked</param>
        public static void GetMultipleItemCountInTwoD(int[,] array, int pivot)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % pivot == 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"{pivot} ին բազմապատիկ թվերի քանակն է {count}\n");
        }

        /// <summary>
        /// Check the input number multiple items count
        /// </summary>
        /// <param name="array">Array with the cheked</param>
        /// <param name="pivot">Number with the cheked</param>
        public static void GetMultipleItemCountInJagged(int[][] array, int pivot)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % pivot == 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine($"{pivot} ին բազմապատիկ թվերի քանակն է {count}\n");
        }

        //Example 2

        /// <summary>
        /// Create new array is input array
        /// </summary>
        /// <param name="array">Input array</param>
        /// <returns>Return new array</returns>
        public static int[] GetArrayByTwoD(int[,] array)
        {
            int count = 0;
            var result = new int[array.Length];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 0)
                        result[count++] = array[i, j];
                }
            }
            return result;
        }

        /// <summary>
        /// Create new array is input array
        /// </summary>
        /// <param name="array">Input array</param>
        /// <returns>Return new array</returns>
        public static int[] GetArrayByJagged(int[][] array)
        {
            int count = 0;
            int lenght = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                lenght += array[i].Length;
            }
            var result = new int[lenght];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                        result[count++] = array[i][j];
                }
            }
            return result;
        }

        //Example 3

        /// <summary>
        /// Get maximum item in input array
        /// </summary>
        /// <param name="array">Input array</param>
        public static void GetMaxItemInTwoD(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                        max = array[i, j];
                }
            }
            Console.WriteLine($"{max}-ը մեծագույն էլեմենտն է\n");
        }

        /// <summary>
        /// Get maximum item in input array
        /// </summary>
        /// <param name="array">Input array</param>
        public static void GetMaxItemInJagged(int[][] array)
        {
            int max = array[0][0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] > max)
                        max = array[i][j];
                }
            }
            Console.WriteLine($"{max}-ը մեծագույն էլեմենտն է\n");
        }

        //Example 4

        /// <summary>
        /// Get maximum item in input array and input column number
        /// </summary>
        /// <param name="array">Input array</param>
        /// <param name="column">Input column number</param>
        public static void GetMaxItemInCurrentColumnTwoD(int[,] array, int column)
        {
            if (column - 1 > array.GetLength(0))
                Console.WriteLine("Զանգավածը չունի այդքան տող");
            else
            {
                int max = array[0, 0];
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    if (array[column - 1, i] > max)
                        max = array[column - 1, i];
                }
                Console.WriteLine($"{column}-րդ տողի մեծագույն էլեմենտն է {max}\n");
            }
        }

        /// <summary>
        /// Get maximum item in input array and input column number
        /// </summary>
        /// <param name="array">Input array</param>
        /// <param name="column">Input column number</param>
        public static void GetMaxItemInCurrentColumnJagged(int[][] array, int column)
        {
            if (column - 1 > array.GetLength(0))
                Console.WriteLine("Զանգավածը չունի այդքան տող");
            else
            {
                int max = array[0][0];
                for (int i = 0; i < array[column - 1].Length; i++)
                {
                    if (array[column - 1][i] > max)
                        max = array[column - 1][i];
                }
                Console.WriteLine($"{column}-րդ տողի մեծագույն էլեմենտն է {max}\n");
            }
        }

        //Eample 5

        /// <summary>
        /// Get maximum item in input array
        /// </summary>
        /// <param name="array">Input array</param>
        public static void GetMaxItemInArray(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine($"{max}-ը մեծագույն էլեմենտն է\n");
        }

        //Example 6

        /// <summary>
        /// Sorted array item by bubble sort
        /// </summary>
        /// <param name="array">Input array</param>
        public static void BubbleSort(int[] array)
        {
            int temp;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
    }
}
