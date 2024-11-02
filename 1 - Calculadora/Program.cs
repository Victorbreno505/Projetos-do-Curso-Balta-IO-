
using System.Runtime.InteropServices;

Menu();

static void Menu()
{
    Console.Clear();

    Console.WriteLine("Qual operação deseja realizar ?");

    Console.WriteLine("1- Soma");
    Console.WriteLine("2- Subtração");
    Console.WriteLine("3- Divisão");
    Console.WriteLine("4- Multiplicação");
    Console.WriteLine("5- Sair");

    Console.WriteLine("===============================");

    Console.WriteLine("Selecione uma Opção: ");

    short res = short.Parse(Console.ReadLine());
//Utilizando o Switch para percorrer o Menu.
    switch (res)
    {
        case 1: Soma(); break;
        case 2: Subtração(); break;
        case 3: Divisão(); break;
        case 4: Multiplicação(); break;
//Saida do Programa.
        case 5: System.Environment.Exit(0); break;
//Caso o Usuário digitar qualquer coisa fora dos valores (case 1, case 2, case 3, case 4) ele executa o default.
        default: Soma(); break;
    }
}

static void Soma()
{
    Console.Clear();

Console.WriteLine("Primeiro Valor: ");
float v1 = float.Parse(Console.ReadLine());

Console.WriteLine("Segundo valor");
float v2 = float.Parse(Console.ReadLine());

Console.WriteLine(" ");

float resultado = v1 + v2;

Console.WriteLine($"O resultado da soma é {resultado}");
Console.ReadKey();
    Menu();
}

static void Subtração()
{
    Console.Clear();

    Console.WriteLine("Primeiro valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine(" ");

    float resultado = v1 - v2;

    Console.WriteLine($"O resultado da subtração é {resultado}");
    Console.ReadKey();
    Menu();
}

static void Divisão()
{
    Console.Clear();

    Console.WriteLine("Primeio valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine(" ");

    float resultado = v1 / v2;

    Console.WriteLine($"O resultado da divisão é {resultado}");
    Console.ReadKey();
    Menu();
}

static void Multiplicação()
{
    Console.Clear();

    Console.WriteLine("Primeio valor: ");
    float v1 = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor");
    float v2 = float.Parse(Console.ReadLine());

    Console.WriteLine(" ");

    float resultado = v1 * v2;

    Console.WriteLine($"O resultado da divisão é {resultado}");
    Console.ReadKey();
    Menu();
}
