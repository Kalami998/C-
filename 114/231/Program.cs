using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Delegates
    {
        public delegate int call (int n1,int n2);
        class Math
        {
            public int Multiply(int n1, int n2)
            {
                return n1 * n2;
            }
            public int Divides(int n1, int n2)
            {
                if (n2 != 0)
                {
                    return n1 / n2;
                }
                else
                {
                    
                    Console.WriteLine(" 被除数不能为0 ");
                    return 00000000;
                }
            }


        }
        static void Main(string[] args)
        {
            call objcall;
            Math  objMath=new Math();
            call ioicall;
            Math ioiMath = new Math();
            ioicall = new call(ioiMath.Multiply);
            objcall=new call(objMath.Divides);
            Console.WriteLine("请输入需要运算的第一个整数:");
            string io = Console.ReadLine();
            int o = int.Parse(io);
            Console.WriteLine("请输入需要运算的第二个整数:");
            string iu = Console.ReadLine();
            int u = int.Parse(iu);
            int result = objcall(o, u);
            Console.WriteLine("结果为{0}", result);
            Console.ReadLine();



        }
    }
}
