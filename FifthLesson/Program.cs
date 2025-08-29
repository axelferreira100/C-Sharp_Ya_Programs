namespace NumberOperations;

public class Program
{
    public static void Main(string[] args)
    {
        double number1, number2, multiplication, addition;
        Console.Write("Enter the first number: ");
        number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        number2 = double.Parse(Console.ReadLine());

        multiplication = number1 * number2;
        addition = number1 + number2;
        Console.WriteLine($"The sum of the two numbers is: {addition}");
        Console.WriteLine($"The product of the two numbers is: {multiplication}");
        Console.ReadKey();
    }
}