using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class EmplyeeWage
    {
        /// <summary>
        ///  calculating the Employee Wages
        /// </summary>
        /// 
        //Constant
        public const int IS_FLL_TIME = 0;
        public const int IS_PART_TIME = 1;
        public const int WAGE_PER_HRS = 20;
        public const int WORKING_DAY_PER_MONTH = 20;
        public const int TOTAL_WORKING_HRS = 100;
        public  void calculateEmployeeWage()
        {
            //variable
            int totalWorkingHrs = 0;
            int totalWorkingDay=0;
            int workingHours = 0;
            while (totalWorkingHrs != TOTAL_WORKING_HRS && totalWorkingDay != WORKING_DAY_PER_MONTH)
            {
                totalWorkingDay++;
                Random obj = new Random();
                int empCheck = obj.Next(3);
                switch (empCheck)
                {
                    case IS_FLL_TIME:
                        workingHours = 8;
                         break;
                    case IS_PART_TIME:
                        workingHours = 4;
                        break;
                    default:
                        workingHours = 0;
                        break;
                }
                totalWorkingHrs += workingHours;  
                Console.WriteLine("day "+totalWorkingDay+" wage is " + workingHours);
            }
            int wage = totalWorkingHrs * WAGE_PER_HRS;
            Console.WriteLine("total wage for a month is " + wage);
        }
    }
}

