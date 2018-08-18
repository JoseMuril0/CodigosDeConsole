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

            try
            {
                int numero = 10, divisor = 0;
                int resultado = numero / divisor;
            } catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
