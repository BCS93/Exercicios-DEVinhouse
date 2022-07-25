using _M2S02__Roteiro_de_Projeto_1___Aplicação_Calculadora.UI;

bool interruptor = true;

while (interruptor)
{
    Menu.mainMenu();

    switch(Console.ReadLine())
    {
        case "1":            
            Operacoes.adicao();
            break;
        case "2":
            Operacoes.subtracao();
            break;
        case "3":
            Operacoes.multiplicacao();
            break;
        case "4":
            Operacoes.divisao();
            break;
        case "0":
            interruptor = false;
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

