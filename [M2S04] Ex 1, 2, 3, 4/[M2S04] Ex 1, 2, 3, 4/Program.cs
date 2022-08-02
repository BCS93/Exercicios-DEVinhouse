using _M2S04__Ex_1__2__3__4;

bool interruptor = true;
string estado = "desligada";

Random rand = new Random();

Lampada lampadaNova1 = new Lampada(7, 127);


while (interruptor)
{
    Menu();
    Console.WriteLine($"status: {estado}\n");
    Console.WriteLine(lampadaNova1);

    switch (Console.ReadLine())
    {
        case "1":
            Console.Clear();

            if (estado == "ligada")
            {
                Console.WriteLine("A lâmpada já está ligada");
                Console.ReadKey();
            }
            else if (estado == "queimada")
            {
                Console.WriteLine("A lâmpada não funciona mais.");
                Console.ReadKey();
            }
            else
            {
                int probabilidade = rand.Next(1, 101);

                if (probabilidade <= 15) // probabilidade de 15%
                {
                    Console.WriteLine("A lâmpada queimou");
                    Console.ReadKey();
                    estado = "queimada";
                }
                else
                {
                    Lampada.Liga();
                    estado = "ligada";
                }
            }
            break;

        case "2":
            Console.Clear();
            if (estado == "desligada")
            {
                Console.WriteLine("A lâmpada já está desligada");
                Console.ReadKey();
            }
            else if (estado == "queimada")
            {
                Console.WriteLine("A lâmpada não funciona mais.");
                Console.ReadKey();
            }
            else
            {
                Lampada.Desliga();
                estado = "desligada";
            }
            break;

        case "3":
            Console.Clear();
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
    Console.WriteLine("(1)Ligar\n(2)Desligar\n(3)Sair\n");
}