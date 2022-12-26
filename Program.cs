using System;

namespace Tipos
{
    public class Tipos
    {
        public static void Main(string[] args)
        {
            // declaracao de tipos de variáveis na sintaxe de C#
            var nome = "Junior";
            string aprender = "aprendendo a programar";
            int idade = 18;
            bool verdadeiro = true;
            byte mes = 12;
            decimal meses = 18.9m;
            double ano = 2022;
            float dia = 26;
            long anoDepoisDeCristo = 2000;

            Console.WriteLine($"Olá, {nome}. Você está {aprender} e tem {idade} anos.");
            Console.WriteLine($"Estamos no dia {dia}, no mês {mes} e ano {ano}.");
            Console.WriteLine($"{verdadeiro}. Estamos no ano {anoDepoisDeCristo} depois de Cristo.");
            Console.WriteLine(meses); 

        }
    }
}