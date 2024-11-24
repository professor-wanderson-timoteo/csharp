using poo_05_abstracao.Modelo;

Console.WriteLine("POO: Abstração\n");

/* Veiculo agora é abstrata e classes abstratas não podem ser instânciadas
**Portanto, ao tentar instanciar Veiculo ocorrerá um erro
*/
// Console.WriteLine("Criando instância da Classe Veiculo");
// Veiculo veiculo = new Veiculo("veiculo", "modelo veiculo", 2024, 10);
// veiculo.Acelerar(60);
// veiculo.Frear(20);

Console.WriteLine("\nCriando instância da Classe Moto");
Moto harleyDavidson = new Moto("Harley Davidson", "Turbo S10", 2025, 30, true, true);
harleyDavidson.Acelerar(55);
harleyDavidson.Frear(10);
harleyDavidson.Empinar();
harleyDavidson.ObterDadosDoVeiculo();

Console.WriteLine("\nCriando instância da Classe Carro");
Carro ferrari = new Carro("Ferrari", "Ferrari Enzo", 2024, 10, true, 2);
ferrari.Acelerar(260);
ferrari.Frear(200, true, true);
ferrari.AbrirPortas();
ferrari.ObterDadosDoVeiculo();
