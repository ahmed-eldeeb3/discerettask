using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter starting number: ");
            int startnum = int.Parse(Console.ReadLine());
            Console.WriteLine("enter ending number");
            int endnum = int.Parse(Console.ReadLine());
            Console.WriteLine("thee are the numers between {0} and {1}", startnum, endnum);

            for (int i = startnum; i <= endnum; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;

                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.WriteLine("{0} ", i);
                }
            }
        }
    }
}

            
