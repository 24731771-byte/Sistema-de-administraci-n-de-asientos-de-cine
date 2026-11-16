
using System;

class Program
{
    // Matriz de 5 filas y 8 columnas
    static int[,] asientos = new int[5, 8];

    static void Main()
    {
        int opcion = 0;

        do
        {
            Console.WriteLine("\n================================");
            Console.WriteLine("   ADMINISTRACION DE ASIENTOS");
            Console.WriteLine("================================");
            Console.WriteLine("1. Mostrar asientos");
            Console.WriteLine("2. Reservar asiento");
            Console.WriteLine("3. Liberar asiento");
            Console.WriteLine("4. Consultar disponibilidad");
            Console.WriteLine("5. Mostrar estadisticas");
            Console.WriteLine("6. Salir");
            Console.WriteLine("================================");
            Console.Write("Selecciona una opcion: ");

            string? entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcion))
            {
                Console.WriteLine("Ingresa un numero valido.");
                opcion = 0;
            }
            else
            {
                switch (opcion)
                {
                    case 1:
                        MostrarAsientos(asientos);
                        break;

                    case 2:
                        ReservarAsiento(asientos);
                        break;

                    case 3:
                        LiberarAsiento(asientos);
                        break;

                    case 4:
                        ConsultarDisponibilidad(asientos);
                        break;

                    case 5:
    MostrarEstadisticas(asientos);
    break;

                    case 6:
                        Console.WriteLine("Gracias por utilizar el sistema.");
                        break;

                    default:
                        Console.WriteLine("Opcion no disponible.");
                        break;
                }
            }

        } while (opcion != 6);
    }

    static void MostrarAsientos(int[,] matriz)
    {
        Console.WriteLine("\n          PANTALLA");
        Console.WriteLine("------------------------------");

        Console.Write("     ");

        for (int columna = 0; columna < matriz.GetLength(1); columna++)
        {
            Console.Write($"{columna + 1,4}");
        }

        Console.WriteLine("\n");

        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            char letraFila = (char)('A' + fila);

            Console.Write($"{letraFila}    ");

            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                if (matriz[fila, columna] == 0)
                {
                    Console.Write($"{"[L]",4}");
                }
                else
                {
                    Console.Write($"{"[X]",4}");
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nL = Disponible | X = Ocupado");
    }

    static void ReservarAsiento(int[,] matriz)
{
    Console.WriteLine("\n--- RESERVAR ASIENTO ---");

    Console.Write("Ingresa la fila (A-E): ");
    string? entradaFila = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(entradaFila))
    {
        Console.WriteLine("Debes ingresar una fila.");
        return;
    }

    char fila = char.ToUpper(entradaFila[0]);

    if (fila < 'A' || fila > 'E')
    {
        Console.WriteLine("La fila ingresada no existe.");
        return;
    }

    Console.Write("Ingresa la columna (1-8): ");

    if (!int.TryParse(Console.ReadLine(), out int columna))
    {
        Console.WriteLine("Debes ingresar un numero valido.");
        return;
    }

    if (columna < 1 || columna > 8)
    {
        Console.WriteLine("La columna no existe.");
        return;
    }

    int indiceFila = fila - 'A';
    int indiceColumna = columna - 1;

    if (matriz[indiceFila, indiceColumna] == 1)
    {
        Console.WriteLine("El asiento ya esta ocupado.");
    }
    else
    {
        matriz[indiceFila, indiceColumna] = 1;
        Console.WriteLine("¡Asiento reservado correctamente!");
    }
}

static void LiberarAsiento(int[,] matriz)
{
    Console.WriteLine("\n--- LIBERAR ASIENTO ---");

    Console.Write("Ingresa la fila (A-E): ");
    string? entradaFila = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(entradaFila))
    {
        Console.WriteLine("Debes ingresar una fila.");
        return;
    }

    char fila = char.ToUpper(entradaFila[0]);

    if (fila < 'A' || fila > 'E')
    {
        Console.WriteLine("La fila ingresada no existe.");
        return;
    }

    Console.Write("Ingresa la columna (1-8): ");

    if (!int.TryParse(Console.ReadLine(), out int columna))
    {
        Console.WriteLine("Debes ingresar un numero valido.");
        return;
    }

    if (columna < 1 || columna > 8)
    {
        Console.WriteLine("La columna no existe.");
        return;
    }

    int indiceFila = fila - 'A';
    int indiceColumna = columna - 1;

    if (matriz[indiceFila, indiceColumna] == 0)
    {
        Console.WriteLine("El asiento ya esta disponible.");
    }
    else
    {
        matriz[indiceFila, indiceColumna] = 0;
        Console.WriteLine("¡Asiento liberado correctamente!");
    }
}

static void ConsultarDisponibilidad(int[,] matriz)
{
    Console.WriteLine("\n--- CONSULTAR DISPONIBILIDAD ---");

    Console.Write("Ingresa la fila (A-E): ");
    string? entradaFila = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(entradaFila))
    {
        Console.WriteLine("Debes ingresar una fila.");
        return;
    }

    char fila = char.ToUpper(entradaFila[0]);

    if (fila < 'A' || fila > 'E')
    {
        Console.WriteLine("La fila ingresada no existe.");
        return;
    }

    Console.Write("Ingresa la columna (1-8): ");

    if (!int.TryParse(Console.ReadLine(), out int columna))
    {
        Console.WriteLine("Debes ingresar un numero valido.");
        return;
    }

    if (columna < 1 || columna > 8)
    {
        Console.WriteLine("La columna no existe.");
        return;
    }

    int indiceFila = fila - 'A';
    int indiceColumna = columna - 1;

    if (matriz[indiceFila, indiceColumna] == 0)
    {
        Console.WriteLine($"El asiento {fila}{columna} esta disponible.");
    }
    else
    {
        Console.WriteLine($"El asiento {fila}{columna} esta ocupado.");
    }
}

static void MostrarEstadisticas(int[,] matriz)
{
    int ocupados = 0;
    int disponibles = 0;

    for (int fila = 0; fila < matriz.GetLength(0); fila++)
    {
        for (int columna = 0; columna < matriz.GetLength(1); columna++)
        {
            if (matriz[fila, columna] == 1)
            {
                ocupados++;
            }
            else
            {
                disponibles++;
            }
        }
    }

    int totalAsientos = matriz.Length;

    double porcentajeOcupacion = (double)ocupados / totalAsientos * 100;

    Console.WriteLine("\n--- ESTADISTICAS DE LA SALA ---");
    Console.WriteLine($"Total de asientos: {totalAsientos}");
    Console.WriteLine($"Asientos ocupados: {ocupados}");
    Console.WriteLine($"Asientos disponibles: {disponibles}");
    Console.WriteLine($"Porcentaje de ocupacion: {porcentajeOcupacion:F2}%");
}
}
