namespace FifthLessonProblems;

public class Exercise2
{
    public static void SecondExercise()
    {
        double number1, number2, number3, number4, sumTwoFirst, productTwoLast;
        
        Console.Write("Enter the first number: ");
        number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        number2 = double.Parse(Console.ReadLine());
        sumTwoFirst = number1 + number2;
        Console.Write("Enter the third number: ");
        number3 = double.Parse(Console.ReadLine());
        Console.Write("Enter the fourth number: ");
        number4 = double.Parse(Console.ReadLine());
        productTwoLast = number3 * number4;
        
        Console.WriteLine($"The sum of the first two numbers is: {sumTwoFirst}");
        Console.WriteLine($"The product of the last two numbers is {productTwoLast}");
        Console.ReadKey();
    }
}