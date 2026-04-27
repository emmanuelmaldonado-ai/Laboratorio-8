Console.Write("Número de jugadores: ");
int jugadores = int.Parse(Console.ReadLine());

Console.WriteLine("Número de niveles: ");
int niveles = int.Parse(Console.ReadLine());

int[,] puntajes = new int[jugadores, niveles];

for (int i = 0; i < jugadores; i++)
{
    Console.WriteLine($"Jugador {i}:");
    for (int j = 0; j < niveles; j++)
    {
        Console.Write("Ingrese puntaje del nivel: ");
        puntajes[i, j] = int.Parse(Console.ReadLine());
    }
}

int mayor = puntajes[0, 0];
for (int i = 0; i < jugadores; i++)
{
    for (int j = 0; j < niveles; j++)
    {
        if (puntajes[i, j] > mayor)
        {
            mayor = puntajes[i, j];
        }
    }
}

Console.WriteLine($"El puntaje más alto es: {mayor}");
