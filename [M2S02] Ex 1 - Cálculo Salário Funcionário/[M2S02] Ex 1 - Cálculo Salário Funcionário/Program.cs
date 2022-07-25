string nome;
int anoDeNascimento;
double salario;
double reajuste;

Console.WriteLine("\nDigite o nome do(a) funcionário(a): ");
nome = Console.ReadLine();

Console.WriteLine("\nDigite o ano de nascimento: ");
anoDeNascimento = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nDigite o salário do(a) funcionário(a): ");
salario = double.Parse(Console.ReadLine());

Console.WriteLine("\nDigite o valor do reajuste (%): ");
reajuste = double.Parse(Console.ReadLine());


double salarioReajustado = salario + (salario * (reajuste/100));
int idade =  DateTime.Now.Year - anoDeNascimento;

Console.WriteLine("\nO salário reajustado do(a) funcionário(a) " + nome + ", de "+idade+" anos, é R$"+salarioReajustado);
Console.ReadLine();







