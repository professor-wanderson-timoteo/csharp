using calculadora.Modelo;

Calculadora calc = new Calculadora();

Console.WriteLine("Calculadora Básica");
Console.WriteLine("Escolha uma operação: +, -, *, /: ");
string? operacao = Console.ReadLine();


Console.WriteLine("Digite o primeiro número:");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
double numero2 = Convert.ToDouble(Console.ReadLine());

double resultado;

switch (operacao)
{
    case "+":
        resultado = calc.Somar(numero1, numero2);
        break;
    case "-":
        resultado = calc.Subtrair(numero1, numero2);
        break;
    case "*":
        resultado = calc.Multiplicar(numero1, numero2);
        break;
    case "/":
        resultado = calc.Dividir(numero1, numero2);
        break;
    default:
        Console.WriteLine("Operação inválida.");
        return;
}

Console.WriteLine($"Resultado: {numero1} {operacao} {numero2} = {resultado}");
        