using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetHomeWork
{
    class ActionInConsole
    {
        public static void AgeDiference()
        {
            int ageC = 0;
            int ageF = 0;
            DateTime dateTime = DateTime.Now;
            Console.Write("Mutqagreq dzer anuny - ");
            string fNameC = Console.ReadLine();
            Console.Write("Mutqagreq dzer azganuny - ");
            string LNameC = Console.ReadLine();
            Console.Write("Mutqagreq dzer taretivy - ");
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                ageC = result;
            }
            else
            {
                Console.WriteLine("Duq mutqagrel eq sxal tvyal");
            }
            Console.WriteLine(new string('-', 20));
            Console.Write("Mutqagreq dzer hayriki anuny - ");
            string fNameF = Console.ReadLine();
            Console.Write("Mutqagreq dzer hayriki azganuny - ");
            string LNameF = Console.ReadLine();
            Console.Write("Mutqagreq dzer hayriki taretivy - ");
            if (int.TryParse(Console.ReadLine(), out int resultF))
            {
                ageF = resultF;
            }
            else
            {
                Console.WriteLine("Duq mutqagrel eq sxal tvyal");
            }
            Console.WriteLine(new string('-', 20));
            Console.WriteLine($"{fNameC} {LNameC} duq {dateTime.Year - ageC} tarekan eq");
            Console.WriteLine(new string('-', 20));
            Console.WriteLine($"Dzer hayry {fNameF} {LNameF}y {dateTime.Year - ageF} tarekan e ev dzezanic mec e {ageC - ageF} tarov");
        }

        public static void GetNumbersOPeration()
        {
            int num1 = 0;
            int num2 = 0;
            Console.Write("Please enter a number1 - ");
            if (int.TryParse(Console.ReadLine(), out int result1))
            {
                num1 = result1;
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            Console.Write("Please enter a number2 - ");
            if (int.TryParse(Console.ReadLine(), out int result2))
            {
                num2 = result2;
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }

        public static void LetterLowerOrUpper()
        {
            Console.Write("Please enter a letter");
            string str = Console.ReadLine();
            char input = Convert.ToChar(str);
            
            Console.WriteLine(input);
        }
    }
}
