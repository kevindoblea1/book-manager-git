using System;
using System.Collections.Generic;

public class Shelf
{
    public int ShelfNumber { get; set; }
    public int MaxCapacity { get; set; }
    public List<Book> BooksOnShelf { get; set; } = new List<Book>();

    public void ShowContents()
    {
        Console.WriteLine($"Shelf #{ShelfNumber} - Max Capacity: {MaxCapacity} books");
        Console.WriteLine("Books currently on the shelf:");

        if (BooksOnShelf.Count == 0)
        {
            Console.WriteLine("  (Empty)");
        }
        else
        {
            foreach (var book in BooksOnShelf)
            {
                book.ShowInfo();
            }
        }
    }
}
