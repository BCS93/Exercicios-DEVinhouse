double[] notas = new double[6];
double soma = 0;
double media =0;
int alunoID = 1;


for(int n = 0; n<notas.Length ;n++)
{   
    Console.WriteLine($"qual a nota do aluno {alunoID++}?");
    notas[n] = double.Parse(Console.ReadLine());

    soma+= notas[n];

    media = soma / notas.Length;
}


Console.WriteLine($"a nota média dos alunos é: {media}");