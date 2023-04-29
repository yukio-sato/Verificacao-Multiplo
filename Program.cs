void frase(string txt)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    for (int i = 0; i < txt.Length; i++)
    {
        Console.Write(txt[i]);
        Thread.Sleep(30);
    }
}
frase("Digite um número para verificar: ");
Console.ForegroundColor = ConsoleColor.White;
decimal vl = decimal.Parse(Console.ReadLine()!);
frase("Digite um número para dividir: ");
Console.ForegroundColor = ConsoleColor.White;
decimal dvd = decimal.Parse(Console.ReadLine()!);
if (dvd == 0)
{
    dvd = 1;
}
decimal total = vl % dvd;
if (total == 0)
{
    frase($"O número {vl} é multiplo de {dvd}.");
}
else if (total != 0)
{
    frase($"O número {vl} NÃO é multiplo de {dvd}.");
}
frase($"Quantidade necessário para chegar à {vl}.\n");
int i;
for (i = 1; (dvd*i) != vl; i++)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine($"{dvd} x {i} = {dvd*i}");
}
Console.WriteLine($"{dvd} x {i} = {dvd*i}");
Console.ResetColor();