using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            string s;
            Console.WriteLine("Ievadi divus skaitlus: ");
            Console.Write("x= "); s = Console.ReadLine(); x = int.Parse(s);
            Console.Write("y= "); s = Console.ReadLine(); y = int.Parse(s);
            z = x * y;
            Console.WriteLine("x*y= " + z.ToString());
            for (int i = 1; i <= z; i++)
            {
                Console.Write(" * ");
            }
            Console.ReadLine();
        }
    }
}
