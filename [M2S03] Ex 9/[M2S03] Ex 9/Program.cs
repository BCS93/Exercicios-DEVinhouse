using System.Runtime.InteropServices;

class Adicao
{
    public static void Soma(double num1, double num2, [Optional] double num3, [Optional] double num4) 
    { 
        Console.WriteLine(num1+num2+num3+num4);
    }


    public static void Main()
    {
        Soma(2, 8);
        Soma(2, 8, 9);
        Soma(2, 8, 9, 30.3);

    }
}

