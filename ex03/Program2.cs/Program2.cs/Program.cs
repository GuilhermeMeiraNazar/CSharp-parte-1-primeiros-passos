using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _3_Exercicio
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá,mundo.Projeto no Visual Studio!");
            int idade;
            idade = 32;
            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            idade = 10*2;
            Console.WriteLine(idade);
            //WhiteLine Escreve e pula a linha

            idade = (10+5)*2;
            Console.Write(idade);
            //White Escreve e NÂO pula a linha

            idade = (10 + 5) * 2;
            Console.WriteLine("Essa é a sua idade:" + idade);
            //o + entre "Essa é a sua idade:" e  idade é usado para concatenar (juntar) a string com o numero inteiro

            idade = (10 + 5) * 2;
            Console.WriteLine("Essa é a sua idade:" + idade + "Mais alguma coisa" + idade + "mais outra coisa");

            Console.WriteLine("A execução acabou. tecle ener para finalizar...");
            Console.ReadLine(); 
        }
    }
}
