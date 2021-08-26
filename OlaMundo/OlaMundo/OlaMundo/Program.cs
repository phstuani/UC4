using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*declaracao de variavel
             * sempre iniciar com o tipo de varieavel
            string nome = "Pedro Stuani"; 
            //string idade = "23 Aninhos";
            Int16 idade = 23;
            Console.WriteLine("Olá Mundo! Eu sou " + nome + " e tenho " + idade + " anos de idade");
            Console.WriteLine();
            //Console.WriteLine(idade);
            //calculos
            //int num1 = 0;
            //int num2 = 5;
            Int16 num1 = 2035, num2 = 100;
            //Console.WriteLine("" + num1, "" + num2);
            int soma = num1 + num2;
            Console.WriteLine($"Soma do valor 1 {num1} + valor 2 {num2} é: {soma} ");
            //multiplicação
            int multiplica = num1 * num2;
            Console.WriteLine($"A Multiplicação do valor 1 {num1} x valor 2 {num2} é: {multiplica} ");
            double divisaof = (double)num2 / (double)num1;
            Console.WriteLine($"A divisão do valor 1 {num1} / valor 2 {num2} é: {divisaof} ");
            int subtracao = num2 - num1;
            Console.WriteLine($"A subtração do valor 1 {num1} - valor 2 {num2} é: {subtracao} ");
            float resto = (float)num2 % (float)num1;
            Console.WriteLine($"o resto da divisão do valor 1 {num1} / valor 2 {num2} é: {resto} ");

            float cordenadaX = 0.01f;
            Console.WriteLine(cordenadaX);
            double cordenadaY = 00.0d;
            Console.WriteLine(cordenadaY);*/

            //entrada de dois numeros e retornar resultado subtração
            /*Console.Write("digite o primeiro numero: ");
            string numero = Console.ReadLine();
            Console.Write("digite o segundo numero: ");
            string numero1 = Console.ReadLine();
            double resul = Convert.ToDouble(numero) - Convert.ToDouble(numero1);
            Console.WriteLine("O resultado de é: " + resul );*/

            Console.Write("digite o primeiro numero: ");
            int numero = Int32.Parse(Console.ReadLine());
            Console.Write("digite o segundo numero: ");
            int numero1 = Int32.Parse(Console.ReadLine());
            if(numero > numero1)
            {
                Console.WriteLine(numero + " é maior ");
            }
            else
            {
                Console.WriteLine(numero1 + " é maior ");
            }










            Console.ReadKey();
            
        }
    }
}
