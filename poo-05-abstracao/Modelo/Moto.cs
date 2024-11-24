using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_05_abstracao.Modelo
{
    public class Moto : Veiculo
    {
        // Atributos encapsulados
        private bool partidaEletrica;
        private bool  protetorDeCarenagem;    
        
        // Construtor
        public Moto(string marca, string modelo, int ano, double velocidadeAtual, bool  partidaEletrica, bool  protetorDeCarenagem ) : base (marca, modelo, ano, velocidadeAtual)
        { 
            this.partidaEletrica = partidaEletrica ; 
            this.protetorDeCarenagem = protetorDeCarenagem ; 
        }

        // Getters e Setters
        public bool GetPartidaEletrica() { 
            return partidaEletrica; 
        }
        public void SetPartidaEletrica(bool partidaEletrica) { 
            this.partidaEletrica = partidaEletrica; 
        }

        public bool GetProtetorDeCarenagem() { 
            return protetorDeCarenagem; 
        }
        public void SetProtetorDeCarenagem(bool protetorDeCarenagem) { 
            this.protetorDeCarenagem = protetorDeCarenagem; 
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

        // Implementação concreta do método abstrato ObterDadosDoVeiculo
        public override void ObterDadosDoVeiculo()
        {
            Console.WriteLine($"\nDados da moto:\n");
            Console.WriteLine($"Marca: {GetMarca()}");
            Console.WriteLine($"Modelo: {GetModelo()}");
            Console.WriteLine($"Ano: {GetAno()}");
            Console.WriteLine($"Partida elétrica:  {(partidaEletrica ? "Sim" : "Não")}");
            Console.WriteLine($"Protetor de carenagem: {(protetorDeCarenagem  ? "Sim" : "Não")}");
        }
    }
}
