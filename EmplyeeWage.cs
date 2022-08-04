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
        public const int IS_FULL_TIME = 0;
        public const int IS_PART_TIME = 1;
        public const int WORKING_DAY_PER_MONTH = 20;
        public  void calculateEmployeeWage(string company,int ratePerHrs , int numberOfWorkingDay, int TOTAL_WORKING_HRS)
        {
            //variable
            int totalEmpHrs = 0;
            int totalWorkingDay = 0;
            int workingHours ;
            while (totalEmpHrs != TOTAL_WORKING_HRS && totalWorkingDay != numberOfWorkingDay)
            {
                totalWorkingDay++;
                Random obj = new Random();
                int empCheck = obj.Next(3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        workingHours = 8;
                         break;
                    case IS_PART_TIME:
                        workingHours = 4;
                        break;
                    default:
                        workingHours = 0;
                        break;
                }
                totalEmpHrs += workingHours;  
                Console.WriteLine("day "+totalWorkingDay+" wage is " + workingHours);
            }
            int wage = totalEmpHrs * ratePerHrs;
            Console.WriteLine("total wage for company "+company+" is " + wage);
        }
    }
}

