namespace EmployeeWageProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage problem");
            EmplyeeWage empWageBuilder = new EmplyeeWage();
            empWageBuilder.addCompanyEmpWage("dMart", 20, 2, 10);
            empWageBuilder.addCompanyEmpWage("bridgelabz", 10, 4, 20);
            empWageBuilder.computeWage();   
        }
    }
}

