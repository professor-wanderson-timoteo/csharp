using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio_classes.Modelo
{
    public class Veiculo
    {
        // Atributos
        string marca;
        string modelo;
        int ano;

        // construtor
        public Veiculo(string marca, string modelo, int ano) 
        {
            this.marca = marca;
            this.modelo = modelo;
            this.ano = ano;
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
