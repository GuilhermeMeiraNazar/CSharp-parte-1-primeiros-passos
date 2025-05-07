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

            int idadeJoao = 19;
            int quantidadePessoas = 1;
            bool acompanhado = quantidadePessoas >= 2;


            if (idadeJoao >= 18 && acompanhado == true)
                // usamos || para usar a logica OU e && par ausar a logica E , == usando para comparar igualdade
            {
                Console.WriteLine("Joao pode entrar");
            }
            else
            {
                Console.WriteLine("Joao  não pode entrar");

            }

            Console.WriteLine("Execução acabou ...");
            Console.ReadLine();

        }
    }
}