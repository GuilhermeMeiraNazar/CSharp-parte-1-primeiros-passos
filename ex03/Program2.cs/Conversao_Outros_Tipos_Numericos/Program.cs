using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao_Outros_Tipos_Numericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 4");

            double salario;
            salario = 1200.50;
            // 32bits

            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            // tenho que declarar que eu quero converter para inteiro com o (int)
            Console.WriteLine(salarioEmInteiro);

            long idade;
            idade = 13000000000000000;
            Console.WriteLine(idade);
            //long eh um inteiro que cabe numeros muito grandes 64bits

            short algumacoisa;
            algumacoisa = 100;
            Console.WriteLine(algumacoisa);
            //short eh para numeros inteiros pequenos 16bits

            float xcoisa;
            xcoisa = 1.80f;
            // baixa precisao , o f eh uma referencia para o c# saber que voce esta escrevendo certo

            Console.WriteLine("Execução acabou ...");
            Console.ReadLine();

        }
    }
}