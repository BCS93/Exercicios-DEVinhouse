
using _M2S04__Ex_5_e_6;

bool interruptor = true;
string opcao;
string nome;
int conta;
double saldo = 0;

Conta novaConta ;


double valorDigitado;



Cadastro();
while (interruptor)
{
    Menu();
    switch (opcao)
    {
        case "1":
            Console.Clear();
            Console.WriteLine("Qual o valor a ser depositado?");
            valorDigitado = double.Parse(Console.ReadLine());
            novaConta.Depositar(valorDigitado);
            break;

        case "2":
            Console.Clear();
            Console.WriteLine("Qual o valor a ser sacado?");
            valorDigitado = double.Parse(Console.ReadLine());
            novaConta.Sacar(valorDigitado);
            break;
        case "3":
            Console.Clear();
            Console.WriteLine(novaConta.ObterSaldo().ToString("C"));
            Console.ReadKey();
            break;
        case "4":
            Console.Clear();
            Console.WriteLine($"Nome: {novaConta.ObterNomeCliente()} \nConta: {novaConta.ObterNumeroConta()}");
            Console.ReadKey();
            break;
        case "5":
            Console.Clear();
            Console.WriteLine("Saindo...");
            interruptor = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opção Inválida");
            Console.ReadKey();
            break;

    }
}

void Menu()
{
    Console.Clear();
    Console.WriteLine("Selecione uma operação");
    Console.WriteLine("\n(1)Depositar  \n(2)Sacar  \n(3)Ver o Saldo  \n(4)Ver Informações da Conta  \n(5)Sair ");
    opcao = Console.ReadLine();

}

 void Cadastro()
{
    Console.WriteLine("Bem vindo, faça o login na sua conta.");

    Console.WriteLine("\nDigite seu Nome: ");
    nome = Console.ReadLine();

    Console.WriteLine("\nDigite sua Conta: ");
    conta = int.Parse(Console.ReadLine());

    novaConta = new Conta(nome, conta, saldo);
}