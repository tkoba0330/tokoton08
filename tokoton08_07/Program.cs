using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton08_07
{
    class Program
    {
        private static dynamic getNameAndAge()
        {
            return new { Name = "Bill", Age = 18 };
        }


        static void Main(string[] args)
        {
            var packed = getNameAndAge();

            Console.WriteLine(
                $"Name={packed.Name},Age={packed.Age}");

            Console.ReadLine();
        }
    }
}
