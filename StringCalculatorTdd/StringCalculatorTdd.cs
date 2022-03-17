using System;
using System.Linq;

public class StringCalculatorTdd
    {
    public static int Add(string numbers)
    {
        var sum = 0;
        if (numbers == string.Empty)
        {
            sum = 0;
        }
        else if(numbers.Contains(','))
        {

            var numbersList = numbers.Split(',');
            var countOfNumbers = numbersList.Count();
            if (numbersList[countOfNumbers - 1] == "\n")
            {
                throw new ArgumentException("Invalid argument, please pass numbers only");
            }
            for (int i = 0; i < countOfNumbers; i++)
            {
                if (numbersList[i] == "\n")
                {
                    numbersList[i] = "0";
                }
                try
                {
                    sum = sum + int.Parse(numbersList[i]);
                }
                catch
                {
                    throw new ArgumentException("Invalid argument, please pass numbers only");
                }
            }
        
        }
        else
        {
            //check if the entered input is a number
            try { 
            sum= int.Parse(numbers);
                }
            catch
            {
                throw new ArgumentException("Invalid argument, please pass numbers only");
            }
        }
        return sum;
    }
    }

