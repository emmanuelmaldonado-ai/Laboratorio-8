Console.Write("Estudiantes: ");
int estudiante = int.Parse(Console.ReadLine());

Console.Write("Calificaciones :");
int evaluacion= int.Parse(Console.ReadLine());

int[,] calificaciones = new int[estudiante, evaluacion];

for (int i = 0; i < estudiante; i++)
{
    for (int j = 0; j < evaluacion; j++)
    {
        Console.WriteLine("ingrese las calificaciones :");
        calificaciones[i, j] = int.Parse(Console.ReadLine());
    }
}

int mayor = calificaciones[0, 0];

Console.WriteLine($"Matriz: {estudiante}x{evaluacion}");
for (int i = 0; i < estudiante; i++)
{
    for (int j = 0; j < evaluacion; j++)
    {
        Console.Write(calificaciones[i, j] + " ");

        if (calificaciones[i, j] > mayor)
        {
            mayor = calificaciones[i, j];
        }
    }
    Console.WriteLine();
}

Console.WriteLine($"El número mayor de la matriz es: {mayor}");
