﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton08
{
    class Program
    {
        private static void getNameAndAge(ref string Name, ref int Age)
        {
            Name = "Bill";
            Age = 18;
        }

        static void Main(string[] args)
        {
            string name = "";
            int age = 0;

            getNameAndAge(ref name,ref age);

            Console.WriteLine($"Name={name}, Age={age}");

            Console.ReadLine();
        }
    }
}
