using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 5");

            int idadeJoao = 17;
            int quantidadePessoas = 1;
            if (idadeJoao >= 18)
            {
                Console.WriteLine("Joao tem mais do que 18 anos");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais do que 18 anos mas esta acompnhado");
                }
                else
                {
                    Console.WriteLine("João nao tem 18 anos e não esta acompanhado");
                }
            }

            Console.WriteLine("Execução acabou ...");
            Console.ReadLine();

        }
    }
}