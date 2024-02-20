using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2_Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Hello World : " + args[0] + " " + args[1]);
            }
            else
            {
                Console.WriteLine("Hello World : args.Length = 0");
            }
            Console.ReadKey();
        }
    }
}
