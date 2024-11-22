// Estrutura de Repetição while
// int contador = 0;
// while (contador  <  10)
// {
//     Console.WriteLine($"Contador: {contador}.");
//     contador++;
// }


// Random numeroAleatorio = new Random();
// int numero = numeroAleatorio.Next(1, 101);
// int contador = 0;
// Console.WriteLine($"Número Alvo: {numero}");
// // Loop que incrementa o contador até ele atingir o número alvo
// while (contador  >  numero)
// {
//     Console.WriteLine($"Contador: {contador}.");
//     contador++;
// }
// Console.WriteLine($"Contador atingiu o número alvo: {contador}");




// Estrutura de Repetição do-while
// int numero = 0; 

// do
// {
//     Console.WriteLine($"Número: {numero}");
//     numero++;
// } while  (numero < 10);


// Estrutura de Repetição for
// for (int i = 0; i <= 10; i++) 
// { 
//     Console.WriteLine($"Valor de i: {i}"); 
// }


// Estrutura de Repetição foreach
// string[] nomes = { "Wanderson", "Jeane", "Ryan" }; 
// foreach (string nome in nomes) 
// { 
//     Console.WriteLine(nome); 
// }










// Exercícios
// 1 - Crie um algoritmo que some todos os números pares de 1 a 100 e exiba o resultado no console.
// int soma = 0;

// for (int i = 1; i <= 100; i++)
// {
//     if (i % 2 == 0)
//     {
//         soma += i;
//     }
// }

// Console.WriteLine($"A soma de todos os números pares de 1 a 100 é: {soma}");


// 2 - Crie um algoritmo que faça uma contagem regressiva de 10 a 1 e exiba "Decolar!" ao final.
// for (int i = 10; i >= 1; i--)
// {
//     Console.WriteLine(i);
// }

// Console.WriteLine("Decolar!");














// 3 - Crie um algoritmo que conte o número de vogais (a, e, i, o, u) na palavra e exiba o resultado.
// Console.WriteLine("Digite uma palavra:");
// string palavra = Console.ReadLine().ToLower(); // Converte para minúsculas
// int contagemVogais = 0;

// foreach (char letra in palavra)
// {
//     if ("aeiou".Contains(letra)) // Verifica se a letra é uma vogal
//     {
//         contagemVogais++;
//     }
// }

// Console.WriteLine($"Número de vogais: {contagemVogais}");


// 4 - Crie um algoritmo que solicite uma palavra ou frase do usuário, verifique se é um palíndromo, ou seja, se é igual de trás para frente. Exemplo: ana, radar etc...
// Console.WriteLine("Digite uma palavra ou frase:");
// string entrada = Console.ReadLine().ToLower().Replace(" ", ""); // Converte para minúsculas e remove espaços
// string reverso = new string(entrada.Reverse().ToArray()); // Inverte a string

// if (entrada == reverso)
// {
//     Console.WriteLine("É um palíndromo!");
// }
// else
// {
//     Console.WriteLine("Não é um palíndromo.");
// }


// 5 - Crie um algoritmo onde o computador escolhe um número aleatório entre 1 e 100, e o usuário deve adivinhar. Após cada tentativa, o programa indica se o número é maior ou menor.

Random random = new Random();
int numeroAleatorio = random.Next(1, 101); // Gera o número aleatório entre 1 e 100
int palpite;
int contador = 0;
bool acertou = false;

Console.WriteLine("Tente adivinhar o número entre 1 e 100:");

while (!acertou)
{
    Console.Write("Digite seu palpite: ");
    palpite = int.Parse(Console.ReadLine());

    if (palpite < numeroAleatorio)
    {
        Console.WriteLine("O número é maior!");
        contador++;
    }
    else if (palpite > numeroAleatorio)
    {
        Console.WriteLine("O número é menor!");
        contador++;
    }
    else
    {
        contador++;
        Console.WriteLine($"Parabéns! Você adivinhou o número sorteado '{numeroAleatorio}' depois de {contador} tentativas.");
        acertou = true;
    }
}
