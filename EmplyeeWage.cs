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
            int WAGE_PER_HRS = 20;
            Random obj = new Random();
            //variable
            int empCheck=obj.Next(3);
            int workingHours = 0;
            switch (empCheck)
              {
                  case 0:
                        workingHours = 8;
                        Console.WriteLine("full day wage is :"+workingHours );
                      break;
                  case 1:
                        workingHours = 4;
                        Console.WriteLine("part time wage is : "+workingHours);
                      break ;
                  default:
                        Console.WriteLine("employee is absent");
                      break;
              }
            int wage = workingHours * WAGE_PER_HRS;
            Console.WriteLine("employee wages are "+wage);
        }
    }
}
