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
//<<<<<<< HEAD
//            int x, y, w;
//=======
//            int x, y, z;
         //radas konflikts, tapec veicu labojumus pats
            int x, y, w, z;
//>>>>>>> multiply
            string s;
            Console.WriteLine("Ievadi divus skaitlus: ");
            Console.Write("x= "); s = Console.ReadLine(); x = int.Parse(s);
            Console.Write("y= "); s = Console.ReadLine(); y = int.Parse(s);
//<<<<<<< HEAD
            w = x + y;
            Console.WriteLine("x un y summa ir: " + w.ToString());
//=======
            z = x * y;
            Console.WriteLine("x*y= " + z.ToString());
            for (int i = 1; i <= z; i++)
            {
                Console.Write(" * ");
            }
//>>>>>>> multiply
            Console.ReadLine();
        }
    }
}
