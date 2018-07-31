using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0727_hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int input = 5, star = 1, temp = 5;

            Console.WriteLine("請輸入聖誕樹的高 : ");
            int input = int.Parse(Console.ReadLine());
            int temp = input;
            int star = 1;

            while (input > 0)
            {
                while (temp > 1)
                {
                    Console.Write(" ");//印出空白
                    temp = temp - 1;
                }

                int i = star;
                while (i <= star && i > 0)
                {
                    Console.Write("*");//印出星星
                    i = i - 1;
                }
                star = star + 2;
                Console.WriteLine("");
                input = input - 1;
                temp = input;
            }

        }
    }
}
