Console.WriteLine("Dimenciones del inventario");
Console.WriteLine();
Console.Write("Cantidad de filas: ");
int fila = int.Parse(Console.ReadLine());

Console.Write("Cantidad de columnas: ");
int columna = int.Parse(Console.ReadLine());

int[,] matriz = new int[fila, columna];

for (int i = 0; i < fila; i++)
{
    for (int j = 0; j < columna; j++)
    {
        Console.Write("Valor (código/cantidad): ");
        matriz[i, j] = int.Parse(Console.ReadLine());
    }
}

bool encontrada = false;
Console.Write("Buscar fila: ");
int buscar = int.Parse(Console.ReadLine());

Console.WriteLine("Buscar");

for (int i = 0; i < fila; i++)
{
    if (i == buscar)
    {
        Console.Write("Valores de la fila");

        for (int j = 0; j < columna; j++)
        {
            Console.Write(matriz[i, j] + " ");
        }

        Console.WriteLine();
        encontrada = true;
    }
}

if (!encontrada)
{
    Console.WriteLine("La posición no existe");
}
Console.WriteLine();

Console.WriteLine($"Matriz:{fila}x{columna}");
for (int i = 0; i < fila; i++)
{
    for (int j = 0; j < columna; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}