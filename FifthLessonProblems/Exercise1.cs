namespace FifthLessonProblems;

public class Exercise1
{
    public static void FirstExercise() {
        double squareSide, perimeter;
        Console.Write("Enter the length of the square's side: ");
        squareSide = double.Parse(Console.ReadLine());

        perimeter = squareSide * 4;
        Console.WriteLine($"The perimeter of the square is: {perimeter}");
        Console.ReadKey();
    }
}