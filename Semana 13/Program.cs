string apellidos, nombres;

do {
    Console.Write("Ingrese sus apellidos: ");
    apellidos = Console.ReadLine().Trim();
}while (apellidos.Any(char.IsDigit));
do
{
    Console.Write("Ingrese sus nombres: ");
    nombres = Console.ReadLine().Trim();
} while (nombres.Any(char.IsDigit));
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Cantidad de caracteres en apellidos: "+apellidos.Length);
Console.WriteLine("Nombres en mayuscula: " + nombres.ToUpper());
Console.WriteLine("Apelldios en minuscula: "+apellidos.ToLower());
if (nombres.CompareTo(apellidos) == 0)
{
    Console.WriteLine("Apelldios y nombres iguales");
}
else
    Console.WriteLine("Apellidos y nombres no son iguales");
Console.ForegroundColor= ConsoleColor.DarkBlue;
if (nombres.Contains("an") == true)
{
    Console.WriteLine("Existe la palabra \"an\" en nombres");
}
else {
    Console.WriteLine("No existe la palabra \"an\" en nombres");
}
if (apellidos.Contains("a")) { 
    int index = apellidos.IndexOf("a");
    if (index != -1)
    {
        Console.WriteLine("La primera posicion de la \"a\" esta en " + index);
    }
    else
        Console.WriteLine("En apelldios no existe la palabra \"a\"");
}
if (apellidos.Contains("a"))
{
    int index = apellidos.LastIndexOf("a");
    if (index != -1)
    {
        Console.WriteLine("La ultima posicion de la \"a\" esta en " + index);
    }
    else
        Console.WriteLine("En apelldios no existe la palabra \"a\"");
}
Console.WriteLine("Insertando UPN al inicio de nombvre: " + nombres.Insert(0,"UPN"));
Console.WriteLine("Insertando la palabra \"Sistemas\"Al final de los apellidos"+apellidos.Insert(apellidos.Length,"Sistemas"));
if (apellidos.Length > 4)
{
    Console.WriteLine("eliminando 5 caracteres: " + apellidos.Remove(5));
}
else
    Console.WriteLine("No hay 5 caracteres en apellidos");
Console.BackgroundColor = ConsoleColor.White;
if (nombres.Contains("a"))
{
    Console.WriteLine(nombres.Replace("a", "@"));
}
else
    Console.WriteLine("No se puede remplazar porque no existe");
Console.ResetColor();

char[] nom = nombres.ToCharArray();
foreach (char c in nom) {
    Console.WriteLine(c);
}
Array.Reverse(nom);
Console.WriteLine(nom);
Array.Sort(nom);
Console.WriteLine(nom);




