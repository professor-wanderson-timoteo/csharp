using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_classes.Modelo
{
    public class Veiculo
    {
        // Atributos
        private string marca;
        private string modelo;
        private int ano;
        protected double velocidadeAtual;

        // construtor
        public Veiculo(string marca, string modelo, int ano, double velocidadeAtual) 
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
            this.velocidadeAtual = 0;
        }

        // Métodos
        public void Acelerar()
        {
            Console.WriteLine($"O {modelo} acelerou!");
        }

        public void Frear()
        {
            Console.WriteLine($"O {modelo} freou!");
        }
    }
}
