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
            string n = Console.ReadLine();
            SayHello(n);
            Console.ReadKey();

            void SayHello(string name)
            {
                Console.WriteLine("Hello " + name);
            }
        }
    }
}