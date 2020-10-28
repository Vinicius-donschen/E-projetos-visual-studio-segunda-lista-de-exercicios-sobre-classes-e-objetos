using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_02___classes_e_objetos
{
    class Calculadora
    {
        public double adicao(double num1, double num2)
        {
            double resultado = 0;
            resultado = num1 + num2;
            return resultado;
        }

        public double subtracao(double num1, double num2)
        {
            double resultado = 0;
            resultado = num1 - num2;
            return resultado;
        }

        public double multiplicacao(double num1, double num2)
        {
            double resultado = 0;
            resultado = num1 * num2;
            return resultado;
        }

        public double divisao(double num1, double num2)
        {
            double resultado = 0;
            resultado = num1 / num2;
            return resultado;
        }

        public void operacao()
        {
            Console.WriteLine("digite o primeiro numero");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo numero");
            double num2 = double.Parse(Console.ReadLine());

            short opcao = 0;

            Console.WriteLine("escolha uma operação \n1-soma \n2-subtração \n3-multiplicação \n4-divisão");
            opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    double resultado = adicao(num1, num2);
                    Console.WriteLine($"resultado da soma é: {resultado}");
                    break;
                case 2:
                    resultado = subtracao(num1, num2);
                    Console.WriteLine($"resultado da subtração é: {resultado}");
                    break;
                case 3:
                    resultado = multiplicacao(num1, num2);
                    Console.WriteLine($"resultado da multiplicação é: {resultado}");
                    break;
                case 4:
                    resultado = divisao(num1, num2);
                    Console.WriteLine($"resultado da divisão é: {resultado}");
                    break;
                default:
                    Console.WriteLine("escolha uma operação");
                    break;
            }
        }
    }
}
