﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 4;
            int sum = 0;

            sum = Add(a, b);
            Console.WriteLine("sum = {0}",sum);
            Console.ReadLine();
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }


    }
}
