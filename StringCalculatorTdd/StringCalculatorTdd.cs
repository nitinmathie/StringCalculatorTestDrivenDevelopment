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
        else if (numbers.Length > 2)
        {
            if (numbers.Substring(0, 2) == "//")
            {
                var delimiter = numbers[2];
                var numbersList = numbers.Split(delimiter);
                var countOfNumbers = numbersList.Count();
                if (numbersList[countOfNumbers - 1] == "\n")
                {

                    throw new ArgumentException("Invalid argument, please pass numbers only");
                }
                for (int i = 1; i < countOfNumbers; i++)
                {
                    try
                    {
                        if (numbersList[i] == "\n")
                    {
                        numbersList[i] = "0";
                    }
              
                    else if (int.Parse(numbersList[i]) < 0)
                        {
                            string negativeNumbers ="";
                            for(int j=i;j< countOfNumbers;j++)
                            {
                                if (int.Parse(numbersList[j]) < 0)
                                {
                                    negativeNumbers = numbersList[j].ToString() + "," + negativeNumbers;
                                }
                            }
                            throw new ArgumentOutOfRangeException("Invalid argument,"+negativeNumbers +"are not allowed.");
                            
                        }
                 
                        sum = sum + int.Parse(numbersList[i]);
                    }
                    catch(Exception ex)
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
                

            }
            else if (numbers.Contains(','))
            {

                var numbersList = numbers.Split(',');
                var countOfNumbers = numbersList.Count();
                if (numbersList[countOfNumbers - 1] == "\n")
                {
                    throw new ArgumentException("Invalid argument, please pass numbers only");
                }

                for (int i = 1; i < countOfNumbers; i++)
                {
                    try
                    {
                        if (numbersList[i] == "\n")
                        {
                            numbersList[i] = "0";
                        }

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

            }
        }
       
        else
        {
            //check if the entered input is a number
            try
            {
                sum = int.Parse(numbers);
            }
            catch
            {
                throw new ArgumentException("Invalid argument, please pass numbers only");
            }
        }
        return sum;
    }
    }

