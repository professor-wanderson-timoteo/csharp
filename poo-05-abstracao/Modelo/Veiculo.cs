using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_05_abstracao.Modelo
{
    // Classe base ABSTRATA Veiculo
    public abstract class Veiculo
    {
        // Atributos encapsulados com modificadores de acesso private, protected, getters e setters 
        private string marca;
        private string modelo;
        private int ano;    
        protected double velocidadeAtual;

        // Construtor
        public Veiculo(string marca, string modelo, int ano, double velocidadeAtual) 
        { 
            this.marca = marca; 
            this.modelo = modelo; 
            this.ano = ano; 
            this.velocidadeAtual = velocidadeAtual; 
        }
        
        // Getters e Setters
        public string GetMarca() { 
            return marca;  
        }
        public void SetMarca(string marca) { 
            this.marca = marca; 
        }


        public string GetModelo() { 
            return modelo;  
        }
        public void SetModelo(string modelo) { 
            this.modelo = modelo; 
        }
        
        public int GetAno() { 
            return ano; 
        }

        public void SetAno(int ano) { 
            this.ano = ano; 
        }
        
        public double GetVelocidadeAtual() { 
            return velocidadeAtual;  
        }

        public void SetVelocidadeAtual(int velocidadeAtual) { 
            this.velocidadeAtual = velocidadeAtual; 
        }
        
        // Método concreto Acelerar, adicionado modificar virtual para permitir polimorfismo (sobrescrita)
        public virtual void Acelerar(double incremento)
        {
            velocidadeAtual += incremento;
            Console.WriteLine($"Acelerando... Velocidade atual {velocidadeAtual} Km/h.");
        }

        // Método concreto Frear
        public void Frear(double decremento)
        {
            velocidadeAtual -= decremento;
            Console.WriteLine($"Freando... Velocidade atual {velocidadeAtual} Km/h.");
        }

         /** Método abstrato para obter dados do veiculo
          ** Método abstract não tem implementação concreta deve ser implementado em todas classes derivadas
          */
          public abstract void ObterDadosDoVeiculo();
    }
}
