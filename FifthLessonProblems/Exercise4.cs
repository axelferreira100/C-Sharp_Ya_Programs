namespace FifthLessonProblems;

public class Exercise4
{
    public static void FourthExercise()
    {
        double itemPrice, totalToPay;
        int itemQuantity;
        Console.Write("Enter the item's price: $");
        itemPrice = double.Parse(Console.ReadLine());
        Console.Write("Enter the item's quantity to purchase: ");
        itemQuantity = int.Parse(Console.ReadLine());

        totalToPay = itemPrice * double.Parse(itemQuantity);
        Console.WriteLine($"The total amount the buyer must pay is: ${totalToPay}");
        Console.ReadKey();
    }
}