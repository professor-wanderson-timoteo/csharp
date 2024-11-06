// Contatenação de strings usando o operador +
string nome1 = "Wanderson"; 
string saudacao1 = "Olá, " + nome1 + "! Bem-vindo."; 
Console.WriteLine(saudacao1);

// Interpolação de strings usando $
string nome2 = "Jeane"; 
string saudacao2 = $"Olá, {nome2}! Bem-vindo."; 
Console.WriteLine(saudacao2);

// Operador GetType
int numero1 = 5;
Console.WriteLine("O tipo da variável é: " + numero1.GetType()); // Verifica o tipo da variável

// Palavra-chave typeof
Console.WriteLine("Variáveis 'int' é do tipo: " + typeof(int)); // verifica o tipo de uma classe ou estrutura

// Cast/Casting (Conversão de um número do tipo string para int, float ou double usando Parse )
string valorTexto = "100";
Console.WriteLine("String: " + valorTexto);
Console.WriteLine("A variável valorTexto é do tipo: " + valorTexto.GetType());

int numero2 = int.Parse(valorTexto);
Console.WriteLine("int: " + numero2);
Console.WriteLine("A variável numeroParse é do tipo: " + numero2.GetType());