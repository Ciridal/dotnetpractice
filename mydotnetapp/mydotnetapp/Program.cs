using System;

public class MyProgram
{


    public static void Main(string[] args)
    {
        
        Console.WriteLine("Please enter a number!");
        string userInput = Console.ReadLine();

        try
        {
            int userInputAsInt = int.Parse(userInput);
        }
        catch (FormatException)
        {
            Console.WriteLine("I SAID A NUMBER!!!! try again >:(");
        }
        catch(OverflowException)
        {
            Console.WriteLine("Yo look at the size of that thing, try again and please be more reasonable");
        }
        catch(Exception)
        {
            Console.WriteLine("What is this, try again and study some ints for next time!");
        }


        Console.WriteLine("What's the temperature like?");
        string temperature = Console.ReadLine();    
        int numTemp = int.Parse(temperature);
        int number;

        if(int.TryParse(temperature, out number))
        {
            numTemp = number;
        }
        else
        {
            numTemp = 0;
            Console.WriteLine("Value is invalid, 0 set as temperature");
        }

        if(numTemp < 10)
        {
            Console.WriteLine("take a coat");
        }
        else if(numTemp == 10)
        {
            Console.WriteLine("Grilling weather in finland, nice!");
        }
        else
        {
            Console.WriteLine("Must be summertime, cheers");
        }
           
    }

    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Multiply(int x, int y)
    {
        return x * y;
    }

    public static double Divide(int x, int y)
    {
        return (double)x / (double)y;
    }

    public static void WriteSomething() //has to be static to be called from a static method
    {
        Console.WriteLine("I'm called from a method, how neat!");
        Console.Read();
    }

    public static void SimpleCalculator()
    {
        Console.WriteLine("Enter first number");
        string number1input = Console.ReadLine();
        Console.WriteLine("Please enter second number");
        string number2input = Console.ReadLine();

        int num1 = int.Parse(number1input);
        int num2 = int.Parse(number2input);

        Console.WriteLine(num1 + num2);
    }
}
