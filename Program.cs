    int i;
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
if (vl == 0)
{
    vl = 1;
}
decimal total = vl % dvd;
if (total == 0)
{
    frase($"\nO número {vl} é multiplo de {dvd}.\n");
    frase($"\nCalculando a quantidade necessário para chegar em {vl}.\n");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Pressione qualquer tecla para continuar");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("[]_Calculo____________");
    for (i = 1; (dvd*i) != vl; i++)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine($"|| {dvd} x {i} = {dvd*i}");
    //Thread.Sleep(30);
}
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine($"[] {dvd} x {i} = {(dvd*i)}");
}
else if (total != 0)
{
    frase($"\nO número {vl} NÃO é multiplo de {dvd}.\n");
}
Console.ResetColor();
