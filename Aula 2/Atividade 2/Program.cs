﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            // Opção correta: O código não compila, pois 3.14 não "cabe" dentro de um inteiro.
            // A variavel pi estava anteriormente declarada com int
            // Foi alterada pra doble e coloquei saida para ser mostrada em tela
            Console.WriteLine("O numero de pi e = " + pi);
            Console.ReadLine();
        }
    }
}
