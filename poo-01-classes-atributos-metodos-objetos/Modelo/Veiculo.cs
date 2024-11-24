using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_01_classes_atributos_metodos_objetos.Modelo
{
    public class Veiculo
    {
        // Atributos
        string marca; 
        string modelo; 
        int ano;     
        double velocidadeAtual; 

        // Construtor
        public Veiculo(string marca, string modelo, int ano, double velocidadeAtual) 
        { 
            this.marca = marca; 
            this.modelo = modelo; 
            this.ano = ano; 
            this.velocidadeAtual = velocidadeAtual; 
        }

        // Método concreto Acelerar
        public void Acelerar(double incremento)
        {
            velocidadeAtual += incremento;
            Console.WriteLine($"Acelerando... Velocidade atual {velocidadeAtual} Km/h.");
        }

        // Método concreto Frear
        public void Frear(double decremento)
        {
            velocidadeAtual -= decremento;
            Console.WriteLine($"Freando... Velocidade atual {velocidadeAtual} Km/h");
        }
    }
}
