using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_03_heranca.Modelo
{
    public class Moto : Veiculo
    {
        // Atributos encapsulados
        private bool partidaEletrica { get; set; } 
        private bool  protetorDeCarenagem { get; set; }     
        
        // Construtor
        public Moto(string marca, string modelo, int ano, double velocidadeAtual, bool  partidaEletrica, bool  protetorDeCarenagem ) : base (marca, modelo, ano, velocidadeAtual)
        { 
            this.partidaEletrica = partidaEletrica ; 
            this.protetorDeCarenagem = protetorDeCarenagem ; 
        }

        // Método concreto Empinar é especifico da classe Moto.
        public void Empinar()
        {
            Console.WriteLine("Empinando a moto!");
        }
    }
}
