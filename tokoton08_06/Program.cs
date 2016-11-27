using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton08_06
{

    class Program
    {
        private static object getNameAndAge()
        {
            return new { Name = "Bill", Age = 18 };
        }


        static void Main(string[] args)
        {
            var packed = getNameAndAge();

            Console.WriteLine(
                $"Name={packed.GetType().GetProperty("Name").GetValue(packed,null)},Age={packed.GetType().GetProperty("Age").GetValue(packed, null)}");

            Console.ReadLine();
        }
    }
}
