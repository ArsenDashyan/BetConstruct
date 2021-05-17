using System;

namespace Actions
{
    enum Color
    {
        White,
        Black,
        Blue,
        Red,
        Yellow
    }
    public class SomeMethods
    {
        /// <summary>
        /// Show a maximum item in three numbers
        /// </summary>
        public static void GetMaxNumber()
        {
            var tupl = GetInputNumbers();
            int max = tupl.Item1;
            if (tupl.Item2 >= max)
            {
                max = tupl.Item2;
            }
            else if (tupl.Item3 >= max)
            {
                max = tupl.Item3;
            }
            Console.WriteLine($"Maximum element in {tupl.Item1}, {tupl.Item2}, {tupl.Item3} numbers is {max}");
        }

        /// <summary>
        /// Sorted three numbers
        /// </summary>
        public static void PrintBySort()
        {
            var tupl = GetInputNumbers();
            int max = tupl.Item1;
            int min = tupl.Item2;
            int mijin = 0;
            if (tupl.Item2 >= max)
            {
                max = tupl.Item2;
            }
            else if (tupl.Item3 >= max)
            {
                max = tupl.Item3;
            }
            if (tupl.Item2 < max)
            {
                min = tupl.Item2;
            }
            else if (tupl.Item3 < max)
            {
                min = tupl.Item3;
            }
            if (tupl.Item1 != min & tupl.Item1 != max)
            {
                mijin = tupl.Item1;
            }
            else if (tupl.Item2 != min & tupl.Item2 != max)
            {
                mijin = tupl.Item2;
            }
            else
            {
                mijin = tupl.Item3;
            }
            Console.WriteLine($"UnSorted numbers - {tupl.Item1}, {tupl.Item2}, {tupl.Item3}");
            Console.WriteLine($"Sorted numbers - {min}, {mijin}, {max}");
        }

        /// <summary>
        /// Check a input symbol type and send in message 
        /// </summary>
        public static void GetCharType()
        {
            Console.Write("Please enter a char: ");
            string input = Console.ReadLine();
            if (input.Length > 1)
            {
                Console.WriteLine("Sorry!! you enter a invalid char");
            }
            else
            {
                char temp = Convert.ToChar(input);
                if ('a' <= temp && temp <= 'z')
                {
                    Console.WriteLine($"You enter a Lower letter {temp}");
                }
                else if ('A' <= temp & temp <= 'Z')
                {
                    Console.WriteLine($"You enter a Upper letter {temp}");
                }
                else if (int.TryParse(temp.ToString(), out int result))
                {
                    Console.WriteLine($"You enter a Integer number {result}");
                }
                else
                {
                    Console.WriteLine($"You enter a other Symbol {temp}");
                }
            }
        }

        /// <summary>
        /// Get three number input in console
        /// </summary>
        /// <returns>Return tupl by three int numbers</returns>
        private static (int, int, int) GetInputNumbers()
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.Write("Please enter a num1: ");
            if (int.TryParse(Console.ReadLine(), out int result1))
            {
                num1 = result1;
            }
            Console.Write("Please enter a num2: ");
            if (int.TryParse(Console.ReadLine(), out int result2))
            {
                num2 = result2;
            }
            Console.Write("Please enter a num3: ");
            if (int.TryParse(Console.ReadLine(), out int result3))
            {
                num3 = result3;
            }
            return (num1, num2, num3);
        }

        public static void GetEnumType(int number)
        {
            var color = (Color)number;
            if (color >= Color.White && color <= Color.Yellow)
            {
                Console.WriteLine((Color)number);
            }
            //if (Enum.IsDefined(typeof(Color), number))
            //{
            //    Console.WriteLine((Color)number);
            //}
            else
                Console.WriteLine("Is color not difined");
        }
    }
}
