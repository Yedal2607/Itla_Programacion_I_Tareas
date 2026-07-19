using System;
using System.Collections.Generic;

public class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook()
    {
        int id;

        Console.Write("Ingrese el ID del libro: ");

        while (!int.TryParse(Console.ReadLine(), out id))
        {
            Console.Write("ID inválido. Intente nuevamente: ");
        }

        foreach (Book book in books)
        {
            if (book.Id == id)
            {
                Console.WriteLine("Ese ID ya existe.");
                return;
            }
        }

        Console.Write("Ingrese el título: ");
        string title = Console.ReadLine();

        Console.Write("Ingrese el autor: ");
        string author = Console.ReadLine();

        int year;

        Console.Write("Ingrese el año de publicación: ");

        while (!int.TryParse(Console.ReadLine(), out year))
        {
            Console.Write("Año inválido. Intente nuevamente: ");
        }

        Book newBook = new Book(id, title, author, year);

        books.Add(newBook);

        Console.WriteLine("Libro agregado correctamente.");
    }

    public void SearchBook()
    {
        Console.WriteLine("1. Buscar por ID");
        Console.WriteLine("2. Buscar por título");
        Console.Write("Seleccione una opción: ");

        string option = Console.ReadLine();

        if (option == "1")
        {
            int searchId;

            Console.Write("Ingrese el ID: ");

            while (!int.TryParse(Console.ReadLine(), out searchId))
            {
                Console.Write("ID inválido: ");
            }

            foreach (Book book in books)
            {
                if (book.Id == searchId)
                {
                    ShowBook(book);
                    return;
                }
            }

            Console.WriteLine("No se encontró el libro.");
        }
        else if (option == "2")
        {
            Console.Write("Ingrese el título: ");
            string searchTitle = Console.ReadLine();

            bool found = false;

            foreach (Book book in books)
            {
                if (book.Title.ToLower().Contains(searchTitle.ToLower()))
                {
                    ShowBook(book);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No se encontró ningún libro.");
            }
        }
        else
        {
            Console.WriteLine("Opción inválida.");
        }
    }

    public void UpdateBook()
    {
        int updateId;

        Console.Write("Ingrese el ID del libro a modificar: ");

        while (!int.TryParse(Console.ReadLine(), out updateId))
        {
            Console.Write("ID inválido: ");
        }

        foreach (Book book in books)
        {
            if (book.Id == updateId)
            {
                Console.Write("Nuevo título: ");
                book.Title = Console.ReadLine();

                Console.Write("Nuevo autor: ");
                book.Author = Console.ReadLine();

                int newYear;

                Console.Write("Nuevo año: ");

                while (!int.TryParse(Console.ReadLine(), out newYear))
                {
                    Console.Write("Año inválido: ");
                }

                book.Year = newYear;

                Console.WriteLine("Libro modificado correctamente.");
                return;
            }
        }

        Console.WriteLine("No se encontró el libro.");
    }

    public void DeleteBook()
    {
        int deleteId;

        Console.Write("Ingrese el ID del libro a eliminar: ");

        while (!int.TryParse(Console.ReadLine(), out deleteId))
        {
            Console.Write("ID inválido: ");
        }

        for (int i = 0; i < books.Count; i++)
        {
            if (books[i].Id == deleteId)
            {
                books.RemoveAt(i);

                Console.WriteLine("Libro eliminado correctamente.");
                return;
            }
        }

        Console.WriteLine("No se encontró el libro.");
    }

    public void ListBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No hay libros registrados.");
            return;
        }

        Console.WriteLine("LISTA DE LIBROS");

        foreach (Book book in books)
        {
            ShowBook(book);
            Console.WriteLine("---------------------------");
        }
    }

    private void ShowBook(Book book)
    {
        Console.WriteLine("ID: " + book.Id);
        Console.WriteLine("Título: " + book.Title);
        Console.WriteLine("Autor: " + book.Author);
        Console.WriteLine("Año: " + book.Year);
    }
}