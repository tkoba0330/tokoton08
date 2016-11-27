using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton08_04
{
    class Program
    {
        private static void getNameAndAge(out string Name, out int Age)
        {
            Name = "Bill";
            Age = 18;
        }

        static void Main(string[] args)
        {
            // 初期化されない変数はref出来ない。（コンパイルエラーになる。）
            // -> refからoutに変更すると初期化の義務はなくなる
            // 　　　・outは呼び出し先での値のセットが義務づけられるため
            string name;
            int age;

            getNameAndAge(out name, out age);

            Console.WriteLine($"Name={name}, Age={age}");

            Console.ReadLine();
        }
    }
}

