public enum DayType
{
    Weekday,
    Weekend
}

public record Book(string title, string author, double price);

class Program
{
    static void Main(string[] args)
    {
        // Asking user for day input
        Console.Write("Enter a day: ");
        string day = Console.ReadLine();
        day = day.ToLower(); // for easy comparison

        DayType typeOfDay;

        if (day == "friday" || day == "saturday")
        {
            typeOfDay = DayType.Weekend;
        }
        else
        {
            typeOfDay = DayType.Weekday;
        }

        Console.WriteLine("It is: " + typeOfDay);
        Console.WriteLine();

        // Creating first book object with your name as author
        Book b1 = new Book("The Alchemist", "Swastik Koirala", 500);
        Console.WriteLine("Book 1:");
        Console.WriteLine(b1);
        Console.WriteLine();

       
        Book b2 = b1 with { title = "The Alchemist - Special Edition", price = 750 };

        // Deconstructing second book
        var (t, a, p) = b2;

        Console.WriteLine("Book 2 Deconstructed:");
        Console.WriteLine("Title: " + t);
        Console.WriteLine("Author: " + a);
        Console.WriteLine("Price: " + p);
    }
}
