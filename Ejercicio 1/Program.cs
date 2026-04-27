Console.Write("Zonas: ");
int zonas = int.Parse(Console.ReadLine());

Console.Write("Días:");
int dias = int.Parse(Console.ReadLine());

int[,] temperaturas = new int[zonas, dias];

for (int i = 0; i < zonas; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.WriteLine("ingrese las temperaturas:");
        temperaturas[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine($"Matriz:{zonas}x{dias}");
for (int i = 0; i < zonas; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.Write(temperaturas[i, j] + " ");
    }
    Console.WriteLine();
}
