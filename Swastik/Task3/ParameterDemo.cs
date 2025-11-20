using System;

public class ParameterDemo
{
    // method using ref parameter
    public void Increase(ref int number)
    {
        number = number + 10;
    }

    // method using out parameter
    public void GetFullName(out string fullname)
    {
        fullname = "Krish Thapa";
    }

    // method using params keyword
    public int SumAll(params int[] numbers)
    {
        int total = 0;

        foreach (int n in numbers)
        {
            total = total + n;
        }

        return total;
    }
}
