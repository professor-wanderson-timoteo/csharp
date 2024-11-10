// Estrutura condicional simples
// double nota1 = 5; 
// double nota2 = 8.0;
// double nota3 = 6.8;
// double media = (nota1 + nota2 + nota3) / 3;
// if (media >= 7)
// {
//     Console.WriteLine($"Média {media:F2}: Aprovado");
// }
// else
// {
//     Console.WriteLine($"Média {media:F2}: Recuperação");
// }


// Estrutura condicional if aninhado
// double nota4 = 5; 
// double nota5 = 8.0;
// double nota6 = 5.0;
// double mediaNota = (nota4 + nota5 + nota6) / 3;
// if (mediaNota >= 7)
// {
//     Console.WriteLine($"Média {mediaNota:F2}: Aprovado");
// }
// else if (mediaNota >= 5 && mediaNota < 7)
// {
//     Console.WriteLine($"Média {mediaNota:F2}: Recuperação");
// }
// else
// {
//     Console.WriteLine($"Média {mediaNota:F2}: Reprovado");
// }


// if aninhado
// Console.WriteLine("Digite uma vogal");
// string? letra = Console.ReadLine();
// if (letra == "a" || letra == "A")
// {
//     Console.WriteLine($"Você digitou a vogal: {letra}");
// }
// else if (letra == "e" || letra == "E")
// {
//     Console.WriteLine($"Você digitou a vogal: {letra}");
// }
// else if(letra == "i" || letra == "I")
// {
//     Console.WriteLine($"Você digitou a vogal: {letra}");
// }
// else if(letra == "o" || letra == "O")
// {
//     Console.WriteLine($"Você digitou a vogal: {letra}");
// }
// else if(letra == "u" || letra == "U")
// {
//     Console.WriteLine($"Você digitou a vogal: {letra}");
// }
// else
// {
//     Console.WriteLine($"A letra {letra} não é uma vogal.");
// }




// Switch Case
// string dia = "Sábado"; 

// switch (dia) 
// { 
//     case "Sábado": 
//         Console.WriteLine("Sábadoooo galera!");
//         break; 
//     case "Domingo": 
//         Console.WriteLine("Domingão, hoje é dia de assistir o malvadão!");
//         break; 
//     default: 
//         Console.WriteLine("Hoje é dia de semana, para de preguiça, levanta e vai trabalhar!"); 
//         break; 
// }




// Console.WriteLine("Digite uma vogal:"); 
// string? letra = Console.ReadLine();
// string letraMinuscula = letra.ToLower();
// //string letraMaiuscula = letra.ToUpper();
// switch (letraMinuscula) 
// { 
//     case "a": 
//     case "e":
//     case "i": 
//     case "o":
//     case "u":
//         Console.WriteLine($"A letra '{letraMinuscula}' é uma vogal.");
//         break; 
//     default: 
//         Console.WriteLine($"A letra '{letraMinuscula}' não é uma vogal"); 
//         break; 
// }






//Operador Ternário
// int idade = 15; 
// string mensagem = idade >= 18 ? "Maior de idade" : "Menor de idade"; 
// Console.WriteLine(mensagem);






//Exercícios

// bool ehMaiorIdade = false;
// bool possuiAutorizacaoResponsavel = true;

// if(ehMaiorIdade || possuiAutorizacaoResponsavel)
// {
//     Console.WriteLine("Entrada liberada");
// }
// else
// {
//     Console.WriteLine("Entrada não liberada");
// }

// Outra opção com operador ternário
// string resultado = ehMaiorIdade || possuiAutorizacaoResponsavel ? "Entrada liberada" : "Entrada não liberada";
// Console.WriteLine(resultado);





// bool possuiPresencaMinima = true;
// double media3 = 7.0;

// if (possuiPresencaMinima && media3 >= 7)
// {
//     Console.WriteLine($"Média {media3:F1}: Aprovado");
// }
// else
// {
//     Console.WriteLine($"Média {media3:F1}: Reprovado");
// }




bool choveu = true;
bool estaTarde = false;

if(!choveu && !estaTarde)
{
    Console.WriteLine("Vou pedalar!");
}
else{
    Console.WriteLine("Vou pedalar outro dia.");
}