using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.calculator.Calculation
{
    public class percent : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public percent(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();
            try
            {
                string typr1 = "Percent";
                Console.WriteLine("here you will calculate the percent of number mathematical calculatoin: ");
                //Console.WriteLine("write the method (Addition): ");
                //var type1 = Console.ReadLine().ToLower();
                var DT1 = DateTime.UtcNow;
                Console.WriteLine("Mata in nummer: ");
                var num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("MAta in procent: ");
                var procent = Convert.ToDouble(Console.ReadLine());
                double answer1 = (Math.Round(num1,2) * Math.Round(procent,2))/100;
                Console.WriteLine($"the answer  is: =  {Math.Round(answer1,2)}% ");
                Console.WriteLine($"{DT1}");
                dbContext.calculators.Add(new Calculator
                {
                    Type = typr1,
                    Number1 = Math.Round(num1, 2),
                    Number2 = procent,
                    result = Math.Round(answer1, 2),
                    Date = DT1
                });
                dbContext.SaveChanges();
                //var Calculator = new Calculator
                //{
                //    Number1 = num1,
                //    Number2 = procent,
                //    Type = typr1
                //};
                //var calculation = new RESULT
                //{

                //    result = answer1,
                //    Date = DT1,
                //    Calculator = Calculator
                //};
                //dbContext.calculators.Add(Calculator);
                //dbContext.RESULTs.Add(calculation);
                //dbContext.SaveChanges();

                Console.WriteLine("press any key to continue");
                Console.ReadLine();

            }
            catch (Exception) { Console.WriteLine("invalid input going back to Main Menu Site."); Console.ReadLine(); }
        }    
    }
}
