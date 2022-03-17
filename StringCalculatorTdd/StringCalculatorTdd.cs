using System;


    public class StringCalculatorTdd
    {
    public static int Add(string numbers)
    {
        if (numbers == string.Empty)
        {
            return 0;
        }
        else if(numbers.Contains(','))
        {
            var numbersList = numbers.Split(',');
            try
            {
                return int.Parse(numbersList[0]) + int.Parse(numbersList[1]);
            }
            catch
            {
                throw new ArgumentException("Invalid argument, please pass numbers only");
            }
        }
        else
        {
            //check if the entered input is a number
            try { 
            return int.Parse(numbers);
                }
            catch
            {
                throw new ArgumentException("Invalid argument, please pass numbers only");
            }
        }
    }
    }

