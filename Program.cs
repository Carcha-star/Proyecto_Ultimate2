using System;

Capitan[] capitanes =
{
    new Capitan
    {
        Seleccion = "Argentina",
        Nombre = "Lionel Messi",
        Edad = 39,
        Goles = 112,
        ClubActual = "Inter Miami"
    },
    new Capitan
    {
        Seleccion = "Portugal",
        Nombre = "Cristiano Ronaldo",
        Edad = 41,
        Goles = 138,
        ClubActual = "Al Nassr"
    },
    new Capitan
    {
        Seleccion = "Francia",
        Nombre = "Kylian Mbappé",
        Edad = 28,
        Goles = 52,
        ClubActual = "Real Madrid"
    },
    new Capitan
    {
        Seleccion = "Croacia",
        Nombre = "Luka Modrić",
        Edad = 41,
        Goles = 28,
        ClubActual = "Real Madrid"
    }
};

if (capitanes == null || capitanes.Length == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Error crítico: No se encontraron datos de capitanes.");
    Console.ResetColor();
    return;
}

MostrarMenu(capitanes);

void MostrarMenu(Capitan[] listaCapitanes)
{
    int opcion;
    bool entradaValida;

    do
    {
        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("       RADAR DEL CAPITÁN");
        Console.WriteLine("=====================================");
        Console.WriteLine();

        for (int i = 0; i < listaCapitanes.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {listaCapitanes[i].Seleccion}");
        }

        Console.WriteLine("0. Salir");
        Console.WriteLine();
        Console.Write("Seleccione una opción: ");

        string entrada = Console.ReadLine();
        entradaValida = int.TryParse(entrada, out opcion);

        if (!entradaValida)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n[ERROR] El valor ingresado no es válido.");
            Console.ResetColor();
            Console.Write("Presione una tecla para continuar...");
            Console.ReadKey();
            opcion = -1;
            continue;
        }

        if (opcion < 0 || opcion > listaCapitanes.Length)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\n[ERROR] Opción fuera de rango.");
            Console.ResetColor();
            Console.Write("Presione una tecla para continuar...");
            Console.ReadKey();
            continue;
        }

        if (opcion > 0)
        {
            MostrarInformacion(listaCapitanes[opcion - 1]);
        }

    } while (opcion != 0);
}


void MostrarInformacion(Capitan capitan)
{
    Console.Clear();
    Console.WriteLine("=====================================");
    Console.WriteLine("      INFORMACIÓN DEL CAPITÁN");
    Console.WriteLine("=====================================");

    string seleccion = string.IsNullOrWhiteSpace(capitan.Seleccion) ? "No especificada" : capitan.Seleccion;
    string nombre = string.IsNullOrWhiteSpace(capitan.Nombre) ? "Anónimo" : capitan.Nombre;
    string club = string.IsNullOrWhiteSpace(capitan.ClubActual) ? "Agente Libre" : capitan.ClubActual;

    Console.WriteLine($"Selección   : {seleccion}");
    Console.WriteLine($"Capitán     : {nombre}");
    Console.WriteLine($"Edad        : {(capitan.Edad <= 0 ? "No registrada" : capitan.Edad + " años")}");
    Console.WriteLine($"Goles       : {(capitan.Goles < 0 ? 0 : capitan.Goles)}");
    Console.WriteLine($"Club Actual : {club}");
    Console.WriteLine("=====================================");

    Console.WriteLine();
    Console.Write("Presione una tecla para regresar...");
    Console.ReadKey();
}

struct Capitan
{
    public string Nombre;
    public int Edad;
    public int Goles;
    public string ClubActual;
    public string Seleccion;
}