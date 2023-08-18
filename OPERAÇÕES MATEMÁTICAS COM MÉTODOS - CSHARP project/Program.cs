using System.Xml.XPath;

internal class Program
{

    public static String? userInput;

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        Console.WriteLine("which operation you want to make?");
        Console.WriteLine("addition => +");
        Console.WriteLine("subtraction => -");
        Console.WriteLine("multiplication => *");
        Console.WriteLine("division => /");

        Program p = new Program();

        userInput = Console.ReadLine();

        switch (userInput) {
            case "+":
            p.addition();
            break;
            
            case "-":
            p.subtraction();
            break;

            case "*":
            p.multiplication();
            break;

            case "/":
            p.division();
            break;
        }
    

    }

    public void addition(){
        Console.WriteLine("addition mode activated");

        Console.WriteLine("insert the first number:");
        userInput = Console.ReadLine();
        int number1 = Convert.ToInt16(userInput); 

        Console.WriteLine($"you first number is {number1}, insert your second number:");
        userInput = Console.ReadLine();
        int number2 = Convert.ToInt16(userInput);

        int result = number1 + number2;
        
        Console.WriteLine($"your result is: {result}");
    }

   public void subtraction(){
        Console.WriteLine("subtraction mode activated");

        Console.WriteLine("insert the first number:");
        userInput = Console.ReadLine();
        int number1 = Convert.ToInt16(userInput); 

        Console.WriteLine($"you first number is {number1}, insert your second number:");
        userInput = Console.ReadLine();
        int number2 = Convert.ToInt16(userInput);

        int result = number1 - number2;
        Console.WriteLine($"your result is: {result}");
    }

    public void multiplication(){
        Console.WriteLine("multiplication mode activated");

        Console.WriteLine("insert the first number:");
        userInput = Console.ReadLine();
        int number1 = Convert.ToInt16(userInput); 

        Console.WriteLine($"you first number is {number1}, insert your second number:");
        userInput = Console.ReadLine();
        int number2 = Convert.ToInt16(userInput);

        int result = number1 * number2;
        Console.WriteLine($"your result is: {result}");
    }

    public void division(){
        Console.WriteLine("division mode activated");

        Console.WriteLine("insert the first number:");
        userInput = Console.ReadLine();
        int number1 = Convert.ToInt16(userInput); 

        Console.WriteLine($"you first number is {number1}, insert your second number:");
        userInput = Console.ReadLine();
        int number2 = Convert.ToInt16(userInput);

        int result = number1 / number2;
        Console.WriteLine($"your result is: {result}");
    }   

}