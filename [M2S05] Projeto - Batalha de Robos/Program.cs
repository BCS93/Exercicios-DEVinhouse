using _M2S05__Projeto___Batalha_de_Robos.Models;

RoboBatalhaLeve roboL1 = new RoboBatalhaLeve("Meio Quilo");
RoboBatalhaLeve roboL2 = new RoboBatalhaLeve("Peso Pena");

RoboBatalhaPesado roboP1 = new RoboBatalhaPesado("Torresmo");
RoboBatalhaPesado roboP2 = new RoboBatalhaPesado("Pesadão");

Console.WriteLine("Batalha de Robôs: 1\n");

roboL1.Iniciar();
roboL2.Iniciar();
PartidaBatalha.Batalhar(roboL1, roboL2, 4);
string resultado = Resultado.ResultadoBatalha(roboL1, roboL2);
Console.WriteLine(resultado);
Console.ReadKey();


Console.Clear();
Console.WriteLine("Batalha de Robôs: 2\n");

roboP1.Iniciar();
roboP2.Iniciar();
PartidaBatalha.Batalhar(roboP1, roboP2, 5);
resultado = Resultado.ResultadoBatalha(roboP1, roboP2);
Console.WriteLine(resultado);
Console.ReadKey();

