using poo_02_encapsulamento.Modelo;

Console.WriteLine("POO: Encapsulamento\n");

// Criando um objeto a partir da classe Veiculo
Console.WriteLine("Criando instância da Classe Veiculo");
Veiculo veiculo = new Veiculo("veiculo", "modelo veiculo", 2024, 10);
veiculo.Acelerar(60);
veiculo.Frear(20);
