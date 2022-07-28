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
            int IS_FLL_DAY = 0,IS_HALF_DAY=1;
            int WAGE_PER_HRS = 20, FLL_DAY_HRS = 8,PART_TIME_WAGE=4;
            Random obj = new Random();
            //variable
            int empCheck=obj.Next(3);
            if (empCheck == IS_FLL_DAY)
            {
                int dailyWage = WAGE_PER_HRS * FLL_DAY_HRS;
                Console.WriteLine("full day wage is :" + dailyWage);
            }else if (empCheck == IS_HALF_DAY)
            {
                int dailyWage = WAGE_PER_HRS * PART_TIME_WAGE;
                Console.WriteLine("part time wage is : "+dailyWage);
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}
