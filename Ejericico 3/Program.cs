Console.Write("Apartamentos : ");
int apartamentos = int.Parse(Console.ReadLine());

Console.Write("sias:");
int dias = int.Parse(Console.ReadLine());

int[,] costo = new int[apartamentos, dias];

for (int i = 0; i < apartamentos; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.WriteLine("ingrese los costos:");
        costo[i, j] = int.Parse(Console.ReadLine());
    }
}

int suma = 0;
Console.WriteLine($"Matriz:{apartamentos}x{dias}");
for (int i = 0; i < apartamentos; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.Write(costo[i, j] + " ");
        suma += costo[i,j];
    }
    Console.WriteLine();
}
Console.WriteLine($"Suma total de costo elEctrico: Q{suma}");
