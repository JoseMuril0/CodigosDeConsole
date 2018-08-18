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
                Dividir(100, 10);
            } catch(DivisaoPorZeroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        public static void Dividir(int numero, int divisor)
        {
            if (divisor == 0)
            {
                throw new DivisaoPorZeroException("O divisor está igual á zero.");
            }
            int resultado = numero / divisor;
            Console.WriteLine("Divisão aconteceu tudo normal com o resultado de: " + resultado);
            
        }
    }
}
