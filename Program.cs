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
    Console.WriteLine("Error crítico: No se encontraron datos de capitanes cargados.");
    Console.ResetColor();
    return;
}

MostrarMenu(capitanes);