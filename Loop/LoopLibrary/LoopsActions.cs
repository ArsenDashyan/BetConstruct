using System;

namespace LoopLibrary
{
    public class LoopsActions
    {
        /// <summary>
        /// Input three numbers in one loop and cheked the minimum item
        /// </summary>
        public static void GetMinItemWithOneLoop()
        {
            Console.WriteLine("Please input a three numbers");
            int count = 1;
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            while (count <= 3)
            {
                Console.Write($"Number{count}: ");
                if(int.TryParse(Console.ReadLine(), out int result))
                {
                    switch (count)
                    {
                        case 1:
                            num1 = result;
                            count++;
                            break;
                        case 2:
                            num2 = result;
                            count++;
                            break;
                        case 3:
                            num3 = result;
                            count++;
                            break;
                    }
                }
                else
                    Console.WriteLine("You input invalid number");
            }
            GetMinItem(num1, num2, num3);
        }

        /// <summary>
        /// Show a maximum item in three numbers
        /// </summary>
        private static void GetMinItem(int a, int b, int c)
        {
            int min =a;
            if (b <= min)
            {
                min = b;
            }
            else if (c <= min)
            {
                min = c;
            }
            Console.WriteLine($"Maximum element in {a}, {b}, {c} numbers is {min}");
        }

        /// <summary>
        /// Input three numbers in one loop and cheked the minimum item
        /// </summary>
        public static void GetLettersWithOneLoop()
        {
            Console.WriteLine("Please input a three letters");
            int count = 1;
            char letter1 = char.MinValue;
            char letter2 = char.MinValue;
            char letter3 = char.MinValue;
            while (count <= 3)
            {
                Console.Write($"Letter{count}: ");
                string temp = Console.ReadLine().ToLower();
                if (temp.Length == 1)
                {
                    char letter = Convert.ToChar(temp);
                    if (letter >= 'a' && letter <= 'z')
                    {
                        switch (count)
                        {
                            case 1:
                                letter1 = letter;
                                count++;
                                break;
                            case 2:
                                letter2 = letter;
                                count++;
                                break;
                            case 3:
                                letter3 = letter;
                                count++;
                                break;
                        }
                    }
                    else
                        Console.WriteLine("You input invalid number");
                }
                else
                    Console.WriteLine("You input invalid number");
            }
            PrintBySort(letter1, letter2, letter3);
        }

        /// <summary>
        /// Sorted three letters
        /// </summary>
        private static void PrintBySort(char a, char b, char c)
        {
            char max = a;
            char min = b;
            char midlle = c;
            if (b >= max)
                max = b;
            else if (c >= max)
                max = c;

            if (b < max)
                min = b;
            else if (c < max)
                min = c;

            if (a != min & a != max)
                midlle = a;
            else if (b != min & b != max)
                midlle = b;
            else
                midlle = c;
            Console.WriteLine($"UnSorted letters - {a}, {b}, {c}");
            Console.WriteLine($"  Sorted letters - {min}, {midlle}, {max}");
        }

        /// <summary>
        /// Print a input string
        /// </summary>
        /// <param name="input">string for print</param>
        /// <param name="count">Iteracion count</param>
        public static void PrintWithOneLoop(string input, int count)
        {
            if (count>0)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(input);
                }
            }
        }

        public static void ChessBoard()
        {
            Console.WriteLine(@"+---+---+---+---+---+---+---+---+");
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine($"|   |   |   |   |   |   |   |   |   {i}");
                Console.WriteLine(@"+---+---+---+---+---+---+---+---+");
            }
            Console.WriteLine("  A   B   C   D   E   F   G   H");
        }
    }
}
