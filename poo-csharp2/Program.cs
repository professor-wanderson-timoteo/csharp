using poo_csharp.Modelo;

Console.WriteLine("Criando uma instância de Veiculo");
Veiculo objVeiculo = new Veiculo("Ferrari", "Enzo F10", 2025, 10);
objVeiculo.Acelerar(83.8);
objVeiculo.Frear(11.2);

Console.WriteLine("\nCriando uma instância de Moto");
Moto objMoto = new Moto("Honda", "XJ6", 2026,30, true, true);
objMoto.Acelerar(12);
objMoto.Frear(6);
objMoto.Empinar();
