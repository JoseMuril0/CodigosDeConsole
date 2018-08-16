using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigosConsoles
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Maior(20, 10));

            Console.ReadLine();
        }

        public static bool Maior(int num1, int num2)
        {
            return num1 > num2;
        }
    }
}
