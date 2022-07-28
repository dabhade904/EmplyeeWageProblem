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
            int WAGE_PER_HRS = 20, FLL_DAY_HRS = 8,PART_TIME_WAGE=4;
            Random obj = new Random();
            //variable
            int empCheck=obj.Next(3);
            switch (empCheck)
              {
                  case 0:
                      int fullDayWage = WAGE_PER_HRS * FLL_DAY_HRS;
                      Console.WriteLine("full day wage is :" + fullDayWage);
                      break;
                  case 1:
                      int partTimeWage = WAGE_PER_HRS * PART_TIME_WAGE;
                      Console.WriteLine("part time wage is : " + partTimeWage);
                      break ;
                  default:
                      Console.WriteLine("employee is absent");
                      break;
              } 
        }
    }
}
