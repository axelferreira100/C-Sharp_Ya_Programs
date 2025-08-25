namespace CalculateSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de horas trabajadas: ");
            int horasTrabajadas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el costo por hora: $");
            double costoPorHora = double.Parse(Console.ReadLine());

            double sueldo = (double)horasTrabajadas * costoPorHora;
            Console.WriteLine("El sueldo a percibir el empleado ingresado es de: $" + sueldo.ToString());
            Console.ReadKey(); // This line makes that the console don't disapear, waits a key from the user.
        }
    }
}