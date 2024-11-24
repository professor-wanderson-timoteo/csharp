using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_04_polimorfismo.Modelo
{
    // Classe derivada Moto
    public class Moto : Veiculo
    {
        // Atributos
        private bool partidaEletrica { get; set; } 
        private bool  protetorDeCarenagem { get; set; }     
        
        // Construtor
        public Moto(string marca, string modelo, int ano, double velocidadeAtual, bool  partidaEletrica, bool  protetorDeCarenagem ) : base (marca, modelo, ano, velocidadeAtual)
        { 
            this.partidaEletrica = partidaEletrica ; 
            this.protetorDeCarenagem = protetorDeCarenagem ; 
        }

        // Polimorfismo (Sobrescrita) - Usando o modificador override para criar uma sobrescrita do método Acelerar.
        public override void Acelerar(double incremento)
        {
            velocidadeAtual += incremento;
            Console.WriteLine($"A moto acelerou e atingiu a velocidade de {velocidadeAtual} km/h.");
        }

        // Método concreto Empinar é especifico da classe Moto.
        public void Empinar()
        {
            Console.WriteLine("Empinando a moto!");
        }
    }
}
