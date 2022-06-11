using System;

namespace Employeewage1
{
    internal class Program
    {
        public const int IsPartTime = 4;
        public const int IsFullTime = 8;
        public const int IsAbsent = 0;
        static void Main(string[] args)
        {
            Program program = new Program();
            program.GetEmployeeWage();
        }

        public void GetEmployeeWage()
        {
           
            int WagePerHr = 20;
                        
            Random random = new Random();
            int number = random.Next(0, 2);
            Program program = new Program();
            int empHrs = program.GetEmpHrs(number);

            int Wage = WagePerHr * empHrs;
            
            Console.WriteLine("Total wage is " + Wage);
        }

        public int GetEmpHrs(int number)
        {
            int empHrs = 0;
            
            if(number == IsFullTime)
            {
                Console.WriteLine(number);
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
                Console.WriteLine(number);
            }
            return empHrs;

        }
    }
}
