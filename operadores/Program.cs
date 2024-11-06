//Operadores:
// Operadores Aritméticos
double resultado1 = 10 + 8 + 12 / 3;
Console.WriteLine(resultado1);

double resultado2 = (10 + 8 + 12) / 3;
Console.WriteLine(resultado2);

double resultado3 = (2 + 8) * 2 / 4;
Console.WriteLine(resultado3);

// Operadores de Lógicos
// Operador AND(&&)
bool a1 = true; 
bool b1 = false; 
Console.WriteLine(a1 && b1);

// Operador OR(||)
bool a2 = true; 
bool b2 = false; 
Console.WriteLine(a2 || b2);

// Operadaor NOT(!)
bool a3 = true; 
Console.WriteLine( !a3 );

//Operador XOR(^)
bool a4 = true; 
bool b4 = false; 
Console.WriteLine(a4 ^ b4);

// Precedência de operadores
bool a5 = false; 
bool b5 = false; 
bool c5 = false;
bool resultado4 = !a5 || b5 && c5; // ! tem maior precedência
Console.WriteLine(resultado4);

bool a = true; 
bool b = false; 
bool c = false;
bool resultado5 = !a || (b && c); // Parênteses tem maior precedência
Console.WriteLine(resultado5);

