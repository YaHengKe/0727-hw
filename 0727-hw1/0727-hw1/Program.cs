using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0727_hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1,n=2;
            int record = 0;
            while (record<99)
            {
                int t = i + n;

                Console.Write(i);
                Console.Write("+");
                Console.Write(n);
                Console.Write("=");
                Console.Write(t);
                Console.WriteLine(" ");
                i = t;
                n = n + 1;
                Console.WriteLine("");
                record++;
            }
            Console.WriteLine("結束");

        }
    }
}
