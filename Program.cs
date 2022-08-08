namespace EmployeeWageProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage problem");
            EmplyeeWage dMart =new EmplyeeWage("Dmart",20,2,10);
            EmplyeeWage bridgelabz = new EmplyeeWage("Dmart", 20, 2, 10);
            dMart.calculateEmployeeWage();
            bridgelabz.calculateEmployeeWage();
            Console.WriteLine(dMart.toString());
            Console.WriteLine(bridgelabz.toString());
        }
    }
}

