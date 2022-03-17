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
            if (numbersList.Count() == 2)
            {
                try
                {
                    sum= int.Parse(numbersList[0]) + int.Parse(numbersList[1]);
                }
                catch
                {
                    throw new ArgumentException("Invalid argument, please pass numbers only");
                }
            }
            if (numbersList.Count() == 3)
            {
                try
                {
                    sum= int.Parse(numbersList[0]) + int.Parse(numbersList[1])+ int.Parse(numbersList[2]);
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

