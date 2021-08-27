using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_Tutorial
{
    class Program
    {
        static void Main()
        {
            idle();
            string n = Console.ReadLine();
            SayHello(n);
            Console.ReadKey();

            void SayHello(string name)
            {
                if(name != null || name != "")  
                {
                    Console.WriteLine("Hello " + name);
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }
            }
            void idle()
            {
                Console.WriteLine("$>");
            }
        }
    }
}
