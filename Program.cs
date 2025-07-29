using System;

class Program
{
    static void Main(string[] args)
    {
        // Create books and instantiate each one
        var book1 = new Book { Title = "The Little Prince", Author = "Antoine de Saint-Exupéry", YearPublished = 1943 };
        var book2 = new Book { Title = "One Hundred Years of Solitude", Author = "Gabriel García Márquez", YearPublished = 1967 };
        var book3 = new Book { Title = "1984", Author = "George Orwell", YearPublished = 1949 };

        // Create persons
        var person1 = new Person { FirstName = "Sofia", LastName = "Smith", Age = 25 };
        var person2 = new Person { FirstName = "Kevin", LastName = "Alvarenga", Age = 32 };

        // Each book is an element in the BooksOnShelf list (Relación entre Clases: Una de sus clases tendrá una propiedad que será un objeto de otra clase (por ejemplo, el Estante contendrá Libros).
        var shelf = new Shelf
        {
            ShelfNumber = 1,
            MaxCapacity = 5
        };

        shelf.BooksOnShelf.Add(book1);
        shelf.BooksOnShelf.Add(book2);
        shelf.BooksOnShelf.Add(book3);

        // Display book info
        Console.WriteLine("Book Information");
        book1.ShowInfo();
        book2.ShowInfo();
        book3.ShowInfo();

        // Display regards
        Console.WriteLine("\nPerson Greetings");
        person1.Greet();
        person2.Greet();

        // Display shelf contents
        Console.WriteLine("\nShelf Contents");
        shelf.ShowContents();
    }
}
