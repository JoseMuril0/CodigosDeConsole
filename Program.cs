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
            Console.WriteLine("Informe um valor: ");
            double valor = double.Parse(Console.ReadLine());

            double Juros = valor * 0.10;
            Console.WriteLine("Juros de 10% no valor digitado: R$ " + Juros);



            Console.ReadLine();
        }
    }
}
