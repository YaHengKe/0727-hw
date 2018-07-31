using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0727_hw5
{
    class Program
    {
        static void Main(string[] args)
        {
            //int y = 15,x=2;

            int y = int.Parse(Console.ReadLine());
            int x = 2;

            while (y>2)
            {
                while (y % x != 0)
                {
                    x = x + 1;
                    if (y % x == 0)
                    {
                        break;
                    }
                    else
                    {
                        x = x + 1;
                        while (y % x != 0)
                        {
                            x = x + 1;
                            if (x == y)
                            {
                                Console.WriteLine(y + " 是質數");
                                break;
                            }
                        }
                        
                    }
                }

                x = 2;
                y = y - 1;
            }
            Console.WriteLine("3是質數");
            Console.WriteLine("2是質數");
            
        }
    }
}
