Console.WriteLine("Número de máquinas: ");
int maquinas = int.Parse(Console.ReadLine());

Console.WriteLine("Número de turnos: ");
int turnos = int.Parse(Console.ReadLine());

int[,] produccion = new int[maquinas, turnos];

for (int i = 0; i < maquinas; i++)
{
    Console.WriteLine($"Máquina {i}:");
    for (int j = 0; j < turnos; j++)
    {
        Console.Write("Ingrese la producción del turno: ");
        produccion[i, j] = int.Parse(Console.ReadLine());
    }
}

int PTotal = 0;
for (int i = 0; i < maquinas; i++)
{
    for (int j = 0; j < turnos; j++)
    {
        PTotal += produccion[i, j];
    }
}

Console.WriteLine($"Producción total de la fábrica: {PTotal}");
