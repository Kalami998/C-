using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Co._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            Console.WriteLine("数组的行数为：");
            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine("\n");
            Console.WriteLine("列数为:");
            Console.WriteLine(arr.GetLength(1));
            Console.WriteLine("\n");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                string sta = "";
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sta = sta + Convert.ToString(arr[i, j]) + " ";
                }
                Console.WriteLine(sta);
                Console.WriteLine("\n");
            }




        }
    }
}
