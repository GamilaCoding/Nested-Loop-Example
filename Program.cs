using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedFor
{
    class program
    {
        static void Main(string[] args)
        {
            for (int dep = 1; dep <= 4; dep++)
            {
                Console.WriteLine("Department " +dep);
                Console.WriteLine("**************");
                for (int emp =1; emp <= 3; emp++)
                {
                    Console.WriteLine(" Employee " + emp);
                }
                Console.WriteLine("**************");
            }
        }
    }
}