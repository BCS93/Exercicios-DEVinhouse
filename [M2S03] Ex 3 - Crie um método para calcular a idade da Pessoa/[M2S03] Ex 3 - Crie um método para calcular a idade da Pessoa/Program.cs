using _M2S03__Ex_3___Crie_um_método_para_calcular_a_idade_da_Pessoa;

Pessoa pessoa1 = new Pessoa();
{
    Console.WriteLine(" Digite o seu nome:");
    pessoa1.Nome = Console.ReadLine();
    Console.WriteLine("\n Digite o ano do seu nascimento: (ex:1995)");
    pessoa1.DataDeNascimento = int.Parse(Console.ReadLine());
    Console.WriteLine("\n Digite a sua altura:");
    pessoa1.Altura = double.Parse(Console.ReadLine());
    Console.WriteLine("\n Digite o seu peso: ");
    pessoa1.Peso = double.Parse(Console.ReadLine());  
    
};

int idade = Pessoa.CalcularIdade(pessoa1);

Console.WriteLine($"\n A idade de {pessoa1.Nome} é {idade} anos");
Console.ReadKey();