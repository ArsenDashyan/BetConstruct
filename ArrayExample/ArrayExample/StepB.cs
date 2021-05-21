using Utility;

namespace ArrayExample
{
    class StepB
    {
        //Example 1,2

        /// <summary>
        /// Remove duplicats in array
        /// </summary>
        /// <param name="array">Input array</param>
        /// <param name="recurringCount">Duplicats item count</param>
        /// <returns></returns>
        public static (int[], int[]) RemoveRecurringItem(int[] array, int recurringCount)
        {
            var result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                        count++;
                }
                if (recurringCount != 1)
                {
                    if (count == recurringCount - 1)
                    {
                        result[i] = array[i];
                        array[i] = 0;
                    }
                }
                else
                {
                    if (count > 0)
                    {
                        result[i] = array[i];
                        array[i] = 0;
                    }
                }
            }
            return (array, result);
        }

        //Example 3

        /// <summary>
        /// Get new array by one dimision whit created a Multiple Items
        /// </summary>
        /// <param name="array">Input array</param>
        /// <param name="pivot">Multiple number</param>
        /// <returns></returns>
        public static int[] GetArrayByMultipleItemTwoD(int[,] array, int pivot)
        {
            var result = new int[array.GetLength(0) * array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % pivot == 0)
                    {
                        result[i] = array[i, j];
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Get new array by one dimision whit created a Multiple Items
        /// </summary>
        /// <param name="array">Input array</param>
        /// <param name="pivot">Multiple number</param>
        /// <returns></returns>
        public static int[] GetArrayByMultipleItemJagged(int[][] array, int pivot)
        {
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
                    if (array[i][j] % pivot == 0)
                    {
                        result[i] = array[i][j];
                    }
                }
            }
            return result;
        }

        //Example 4

        /// <summary>
        /// Get new array in one dimision creaated by max items
        /// </summary>
        /// <param name="array">Input array</param>
        /// <returns>Return new array</returns>
        public static int[] GetArrayByMaxItemsInTwoD(int[,] array)
        {
            var result = new int[array.GetLength(0) * array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                var temp = new int[array.GetLength(1)];
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    temp[j] = array[i, j];
                }
                result[i] = temp.GetMaxItemInArray();
            }

            return result;
        }

        /// <summary>
        /// Get new array in one dimision creaated by max items
        /// </summary>
        /// <param name="array">Input array</param>
        /// <returns>Return new array</returns>
        public static int[] GetArrayByMaxItemsInJagged(int[][] array)
        {
            int lenght = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                lenght += array[i].Length;
            }
            var result = new int[lenght];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                var temp = new int[array[i].Length];
                for (int j = 0; j < array[i].Length; j++)
                {
                    temp[j] = array[i][j];
                }
                result[i] = temp.GetMaxItemInArray();
            }
            return result;
        }
    }
}
