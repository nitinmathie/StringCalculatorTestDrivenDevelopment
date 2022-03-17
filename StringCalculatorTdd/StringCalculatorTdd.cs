using System;


    public class StringCalculatorTdd
    {
    public static int Add(string numbers)
    {
        if (numbers == string.Empty)
        {
            return 0;
        }
        else
        {
            return int.Parse(numbers);
        }
    }
    }

