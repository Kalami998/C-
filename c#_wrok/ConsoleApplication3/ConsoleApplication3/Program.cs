using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入判断年份");
            Console.ReadLine();
            string b = Console.ReadLine();
            int a;
            a = int.Parse(b);
            if (a % 4 == 0 && a % 100 != 0)
            {
             Console.WriteLine("该年为普通闰年");
               if (a % 400 == 0)
               {
                   Console.WriteLine("该年为世纪闰年");
               }
               else
                   Console.WriteLine("该年为普通年，不属于闰年");
            }



            




        }
    }
}
