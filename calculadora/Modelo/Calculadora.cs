using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculadora.Modelo
{
    public class Calculadora
    {
        // Método para soma
        public double Somar(double a, double b)
        {
            return a + b;
        }

        // Método para subtração
        public double Subtrair(double a, double b)
        {
            return a - b;
        }

        // Método para multiplicação
        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        // Método para divisão com verificação de divisor zero
        public double Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não permitida.");
                return double.NaN;
            }
            return a / b;
        }
    }
}