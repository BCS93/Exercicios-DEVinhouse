using _M2S02__Ex_6__7__8__9__10___Projeto_2___Aplicação_Bancária.UI;

bool interruptor = true;
decimal saldo = 0;

List<string> extrato = new List<string>();

while (interruptor)
{
    Menu.mainMenu();
    Console.WriteLine($"\n\n Saldo: {saldo.ToString("C")}");

    switch (Console.ReadLine())
    {
        case "1":
           ConsultarSaldo();
            break;
        case "2":
            Deposito();
            break;
        case "3":
            Saque();
            break;
        case "4":
            Historico();
            break;
        case "0":
            Console.Clear();    
            interruptor = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

  void ConsultarSaldo()
{

    if (saldo < 0)
    {
        Console.Clear();
        Console.WriteLine(" Seu saldo atualizado é de: \n");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($" {saldo.ToString("C")}");
        Console.ReadKey();
    }
    else if (saldo >= 0)
    {
        Console.Clear();
        Console.WriteLine(" Seu saldo atualizado é de: \n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($" {saldo.ToString("C")}");
        Console.ReadKey();
    }

}

  decimal Deposito()
{
    string valorDepositado;
    decimal valor;
    bool interruptor = true;

    while (interruptor)
    {
        Console.ResetColor();
        Console.Clear();
        Console.WriteLine(" Qual o valor do depósito?");
        valorDepositado = Console.ReadLine();
        if (decimal.TryParse(valorDepositado, out valor))
        {
            extrato.Add(valorDepositado);
           
            
            if (decimal.Parse(valorDepositado) < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine(" Não é possível depositar um valor negativo.");
                Console.ReadKey();
            }
            else if (decimal.Parse(valorDepositado) >= 0)
            {

                Console.Clear();
                saldo += decimal.Parse(valorDepositado);
                Console.WriteLine(" Depósito efetuado com sucesso.");
                Console.ReadKey();
                if (saldo < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine(" Seu saldo está negativo.");
                    Console.ReadKey();
                }
                
                break;

            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Caractere inválido, digite novamente");
            Console.ReadKey();
        }
    }
    return saldo;
}

 decimal Saque()
{

    string valorSacado;
    decimal valor;
    bool interruptor = true;

    while (interruptor)
    {
        Console.ResetColor();
        Console.Clear();
        Console.WriteLine(" Qual o valor do saque?");
        valorSacado = Console.ReadLine();        
        if (decimal.TryParse(valorSacado, out valor))
        {
            decimal convertNegativo = -(decimal.Parse(valorSacado));
            extrato.Add(convertNegativo.ToString());

            if (decimal.Parse(valorSacado) < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
                Console.WriteLine(" Não é possível sacar um valor negativo.");
                Console.ReadKey();
            }
            else if (decimal.Parse(valorSacado) >= 0)
            {

                Console.Clear();
                saldo -= decimal.Parse(valorSacado);
                Console.WriteLine(" Saque efetuado com sucesso.");
                Console.ReadKey();
                if(saldo < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Clear();
                    Console.WriteLine(" Seu saldo está negativo.");
                    Console.ReadKey();
                }
                break;

            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("Caractere inválido, digite novamente");
            Console.ReadKey();
        }
    }
    return saldo;
}

 void Historico()
{

    decimal valor;
    string format;
    Console.Clear();
    
    Console.WriteLine(" Histórico de transações: \n");
    foreach(string op in extrato)
    {
        valor = decimal.Parse(op);
        if (valor < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            format = String.Format(" {0:C2}", valor);
            Console.WriteLine($"{format}\n");
            Console.ResetColor();
        }
        else if(valor == 0) 
        {
            Console.ForegroundColor = ConsoleColor.White;
            format = String.Format(" +{0:C2}", valor);
            Console.WriteLine($"{format}\n");
            Console.ResetColor();
        }
        else 
        {
            Console.ForegroundColor = ConsoleColor.Green;
            format = String.Format(" +{0:C2}", valor);
            Console.WriteLine($"{format}\n");
            Console.ResetColor();
        }
    }
    Console.ReadKey();


}