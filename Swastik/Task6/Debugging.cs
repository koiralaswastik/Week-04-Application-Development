using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user to enter marks
        Console.Write("Enter marks obtained: ");
        string marksInput = Console.ReadLine();

        // Ask user to enter total marks
        Console.Write("Enter total marks: ");
        string totalInput = Console.ReadLine();

        // Try to convert input to numbers
        bool isMarksValid = int.TryParse(marksInput, out int marks);
        bool isTotalValid = int.TryParse(totalInput, out int total);

        if (!isMarksValid || !isTotalValid || total == 0)
        {
            Console.WriteLine("Invalid input. Please enter numbers and total should not be 0.");
            return;
        }

        // -----------------------------
        // What happens WITHOUT fix:
        // double percentage = marks / total * 100;
        // If marks = 45, total = 50
        // 45 / 50 = 0 because both are integers
        // 0 * 100 = 0  (WRONG!)
        // -----------------------------

        // FIX: Convert marks to double so division works correctly
        double percentage = (double)marks / total * 100;

        // Print the correct percentage
        Console.WriteLine("Percentage: " + percentage + "%");
    }
}
