﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCalcualator
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = AddNumbers(64, 32);
            Console.WriteLine(result);
            Console.WriteLine(AddNumbers(-1, 32));
            Console.ReadKey();
            /*test/*test*//*test*/
        }

        private static int AddNumbers(int numberOne, int numberTwo)
        {
            int CalculationResult;
            CalculationResult = numberOne + numberTwo;
            return CalculationResult;
        }
    }
}
