using System;

Library library = new Library();

bool exit = false;

while (!exit)
{
    Console.Clear();

    Console.WriteLine("====================================");
    Console.WriteLine(" REGISTRO DE PRESTAMOS DE LIBROS");
    Console.WriteLine("====================================");
    Console.WriteLine("1. Agregar libro");
    Console.WriteLine("2. Buscar libro");
    Console.WriteLine("3. Modificar libro");
    Console.WriteLine("4. Eliminar libro");
    Console.WriteLine("5. Listar libros");
    Console.WriteLine("6. Salir");
    Console.Write("Seleccione una opción: ");

    string option = Console.ReadLine();

    switch (option)
    {
        case "1":
            library.AddBook();
            break;

        case "2":
            library.SearchBook();
            break;

        case "3":
            library.UpdateBook();
            break;

        case "4":
            library.DeleteBook();
            break;

        case "5":
            library.ListBooks();
            break;

        case "6":
            exit = true;
            Console.WriteLine("Hasta luego.");
            break;

        default:
            Console.WriteLine("Opción inválida.");
            break;
    }

    if (!exit)
    {
        Console.WriteLine();
        Console.WriteLine("Presione ENTER para continuar...");
        Console.ReadLine();
    }
}