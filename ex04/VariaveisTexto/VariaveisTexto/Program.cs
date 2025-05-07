using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nome
{
    class VariaveisTexto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aula 4");

            char primeiraLetra = '5';
            primeiraLetra = (char)65;
            //para representar 1 caracter tenho que usar aspas simples
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            string titulo = "Ai que gostoso" + ' ' +2025;
            Console.WriteLine(titulo);

            string lista = 
                "item 1 " +
                "Item 2" +
                "Item 3" +
                "Item 5";
            Console.WriteLine(lista);

            Console.WriteLine("Execução acabou ...");
            Console.ReadLine();

        }
    }
}