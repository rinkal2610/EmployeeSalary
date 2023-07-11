using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSalary
{
    //exercise 01 day 02
    internal class Program
    {
        public class EmpSalary
        {
            public void Employee(int wh,int wd, int ph, int extras)
            {
                int cacl = ((wh * wd * 100) + (ph * 3000) + (extras * 2000));
                Console.WriteLine("Calculation= "+cacl);
            }
        }
        static void Main(string[] args)
        {
            EmpSalary emp = new EmpSalary();
            string type;
            Console.WriteLine("enter employee type");
            type = Console.ReadLine();
            switch(type)
            {
                case "HR":
                    {
                        Console.WriteLine("enter working hours and working days");
                        int wh = int.Parse(Console.ReadLine());
                        int wd = int.Parse(Console.ReadLine());
                        emp.Employee(wh, wd, 1, 0);
                        break;
                    }
                case "Admin":
                    {
                        Console.WriteLine("enter working hours, working days, project handles");
                        int wh = int.Parse(Console.ReadLine());
                        int wd = int.Parse(Console.ReadLine());
                        int ph = int.Parse(Console.ReadLine());
                        emp.Employee(wh, wd, ph, 0);
                        break;
                    }
                case "Software Developer":
                    {
                        Console.WriteLine("enter working hours, working days, project handles");
                        int wh = int.Parse(Console.ReadLine());
                        int wd = int.Parse(Console.ReadLine());
                        int ph = int.Parse(Console.ReadLine());
                        int extras = int.Parse(Console.ReadLine());
                        emp.Employee(wh, wd, ph, extras);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("wrong choice");
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
