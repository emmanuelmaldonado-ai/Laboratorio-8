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
Console.Write("Valor a buscar: ");
int buscar = int.Parse(Console.ReadLine());

for (int i = 0; i < fila; i++)
{
    for (int j = 0; j < columna; j++)
    {
        if (matriz[i, j] == buscar)
        {
            Console.WriteLine($"Valor encontrado en fila {i}, columna {j}");
            encontrada = true;
        }
    }
}

if (!encontrada)
{
    Console.WriteLine("El valor no existe en la matriz");
}
