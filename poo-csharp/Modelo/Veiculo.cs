using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_csharp.Modelo
{
    public class Veiculo
    {
        // Atributos
        private string marca { get; set; } 
        private string modelo { get; set; } 
        private int ano { get; set; }     
        protected double velocidadeAtual { get; set; } 

        // Construtor
        public Veiculo(string marca, string modelo, int ano, double velocidadeAtual) 
        { 
            this.marca = marca; 
            this.modelo = modelo; 
            this.ano = ano; 
            this.velocidadeAtual = 0; 
        }

        // Métodos Acelerar e Frear
        public virtual void Acelerar(double incremento)
        {
            velocidadeAtual += incremento;
            Console.WriteLine($"Acelerando... Velocidade atual {velocidadeAtual} Km/h.");
        }
        public void Frear(double decremento)
        {
            velocidadeAtual -= decremento;
            Console.WriteLine($"Freando... Velocidade atual {velocidadeAtual} Km/h");
        }
    }
}
