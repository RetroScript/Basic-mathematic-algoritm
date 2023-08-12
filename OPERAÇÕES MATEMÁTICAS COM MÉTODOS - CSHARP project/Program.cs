internal class Program
{

    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Program p = new Program();
        Console.WriteLine(p.subtraction(6, 3) +  Console.ReadLine());

       
    }

    

    public int subtraction(int number1, int number2){
        int result = number1 - number2;
        return result;
    }

}