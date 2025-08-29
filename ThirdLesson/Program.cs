namespace CalculateSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the total number of hours worked: ");
            int workingHours = int.Parse(Console.ReadLine());
            Console.Write("Enter the hourly rate: $");
            double hourCost = double.Parse(Console.ReadLine());

            double sueldo = (double)workingHours * hourCost;
            Console.WriteLine("The employee's salary is: $" + sueldo.ToString());
            Console.ReadKey(); // Keep the console open until a key is pressed.
        }
    }
}