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
        public static void calculateEmployeeWage()
        {
            //Constant
            int IS_EMP_PRESENT = 1;
            int WAGE_PER_HRS = 20, FLL_DAY_HRS = 8;
            Random obj = new Random();
            //variable
            int empCheck=obj.Next(2);
            if (empCheck == IS_EMP_PRESENT)
            {
                Console.WriteLine("employee is present");
                int wage = WAGE_PER_HRS * FLL_DAY_HRS;
                Console.WriteLine(wage);
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}
