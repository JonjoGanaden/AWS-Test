using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else
{
     class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 0;
            int secondNumber = 0;
            Console.WriteLine("enter First Number: ");
            firstNumber = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            secondNumber = Convert.ToInt16(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("First number is larger than the Second number");
            }
            else if(secondNumber == firstNumber)
            { 
                Console.WriteLine("First number is equal to the Second Number");
            }
            else
            {
                Console.WriteLine("Second number is greater than the first number");
            }
            Console.ReadLine();

        }
    }
}
