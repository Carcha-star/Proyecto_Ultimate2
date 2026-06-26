static void CompararCapitanes(Capitan[] capitanes)
{
    int opcion1;
    int opcion2;

    do
    {
        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("          COMPARAR CAPITANES");
        Console.WriteLine("=====================================");
        Console.WriteLine();

        string grupoActual = "";

        for (int i = 0; i < capitanes.Length; i++)
        {
            if (grupoActual != capitanes[i].Grupo)
            {
                grupoActual = capitanes[i].Grupo;
                Console.WriteLine();
                Console.WriteLine($"========== GRUPO {grupoActual} ==========");
            }

            Console.WriteLine($"{i + 1}. {capitanes[i].Nombre} - {capitanes[i].Seleccion}");
        }

        Console.WriteLine();
        Console.WriteLine("0. Volver");
        Console.WriteLine();

        opcion1 = LeerNumero("Seleccione el primer capitán: ");

        if (opcion1 == 0)
        {
            return;
        }

        opcion2 = LeerNumero("Seleccione el segundo capitán: ");

        if (opcion2 == 0)
        {
            return;
        }

        if (opcion1 < 1 || opcion1 > capitanes.Length || opcion2 < 1 || opcion2 > capitanes.Length)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nUna de las opciones está fuera del rango permitido.");
            Console.ResetColor();
            Console.ReadKey();
            continue;
        }

        if (opcion1 == opcion2)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nDebe seleccionar dos capitanes diferentes.");
            Console.ResetColor();
            Console.ReadKey();
            continue;
        }

        MostrarComparacion(capitanes[opcion1 - 1], capitanes[opcion2 - 1]);

    } while (true);
}

static int LeerNumero(string mensaje)
{
    int numero;

    Console.Write(mensaje);

    try
    {
        numero = Convert.ToInt32(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nError: debe ingresar un número.");
        Console.ResetColor();
        Console.ReadKey();
        return -1;
    }
    catch (OverflowException)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nNúmero fuera de rango.");
        Console.ResetColor();
        Console.ReadKey();
        return -1;
    }

    return numero;
}

static void MostrarComparacion(Capitan c1, Capitan c2)
{
    Console.Clear();

    Console.WriteLine("=====================================");
    Console.WriteLine("        COMPARACIÓN DE CAPITANES");
    Console.WriteLine("=====================================");
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"{c1.Nombre} ({c1.Seleccion})  VS  {c2.Nombre} ({c2.Seleccion})");
    Console.ResetColor();
    Console.WriteLine();

    Console.WriteLine($"Grupo        : {c1.Grupo,-15} | {c2.Grupo}");
    Console.WriteLine($"Club actual  : {c1.ClubActual,-15} | {c2.ClubActual}");
    Console.WriteLine($"Posición     : {c1.Posicion,-15} | {c2.Posicion}");
    Console.WriteLine("-------------------------------------");

    CompararDato("Edad", c1.Edad, c2.Edad, c1.Nombre, c2.Nombre, false);
    CompararDato("Goles", c1.Goles, c2.Goles, c1.Nombre, c2.Nombre, true);
    CompararDato("Partidos", c1.Partidos, c2.Partidos, c1.Nombre, c2.Nombre, true);
    CompararDato("Asistencias", c1.Asistencias, c2.Asistencias, c1.Nombre, c2.Nombre, true);
    CompararDato("Títulos", c1.Titulos, c2.Titulos, c1.Nombre, c2.Nombre, true);

    Console.WriteLine("-------------------------------------");
    Console.WriteLine();
    Console.WriteLine("Trayectoria:");
    Console.WriteLine($"- {c1.Nombre}: {c1.Trayectoria}");
    Console.WriteLine($"- {c2.Nombre}: {c2.Trayectoria}");

    Console.WriteLine();
    Console.Write("Presione una tecla para volver...");
    Console.ReadKey();
}

static void CompararDato(string titulo, int valor1, int valor2, string nombre1, string nombre2, bool mayorEsMejor)
{
    string ganador;

    if (valor1 == valor2)
    {
        ganador = "Empate";
    }
    else if (mayorEsMejor)
    {
        ganador = valor1 > valor2 ? nombre1 : nombre2;
    }
    else
    {
        ganador = valor1 < valor2 ? nombre1 : nombre2;
    }

    Console.WriteLine($"{titulo,-12}: {valor1,-5} | {valor2,-5}  Ganador: {ganador}");
}

public struct Capitan
{
    public string Grupo;
    public string Nombre;
    public int Edad;
    public int Goles;
    public string ClubActual;
    public string Seleccion;


    public int Partidos;
    public int Asistencias;
    public int Titulos;
    public string Posicion;
    public string Trayectoria;

}
