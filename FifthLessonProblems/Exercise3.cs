namespace FifthLessonProblems;

public class Exercise3
{
    public static void ThirdExercise()
    {
        double number1, number2, number3, number4, sum = 0, average;
        Console.Write("Enter the first number: ");
        number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        number2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        number3 = double.Parse(Console.ReadLine());
        Console.Write("Enter the fourth number: ");
        number4 = double.Parse(Console.ReadLine());

        sum = number1 + number2 + number3 + number4;
        average = sum / 4;
        Console.WriteLine($"The sum of the four numbers is: {sum}");
        Console.WriteLine($"The average of the four numbers is: {average}");
        Console.ReadKey();
    }
}