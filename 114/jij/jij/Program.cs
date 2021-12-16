using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jij
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入想要展示的正方形边长：");
            string ate = Console.ReadLine();
            int a = int.Parse(ate);
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.WriteLine("*", j);

                }
                
            }

            Console.ReadLine();

        }

    }
}
