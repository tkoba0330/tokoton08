using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton08_04
{
    class NameAndAge
    {
        internal string Name;
        internal int Age;
    }

    class Program
    {
        private static NameAndAge getNameAndAge()
        {
            return new NameAndAge() { Name = "Bill" , Age = 18};
        }


        static void Main(string[] args)
        {
            var packed = getNameAndAge();

            Console.WriteLine($"Name={packed.Name},Age={packed.Age}");

            Console.ReadLine();
        }
    }
}
