using Step;
using System;
using System.Text;
using Utility;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Step A

            Console.WriteLine("Երկչափ զանգված \n");

            int[,] array = new int[3, 3];
            array.InitializeArray();
            array.PrintArray();

            StepA.GetMultipleItemCountInTwoD(array, 5); //ex 1

            var result = StepA.GetArrayByTwoD(array); //ex 2
            result.PrintArray();

            StepA.GetMaxItemInTwoD(array); //ex 3

            StepA.GetMaxItemInCurrentColumnTwoD(array, 2); //ex 4

            var resultOneB = StepB.GetArrayByMultipleItemTwoD(array, 4); // Step B ex 3
            Console.WriteLine("Զանգվածի կրկնվող արժեքներից ստացված զանգված");
            resultOneB.PrintArray();

            var resultOneByMaxTwo = StepB.GetArrayByMaxItemsInTwoD(array); // Step B ex 4 
            Console.WriteLine("Տողի մեծագույն արժեքներից ստացված զանգված");
            resultOneByMaxTwo.PrintArray();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            Console.WriteLine("Աստիճանաձև զանգված \n");

            int[][] arrayJ = new int[3][];
            arrayJ.InitializeArray();
            arrayJ.PrintArray();

            StepA.GetMultipleItemCountInJagged(arrayJ, 5); //ex 1

            var resultJ = StepA.GetArrayByJagged(arrayJ); //ex 2
            resultJ.PrintArray();

            StepA.GetMaxItemInJagged(arrayJ); //ex 3

            StepA.GetMaxItemInCurrentColumnJagged(arrayJ, 2); //ex 4

            var resultOneBJagged = StepB.GetArrayByMultipleItemJagged(arrayJ, 4); // Step B ex 3
            Console.WriteLine("Զանգվածի կրկնվող արժեքներից ստացված զանգված");
            resultOneBJagged.PrintArray();

            var resultOneByMaxJ = StepB.GetArrayByMaxItemsInJagged(arrayJ); // Step B ex 4 
            Console.WriteLine("Տողի մեծագույն արժեքներից ստացված զանգված");
            resultOneByMaxJ.PrintArray();

            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            Console.WriteLine("Միաչափ զանգված \n");

            int[] arrayOne = new int[10];
            arrayOne.InitializeArray();
            Console.WriteLine("Չսորտավորված զանգված");
            arrayOne.PrintArray();

            StepA.GetMaxItemInArray(arrayOne); //ex 5

            StepA.BubbleSort(arrayOne); //ex 6
            Console.WriteLine("Սորտավորված զանգված");
            arrayOne.PrintArray();

            #endregion

            #region Step B

            Console.WriteLine(new string('-', 30));
            Console.WriteLine();
            Console.WriteLine("Միաչափ զանգված \n");

            int[] arr = new int[30];
            arr.InitializeArray();
            arr.PrintArray();
            Console.WriteLine("Սորտավորված զանգված");
            StepA.BubbleSort(arr);
            arr.PrintArray();

            var tupl = StepB.RemoveRecurringItem(arr,1); //ex 1,2
            tupl.Item1.PrintArray();

            Console.WriteLine("Կրկնվող տարրեր");
            tupl.Item2.PrintArray();


            #endregion

            Console.ReadLine();
        }

    }
}
