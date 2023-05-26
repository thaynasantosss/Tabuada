Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("Tabuada do número: ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkYellow;
int n = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

Console.WriteLine();

int m = 0;
int produto;

while (m <= 10)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    produto = n * m;
    Console.WriteLine($"{n} x {m} = {produto}");
    m += 1;
    Console.ResetColor();
}