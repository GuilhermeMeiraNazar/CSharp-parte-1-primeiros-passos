using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 6");

            double valorInvestido = 1000;

            for(int contadorMes = 1; contadorMes <= 12; contadorMes = contadorMes + 1)
            // for = se for verdadeiro então ....
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + contadorMes + " meses, Você terá R$" + valorInvestido);
            }


            Console.WriteLine("Execução acabou ...");
            Console.ReadLine();

        }
    }
}