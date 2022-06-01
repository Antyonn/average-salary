using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main()
        {
            var E1 = new Employee();
            var E2 = new Employee();

            Console.WriteLine("First employee data:");
            Console.Write("Name: ");
            E1.Name = Console.ReadLine();
            Console.Write("Salary: ");
            E1.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Second Employee:");
            Console.Write("Name: ");
            E2.Name = Console.ReadLine();
            Console.Write("Salary: ");
            E2.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double avg = (E1.Salary + E2.Salary) / 2;

            Console.WriteLine($"Average Salary =  {avg.ToString("E2", CultureInfo.InvariantCulture)}");
        }
    }
    public class Employee
    {
        public string Name;
        public double Salary;
    }
}