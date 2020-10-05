using System;  
using Humanizer;  


namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros = 321651321; 
            string NumeralExtenso;

            Console.Write("digite os numeros:");
            Console.ReadLine(); 

            NumeralExtenso = numeros.ToWords();
            Console.WriteLine($"{numeros} = {NumeralExtenso}");

            Console.Write("pressione ENTER para sair:");
            Console.ReadLine();
        }
    }
}
