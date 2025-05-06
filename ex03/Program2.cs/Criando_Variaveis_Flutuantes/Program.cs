using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criando_Variaveis_Flutuantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 3 Criando variaveis ponto flutuante");

            double salario;
            salario = 1300.50;
            Console.WriteLine(salario);

            double idade;
            idade = 15.0 / 2;
            Console.WriteLine(idade);
            // se não colocar o .0 se perde a propriedade de um numero com ponto

            Console.WriteLine("Execução acabou ...");
            Console.ReadLine();

        }
    }
}
