using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    /// <summary>
    /// 
    /// </summary>
    public class EmplyeeWage
    {
        /// <summary>
        ///  calculating the Employee Wages
        /// </summary>
        public  void calculateEmployeeWage()
        {
            //Constant
            int WAGE_PER_HRS = 20,WORKING_DAY_PER_MONTH=20;
            int totalWage = 0;
            for (int i = 1; i < WORKING_DAY_PER_MONTH; i++)
            {
                Random obj = new Random();
                //variable
                int empCheck = obj.Next(3);
                int workingHours = 0;
                switch (empCheck)
                {
                    case 0:
                        workingHours = 8;
                         break;
                    case 1:
                        workingHours = 4;
                        break;
                    default:
                        Console.WriteLine("employee is absent");
                        break;
                }
                int wage = workingHours * WAGE_PER_HRS;
                Console.WriteLine("day " +i+" wage is " + wage);
                totalWage += wage;
            }
            Console.WriteLine("total wage for a month is " + totalWage);
        }
    }
}
