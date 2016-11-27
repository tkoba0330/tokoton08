using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton08_02
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
            // 初期化されない変数はref出来ない。（コンパイルエラーになる。）
            string nam;
            int age;

            getNameAndAge(ref name, ref age);

            Console.WriteLine($"Name={name}, Age={age}");

            Console.ReadLine();
        }
    }
}
