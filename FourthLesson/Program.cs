namespace AreaCalculation;

public class Program
{
    public static void Main(string[] args)
    {
        double squareSide, squareArea = 0;
        Console.Write("Enter the length of the square's side: ");
        squareSide = double.Parse(Console.ReadLine());

        squareArea = squareSide * squareSide;
        Console.WriteLine($"The area of the square is: {squareArea}");
        Console.ReadKey();
    }
}