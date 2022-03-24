using System;
using System.Collections.Generic;
using System.Linq;

public class StringCalculatorTdd
    {
    public static int Add(string numbers)
    {
        //to discard all the "_"s from the input string
      
       var sum = 0;
        if (string.IsNullOrEmpty(numbers))
        {
            return  0;
        }
        else if (numbers.Length > 2)
        {
            numbers = numbers.Replace("_", ""); 
            //input in the format of delimiter
            if (numbers.Substring(0, 2) == "//")
            {
                var delimiter = numbers[2];
                var numbersList = numbers.Split(delimiter);
                //after the string has been split based on delimiter the array contains "//" as first element
                numbersList= numbersList.Skip(1).ToArray();
                var countOfNumbers = numbersList.Count();
                sum = getSum(sum, numbersList, countOfNumbers);
            }
            else if (numbers.Contains(','))
            {
                //input is numbers split by ','.
                var numbersList = numbers.Split(',');
                var countOfNumbers = numbersList.Count();
                sum = getSum(sum, numbersList, countOfNumbers);
            }
        }      
        else
        {
            try
            {
                return int.Parse(numbers);
            }
            catch
            {
                throw new ArgumentException("Invalid argument, please pass numbers only");
            }
        }
        return sum;
    }
    private static int getSum(int sum, string[] numbersList, int countOfNumbers)
    {
        if (numbersList[countOfNumbers - 1] == "\n")
        {
            //disallowing newline as the last number. 
            throw new ArgumentException("Invalid argument, please pass numbers only");
        }
        for (int i = 0; i < countOfNumbers; i++)
        {
            try
            {
                if (numbersList[i] == "\n")
                {
                    //making newlines as zeros.
                    numbersList[i] = "0";
                }
                //extracts negative numbers and displays them in exception message.
                else if (int.Parse(numbersList[i]) < 0)
                {
                    string negativeNumbers = "";
                    for (int j = i; j < countOfNumbers; j++)
                    {
                        if (int.Parse(numbersList[j]) < 0)
                        {
                            negativeNumbers = numbersList[j].ToString() + "," + negativeNumbers;
                        }
                    }
                    throw new ArgumentOutOfRangeException("Invalid argument," + negativeNumbers + "are not allowed.");
                }
                sum = sum + int.Parse(numbersList[i]);
            }
            catch (Exception ex)
            {
                if (ex is ArgumentOutOfRangeException)
                {
                    var message = ex.Message.Split("'");
                    throw new ArgumentException(message[1]);
                }
                else
                {
                    throw new ArgumentException("Invalid argument, please pass numbers only");
                }
            }
        }
        return sum;
    }
}

