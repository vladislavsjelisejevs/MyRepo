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
            int x, y, w;
            string s;
            Console.WriteLine("Ievadi divus skaitlus: ");
            Console.Write("x= "); s = Console.ReadLine(); x = int.Parse(s);
            Console.Write("y= "); s = Console.ReadLine(); y = int.Parse(s);
            w = x + y;
            Console.WriteLine("Skaitļu (x+y) summa: " + w.ToString());
            Console.ReadLine();
        }
    }
}
