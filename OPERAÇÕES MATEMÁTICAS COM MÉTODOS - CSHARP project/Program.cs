using System.Xml.XPath;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Program p = new Program();
        Console.WriteLine(p.subtraction(6, 2));
        Console.WriteLine(p.addition(2, 2));
        Console.WriteLine(p.multiplication(2,2));
        Console.WriteLine(p.division(8,2));
       
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