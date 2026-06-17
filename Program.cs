int mostrar_menu()
{
    Console.Clear();
    Console.WriteLine("=================================");
    Console.WriteLine("      LA RUTA DEL CAPITÁN");
    Console.WriteLine("=================================");
    Console.WriteLine("1. Mostrar estadísticas");
    Console.WriteLine("2. Comparar capitanes");
    Console.WriteLine("3. Salir");

    while (true)
    {
        Console.Write("\nSeleccione una opción: ");

        if (int.TryParse(Console.ReadLine(), out int op))
        {
            if (op >= 1 && op <= 3)
            {
                return op;
            }
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Opción inválida. Por favor, ingrese un número valido.");
        Console.ResetColor();
    }
}

mostrar_menu();