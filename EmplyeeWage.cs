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
            Random obj = new Random();
            
            //variable
            int empCheck=obj.Next(2);
            if (empCheck == IS_EMP_PRESENT)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}
