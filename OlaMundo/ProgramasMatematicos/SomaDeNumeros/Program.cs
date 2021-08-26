using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaDeNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
              string -> texto
              int -> numeros inteiros
              double e float -> numeros quebrados
             */


            double numero = 0;
            double numero1 = 0;
            Console.WriteLine("Vamos somar alguns numeros!");
            Console.Write("Coloque o primeiro numero: ");
            numero = Convert.ToDouble (Console.ReadLine());
            Console.Write("Coloque o segundo numero: ");
            numero1 = Convert.ToDouble (Console.ReadLine());
            double soma = Convert.ToDouble (numero) + Convert.ToDouble (numero1);
            Console.WriteLine("A soma de " + numero + " + " + numero1 + " é: " + soma);

            Console.WriteLine("----------------------------------------");

            
            Console.WriteLine("Vamos Multiplicar alguns numeros!");
            Console.Write("Coloque o primeiro numero: ");
            numero = Convert.ToDouble (Console.ReadLine());
            Console.Write("Coloque o segundo numero: ");
            numero1 = Convert.ToDouble (Console.ReadLine());
            double mult = Convert.ToDouble(numero) * Convert.ToDouble(numero1);
            Console.WriteLine("A multiplicação de " + numero + " x " + numero1 + " é: " + mult);

            Console.WriteLine("----------------------------------------");

            
            Console.WriteLine("Vamos subtrair alguns numeros!");
            Console.Write("Coloque o primeiro numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            Console.Write("Coloque o segundo numero: ");
            numero1 = Convert.ToDouble(Console.ReadLine());
            double sub = Convert.ToDouble(numero) - Convert.ToDouble(numero1);
            Console.WriteLine("A subtração de " + numero + " - " + numero1 + " é: " + sub);








            Console.ReadKey();

        }
    }
}
