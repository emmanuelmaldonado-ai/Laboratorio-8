Console.WriteLine("Cantidad de filas: ");
int filas = int.Parse(Console.ReadLine());

Console.WriteLine("Cantidad de columnas: ");
int columnas = int.Parse(Console.ReadLine());

int[,] errores = new int[filas, columnas];

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        Console.Write("Ingrese el código de error: ");
        errores[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.Write("Ingrese el código de error que desea buscar: ");
int buscar = int.Parse(Console.ReadLine());

bool encontrado = false;
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        if (errores[i, j] == buscar)
        {
            Console.WriteLine($"Código encontrado en fila {i}, columna {j}");
            encontrado = true;
        }
    }
}

if (!encontrado)
{
    Console.WriteLine("El código de error no existe en la matriz");
}
