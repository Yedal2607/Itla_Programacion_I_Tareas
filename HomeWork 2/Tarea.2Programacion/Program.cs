using System;

List<int> ids = new List<int>();
List<string> titles = new List<string>();
List<string> authors = new List<string>();
List<int> years = new List<int>();

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
    Console.Write("Seleccione una opcion: ");

    string option = Console.ReadLine();

    switch (option)
    {
        case "1":

            int id;

            Console.Write("Ingrese el ID del libro: ");

            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("ID invalido. Intente nuevamente: ");
            }

            if (ids.Contains(id))
            {
                Console.WriteLine("Ese ID ya existe.");
                break;
            }

            Console.Write("Ingrese el titulo: ");
            string title = Console.ReadLine();

            Console.Write("Ingrese el autor: ");
            string author = Console.ReadLine();

            int year;

            Console.Write("Ingrese el año de publicacion: ");

            while (!int.TryParse(Console.ReadLine(), out year))
            {
                Console.Write("Año invalido. Intente nuevamente: ");
            }

            ids.Add(id);
            titles.Add(title);
            authors.Add(author);
            years.Add(year);

            Console.WriteLine("Libro agregado correctamente.");

            break;

        case "2":

            Console.WriteLine("1. Buscar por ID");
            Console.WriteLine("2. Buscar por titulo");
            Console.Write("Seleccione una opcion: ");

            string search = Console.ReadLine();

            if (search == "1")
            {
                int idSearch;

                Console.Write("Ingrese el ID: ");

                while (!int.TryParse(Console.ReadLine(), out idSearch))
                {
                    Console.Write("ID invalido: ");
                }

                bool found = false;

                for (int i = 0; i < ids.Count; i++)
                {
                    if (ids[i] == idSearch)
                    {
                        Console.WriteLine("Libro encontrado");
                        Console.WriteLine("ID: " + ids[i]);
                        Console.WriteLine("Titulo: " + titles[i]);
                        Console.WriteLine("Autor: " + authors[i]);
                        Console.WriteLine("Año: " + years[i]);

                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("No se encontro el libro.");
                }
            }
            else if (search == "2")
            {
                Console.Write("Ingrese el titulo: ");
                string titleSearch = Console.ReadLine();

                bool found = false;

                for (int i = 0; i < titles.Count; i++)
                {
                    if (titles[i].ToLower().Contains(titleSearch.ToLower()))
                    {
                        Console.WriteLine("Libro encontrado");
                        Console.WriteLine("ID: " + ids[i]);
                        Console.WriteLine("Titulo: " + titles[i]);
                        Console.WriteLine("Autor: " + authors[i]);
                        Console.WriteLine("Año: " + years[i]);

                        found = true;
                    }
                }

                if (!found)
                {
                    Console.WriteLine("No se encontro ningun libro.");
                }
            }
            else
            {
                Console.WriteLine("Opcion invalida.");
            }

            break;

        case "3":

            int idModify;

            Console.Write("Ingrese el ID del libro a modificar: ");

            while (!int.TryParse(Console.ReadLine(), out idModify))
            {
                Console.Write("ID invalido: ");
            }

            bool exists = false;

            for (int i = 0; i < ids.Count; i++)
            {
                if (ids[i] == idModify)
                {
                    Console.Write("Nuevo titulo: ");
                    titles[i] = Console.ReadLine();

                    Console.Write("Nuevo autor: ");
                    authors[i] = Console.ReadLine();

                    int newYear;

                    Console.Write("Nuevo año: ");

                    while (!int.TryParse(Console.ReadLine(), out newYear))
                    {
                        Console.Write("Año invalido: ");
                    }

                    years[i] = newYear;

                    Console.WriteLine("Libro modificado correctamente.");

                    exists = true;

                    break;
                }
            }

            if (!exists)
            {
                Console.WriteLine("No se encontro el libro.");
            }

            break;

        case "4":

            int idDelete;

            Console.Write("Ingrese el ID del libro a eliminar: ");

            while (!int.TryParse(Console.ReadLine(), out idDelete))
            {
                Console.Write("ID invalido: ");
            }

            bool deleted = false;

            for (int i = 0; i < ids.Count; i++)
            {
                if (ids[i] == idDelete)
                {
                    ids.RemoveAt(i);
                    titles.RemoveAt(i);
                    authors.RemoveAt(i);
                    years.RemoveAt(i);

                    Console.WriteLine("Libro eliminado correctamente.");

                    deleted = true;

                    break;
                }
            }

            if (!deleted)
            {
                Console.WriteLine("No se encontro el libro.");
            }

            break;

        case "5":

            if (ids.Count == 0)
            {
                Console.WriteLine("No hay libros registrados.");
            }
            else
            {
                Console.WriteLine("LISTA DE LIBROS");

                for (int i = 0; i < ids.Count; i++)
                {
                    Console.WriteLine("ID: " + ids[i]);
                    Console.WriteLine("Titulo: " + titles[i]);
                    Console.WriteLine("Autor: " + authors[i]);
                    Console.WriteLine("Año: " + years[i]);
                    Console.WriteLine("---------------------------");
                }
            }

            break;

        case "6":

            exit = true;

            Console.WriteLine("Hasta luego.");

            break;

        default:

            Console.WriteLine("Opcion invalida.");

            break;
    }

    if (!exit)
    {
        Console.WriteLine("Presione ENTER para continuar...");
        Console.ReadLine();
    }
}