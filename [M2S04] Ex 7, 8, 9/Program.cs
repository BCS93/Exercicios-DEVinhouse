using _M2S04__Ex_7__8__9;

bool a = false;

Console.WriteLine($"Quando 'a' possui o valor {a}, significa que: {a.TradutorDeBool()}");


a = true;

Console.WriteLine($"\nQuando 'a' possui o valor {a}, significa que: {a.TradutorDeBool()}\n\n"); 
Console.ReadKey();


int valor1 = 2;
decimal valor2 = 2.78M;
double valor3 = 2.5;


//Método principal
Console.WriteLine($"MÉTODO MULTIPLICADOR: {valor1} * {valor1} = {valor1.Multiplicador()}\n");


//Sobrecargas:


//receber decimal ao invés de int
Console.WriteLine($"DECIMAL: {valor2} * {valor2} = {valor2.Multiplicador()}\n");


//receber mais de 2 parâmetros
Console.WriteLine($"DOIS OU MAIS PARÂMETROS: {valor1} * {valor3} * 5,5 = {valor1.Multiplicador(valor3, 5.5)}\n");


//receber parâmetros opcionais
Console.WriteLine($"PARÂMETROS OPCIONAIS: {valor1} * {valor3} * 2,5(opcional) * 2(opcional) = {valor1.Multiplicador(valor3, num3: 2.5, num4: 2)}\n");
Console.ReadKey();