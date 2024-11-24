using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_04_polimorfismo.Modelo
{
    // Classe derivada Carro
    public class Carro : Veiculo
    {
        // Atributos
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

        // Polimorfismo (Sobrecarga) - simulando uma freada brusca para não bater.
        public void Frear(double decremento, bool puxarFreioDeMao)
        {
            velocidadeAtual -= decremento;
            if(puxarFreioDeMao)
            {
                Console.WriteLine($"O carro freou até a velocidade de {velocidadeAtual} km/h para não bater.");
            }
            else
            {
                Console.WriteLine($"O carro freou lentamente até {velocidadeAtual} km/h.");
            }
        }

        // Polimorfismo (Sobrecarga) - simulando um cavalinho de pau
        public void Frear(double decremento, bool puxarFreioDeMao, bool virouVolante)
        {
            velocidadeAtual -= decremento;
            if(puxarFreioDeMao && virouVolante)
            {
                Console.WriteLine($"O motorista do carro puxou o freio de mão e virou o volante realizando um cavalinho de pau, quando estava a {velocidadeAtual} Km/h.");
            }
            else
            {
                Console.WriteLine($"O carro freou até {velocidadeAtual} km/h.");
            }
        }
    }
}
