using System;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    public void Greet()
    {
        Console.WriteLine($"Hello! I'm {FirstName} {LastName} and I'm {Age} years old.");
    }
}
