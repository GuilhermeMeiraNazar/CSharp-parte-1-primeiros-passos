using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 6");

            for(int contadorLinha =0; contadorLinha<10; contadorLinha++)
            {
                for(int contadorColuna = 0; contadorColuna < 10; contadorColuna++)
                {
                    Console.Write("*");
                    if(contadorColuna >= contadorLinha)
                    {
                        break;
                    }
                }
                Console.WriteLine();

            }

            Console.WriteLine("Execução acabou ...");
            Console.ReadLine();

        }
    }
}
