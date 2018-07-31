using System;
class Program
{
    static void Main(string[] args)
    {

        int x = 1, y;
        int result;
        while (x <= 9)
        {
            y = 1;
            while (y <= 9)
            {
                Console.Write(x);
                Console.Write("*");
                Console.Write(y);
                Console.Write("=");
                result = x * y;

                if (result < 10)
                {
                    Console.Write(" ");
                }
                Console.Write(result);
                Console.Write(" ");
                y = y + 1;
            }

            Console.WriteLine("");
            x++;
        }


    }
    
}

