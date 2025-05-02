Console.Clear();

double altura;
double pesoIdeal;

Console.WriteLine("Bem vindo a calculadora do Peso Ideal\n");

Console.Write("Sexo [M]asculino / [F]eminino: ");
string sexo = Console.ReadLine()!.ToUpper();

Console.Write("Digite sua altura em m: ");
string alturaString = Console.ReadLine()!.Replace(".", ",");
double.TryParse(alturaString, out altura);

if (!double.TryParse(alturaString, out altura) || altura > 3 || altura < 1)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Digite números válidos");
    Console.ResetColor();
}

else if (sexo == "M")
{
    pesoIdeal = altura * 72.7 - 58;

    Console.WriteLine("\nAqui está sua ficha:");
    Thread.Sleep(1000);
    Console.Clear();

    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("   Ficha Peso Ideal   ");
    Console.ResetColor();

    Console.Write($@"
Sexo................: {sexo}
Altura..............: {altura:N2} m

Seu peso ideal é....: ");

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{pesoIdeal:N1} kg");
    Console.ResetColor();

}

else if (sexo == "F")
{
    pesoIdeal = altura * 62.1 - 44.7;

    Console.WriteLine("\nAqui está sua ficha:");
    Thread.Sleep(800);
    Console.Clear();

    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine("   Ficha Peso Ideal   ");
    Console.ResetColor();

    Console.Write($@"
Sexo................: {sexo}
Altura..............: {altura:N2} m

Seu peso ideal é....: ");

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{pesoIdeal:N1} kg");
    Console.ResetColor();

}

else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Opção inválida");
    Console.ResetColor();
}
