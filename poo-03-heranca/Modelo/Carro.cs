using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_03_heranca.Modelo
{
    public class Carro : Veiculo
    {
        // Atributos encapsulados
        private bool automatico { get; set; } 
        private int numeroDePortas { get; set; }     

        // Construtor
        public Carro(string marca, string modelo, int ano, double velocidadeAtual, bool automatico, int numeroDePortas) : base (marca, modelo, ano, velocidadeAtual)
        { 
            this.automatico = automatico; 
            this.numeroDePortas = numeroDePortas; 
        }

        // Método concreto Abrir Portas é especifico da classe Carro.
        public void AbrirPortas ()
        {
            Console.WriteLine("As portas do carro estão abertas.");
        }
    }
}
