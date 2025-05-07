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
            int contadorMes = 1;

            while (contadorMes <= 12)
            // enquanto contador mes for menor ou igual a 12 excecute... 
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                // 0.36% = 0.0036

                Console.WriteLine(" Após " + contadorMes + " mês, você terá R$" + valorInvestido);
                contadorMes++;
            }

            Console.WriteLine("Execução acabou ...");
            Console.ReadLine();

        }
    }
}
