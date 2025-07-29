using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int YearPublished { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {YearPublished}");
    }
}
