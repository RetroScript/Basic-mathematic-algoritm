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

        userInput = Console.ReadLine();

        Program p = new Program();

        switch (userInput) {
            case "+":
            Console.WriteLine(p.addition(2, 2));
            break;
            
            case "-":
            Console.WriteLine(p.subtraction(6, 2));
            break;

            case "*":
            Console.WriteLine(p.multiplication(2,2));
            break;

            case "/":
            Console.WriteLine(p.division(8,2));
            break;
        }
        

        
        

       
    }

    public int addition(int number1, int number2){
        int result = number1 + number2;
        return result;
    }

    public int subtraction(int number1, int number2){
        int result = number1 - number2;
        return result;
    
    }

    public int multiplication(int number1, int number2){
        int result = number1 * number2;
        return result;
    }

    public int division(int number1, int number2){
        int result = number1 / number2;
        return result;
    }    

}