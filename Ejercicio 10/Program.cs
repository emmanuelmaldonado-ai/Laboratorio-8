Console.WriteLine("Número de sucursales: ");
int sucursales = int.Parse(Console.ReadLine());

Console.WriteLine("Número de productos: ");
int productos = int.Parse(Console.ReadLine());

int[,] inventario = new int[sucursales, productos];

for (int i = 0; i < sucursales; i++)
{
    Console.WriteLine($"Sucursal {i}:");
    for (int j = 0; j < productos; j++)
    {
        Console.Write("Ingrese cantidad del producto: ");
        inventario[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Seleccione el número de la sucursal: ");
int buscar = int.Parse(Console.ReadLine());

if (buscar >= 0 && buscar < sucursales)
{
    Console.WriteLine("Inventario de la sucursal:");
    for (int j = 0; j < productos; j++)
    {
        Console.Write(inventario[buscar, j] + " ");
    }
    Console.WriteLine();
}
else
{
    Console.WriteLine("La sucursal no existe");
}
