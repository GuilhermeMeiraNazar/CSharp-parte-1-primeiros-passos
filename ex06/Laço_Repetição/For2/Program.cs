﻿using System;
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
            double delta = 1.0036;

            for(int contadorAno =1;contadorAno <=5; contadorAno++)
            {
                for (int contadorMes =1; contadorMes <= 12;contadorMes++) 
                {
                    valorInvestido *= delta;
                    Console.WriteLine("No ano " + contadorAno + " do mês " + contadorMes + " Seu dinehiro rendeu R$" + valorInvestido);
                }
                delta += 0.0010;

            }
            Console.WriteLine("Execução acabou ...");
            Console.ReadLine();

        }
    }
}
