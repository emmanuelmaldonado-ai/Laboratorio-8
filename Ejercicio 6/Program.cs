Console.WriteLine   ("Cantidad de estudiantes: ");
int estudiantes = int.Parse(Console.ReadLine());

Console.WriteLine("Cantidad de días: ");
int dias = int.Parse(Console.ReadLine());

int[,] asistencia = new int[estudiantes, dias];

for (int i = 0; i < estudiantes; i++)
{
    Console.WriteLine($"Estudiante {i}:");
    for (int j = 0; j < dias; j++)
    {
        Console.Write("(1) Asistió, 0) Faltó: ");
        asistencia[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine("Seleccione el número del estudiante: ");
int buscar = int.Parse(Console.ReadLine());

bool encontrado = false;

for (int i = 0; i < estudiantes; i++)
{
    if (i == buscar)
    {
        Console.WriteLine("Asistencia:");
        for (int j = 0; j < dias; j++)
        {
            Console.Write(asistencia[i, j] + " ");
        }
        Console.WriteLine();
        encontrado = true;
    }
}

if (!encontrado)
{
    Console.WriteLine("El estudiante no existe");
}
