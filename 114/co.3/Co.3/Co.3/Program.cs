using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co._3
{
    class Program
    {
       
        static void Main(string[] args)
        {    
            while(true)
            {
            Console.WriteLine("请输入想要展示的正方形边长：");
            string ate = Console.ReadLine();
            int a = int.Parse(ate);
            for (int i = 0; i < a; i++)
            {
                string nib = "";
                for (int j = 0; j < a; j++)
                {
                    nib = nib + "*" + " ";
                }
                  Console.WriteLine(nib);
            }                     
             Console.WriteLine("若继续输入请输入BU! 【退出请按任意键】");
             string ty = Console.ReadLine();
             if (ty.ToUpper()=="BU") continue;
             else break;
                    
            }

        }
    }
}
