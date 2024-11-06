// Concatenação de strings usando o operador +
// string nome1 = "Wanderson"; 
// string saudacao1 = "Olá, " + nome1 + "! Bem-vindo."; 
// Console.WriteLine(saudacao1);

// Interpolação de strings usando $
// string nome2 = "Jeane"; 
// string saudacao2 = $"Olá, {nome2}! Bem-vindo."; 
// Console.WriteLine(saudacao2);

// Operador GetType
//int numero1 = 5;
//Console.WriteLine("O tipo da variável é: " + numero1.GetType()); // Verifica o tipo da variável

// Palavra-chave typeof
//Console.WriteLine("Variáveis 'int' é do tipo: " + typeof(int)); // verifica o tipo de uma classe ou estrutura

// Cast/Casting (Conversão de um número do tipo string para int, float ou double usando Parse )
// string valorTexto = "100";
// Console.WriteLine("Valor da variável String: " + valorTexto);
// Console.WriteLine("A variável valorTexto é do tipo: " + valorTexto.GetType());

// int numero2 = int.Parse(valorTexto);
// Console.WriteLine("Valor da variável após conversão para int: " + numero2);
// Console.WriteLine("Após conversão a variável é do tipo: " + numero2.GetType());


// Cast/Casting (Conversão de um número do tipo string para int, float ou double usando Convert )
// string valorEmTexto = "100";
// Console.WriteLine("Valor da variável String: " + valorEmTexto);
// Console.WriteLine("A variável valorTexto é do tipo: " + valorEmTexto.GetType());

// int numeroConvertido = Convert.ToInt32(valorEmTexto);
// Console.WriteLine(numeroConvertido);
// Console.WriteLine("Após concersão a variável numeroConvertido é do tipo: " + numeroConvertido.GetType());


// Converter Qualquer Tipo para String com ToString()
// int numero = 123; 
// Console.WriteLine(numero.GetType());

// string numeroComoString = numero.ToString();
// Console.WriteLine(numeroComoString.GetType());


// Personalização de Formatação para data e hora
// DateTime dataAtual = DateTime.Now; 
// Console.WriteLine(dataAtual);

// string dataFormatada = dataAtual.ToString("dd/MM/yyyy");
// Console.WriteLine(dataFormatada);

// string dataHoraFormatada = dataAtual.ToString("HH:mm:ss");
// Console.WriteLine(dataHoraFormatada);

// Converter Qualquer Tipo para String com ToString() e usando interpolação de Strings
// double preco = 29.99; 
// Console.WriteLine($"O preço é: {preco.ToString("C2")}");


// Formatação de acordo com a localização
decimal valor = 1234.56m; 
string valorUS = valor.ToString("C", new System.Globalization.CultureInfo("en-US"));
Console.WriteLine(valorUS);

string valorBR = valor.ToString("C", new System.Globalization.CultureInfo("pt-BR"));
Console.WriteLine(valorBR);
