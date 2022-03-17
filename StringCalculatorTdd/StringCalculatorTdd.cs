using System;
using System.Linq;

public class StringCalculatorTdd
    {
    public static int Add(string numbers)
    {
        var sum = 0;
        if (numbers == string.Empty)
        {
            //input is empty
            sum = 0;
        }
        else if (numbers.Length > 2)
        {
            //input in the format of delimiter
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
                            //saving all the negative numbers to display that these are now allowed
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
                //input is numbers split by ','.
                var numbersList = numbers.Split(',');
                var countOfNumbers = numbersList.Count();
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

