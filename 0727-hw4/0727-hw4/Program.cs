using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0727_hw4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();
            int i = rdm.Next(1, 101);
            
            Console.WriteLine("系統已隨機產生1~100的其中一個數字");
            Console.WriteLine("請輸入 : ");

            int input = int.Parse(Console.ReadLine());

            while (input != i)
            {
                if (input < i)
                {
                    Console.WriteLine("您輸入的數字比{0}大，請再猜一個數~", input);                    
                }
                else if (input > i)
                {
                    Console.WriteLine("您輸入的數字比{0}小，請再猜一個數~", input);                   
                }
                input = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("恭喜你猜對了!");
        }
    }
}
