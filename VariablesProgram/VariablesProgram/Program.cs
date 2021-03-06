﻿using System;

namespace VariablesProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A'; // single quote for char
            var firstName = "Evan"; //needs to be in double for string
            var isWorking = false;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            //Non-compatible casting
            //can us Convert  or parse
            string s = "1";
            int i = Convert.ToInt32(s);
            int j = int.Parse(s);

            Console.WriteLine(i);
            Console.WriteLine(j);

            //non-compatible casting
            var numbers = "1234";
            int integ = Convert.ToInt32(numbers);
            Console.WriteLine(integ);

            try
            { 
               var num = "1234";
               byte b = Convert.ToByte(num);
               Console.WriteLine(b);

            }
            catch (Exception ex)
            {
                Console.WriteLine("the number could not be converted to Byte");

            }
        }
    }
}
