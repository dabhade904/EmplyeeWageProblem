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
        public const int IS_FULL_TIME = 0;
        public const int IS_PART_TIME = 1;
        private string company;
        private int ratePerHrs;
        private int numberOfWorkingDay;
        private int totalWorkingHrs;
        private int totalWage;

        public EmplyeeWage(string company,int ratePerHrs,int numberOfWorkingDay,int totalWorkingHrs)
        {
            this.company = company;
            this.ratePerHrs = ratePerHrs;
            this.numberOfWorkingDay = numberOfWorkingDay;
            this.totalWorkingHrs=totalWorkingHrs;
        }

   
         public  void calculateEmployeeWage()
         {
             //variable
             int totalEmpHrs = 0;
             int totalWorkingDay = 0;
             int workingHours ;
             while (totalEmpHrs != this.totalWorkingHrs && totalWorkingDay != this.numberOfWorkingDay)
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
             totalWage = totalEmpHrs * ratePerHrs;
             Console.WriteLine("total wage for company "+company+" is " + totalWage);
         }
        public string toString()
        {
            return "Total emp wage for company : " + this.company + " is: " + this.totalWage;
        }
    }
}

