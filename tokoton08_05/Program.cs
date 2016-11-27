using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton08_05
{
    // 構造体のほうがメモリの動的確保にかかる余分時間を短縮できるらしい
    // 実測1%しか違わないんだけど・・・
    struct NameAndAge
    {
        internal string Name;
        internal int Age;
    }

    class Program
    {
        private static NameAndAge getNameAndAge(string NmaeofInitial = "")
        {
            if (NmaeofInitial == "B")
            {
                return new NameAndAge() { Name = "Bill", Age = 18 };
            }

            return new NameAndAge() { Name = "Tom", Age = 18 };
        }


        static void Main(string[] args)
        {
            DateTime start_datetime = DateTime.Now;

            var packed = getNameAndAge();

            for(int i = 0; i < 100000000; i ++)
            {
                //Console.WriteLine($"Name={packed.Name},Age={packed.Age}");

                var packed2 = getNameAndAge("B");
                //Console.WriteLine($"Name={packed.Name},Age={packed.Age}");
                //Console.WriteLine($"Name={packed2.Name},Age={packed2.Age}");
            }

            DateTime end_datetime = DateTime.Now;

            Console.WriteLine(end_datetime.Subtract(start_datetime));

            Console.ReadLine();
        }
    }
}
