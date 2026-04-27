Console.WriteLine("Productos:");
int productos = int.Parse(Console.ReadLine());

Console.WriteLine("Dias:");
int dias = int.Parse(Console.ReadLine());

int[,] ventas = new int[productos, dias];

for  (int i = 0; i < productos; i++)
{
    for (int j = 0; j < dias; j++)
    {
        Console.WriteLine("Ingrese la cantidad de ventas:");
        ventas[i,j]= int.Parse(Console.ReadLine());
    }
}

bool encontrada = false;
Console.Write("Buscar producto: ");
int buscar = int.Parse(Console.ReadLine());

for (int i = 0; i < productos; i++)
{
    if (i == buscar)
    {
        for (int j = 0; j < dias; j++)
        {
            Console.Write(ventas[i, j] + " ");
        }
        encontrada = true;
    }
}

Console.WriteLine($"Fila del producto: {buscar}");