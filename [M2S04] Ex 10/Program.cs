using _M2S04__Ex_10;



Pessoa pessoa1 = new Pessoa("Bruno", 29, 72.2, 1.70);
Pessoa pessoa2 = new Pessoa("Alana", 27, 52.3, 1.58);
Pessoa pessoa3 = new Pessoa("Kaito", 2, 14.2, 0.82);


double imc = pessoa1.CalculoIMC();
Console.WriteLine($"O cálculo IMC de {pessoa1.Nome}, de {pessoa1.Idade} anos, apontou que a sua categoria é: {pessoa1.CategoriaIMC(imc)}");


imc = pessoa2.CalculoIMC();
Console.WriteLine($"\nO cálculo IMC de {pessoa2.Nome}, de {pessoa2.Idade} anos, apontou que a sua categoria é: {pessoa2.CategoriaIMC(imc)}");


imc = pessoa3.CalculoIMC();
Console.WriteLine($"\nO cálculo IMC de {pessoa3.Nome}, de {pessoa3.Idade} anos, apontou que a sua categoria é: {pessoa3.CategoriaIMC(imc)}");
Console.ReadKey();