using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.calculator.Calculation
{
    public class Division : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public Division(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();
            try
            {
                string division = "Division";
                var DT4 = DateTime.UtcNow; 
                Console.WriteLine("here you will calculate the Division mathematical calculatoin: ");
                Console.WriteLine("Mata in Första nummer: ");
                var num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("MAta in andra nummer: ");
                var num2 = Convert.ToDouble(Console.ReadLine());

                //double answer1 = num1 / num2;
                //Console.WriteLine($"the answer of the addition first number {num1}  /  secund number {num2}  is: = {answer1}");

                double answer1 = Math.Round(num1, 2) / Math.Round(num2,2); 
                Console.WriteLine($"the answer of the division first number {Math.Round(num1, 2)}   /  secund number  {Math.Round(num2, 2)}   is: =  {Math.Round(answer1, 2)}");

                Console.WriteLine($"{DT4}");
                dbContext.calculators.Add(new Calculator
                {
                    Type = division,
                    Number1 = Math.Round(num1, 2),
                    Number2 = Math.Round(num2, 2),
                    result = Math.Round(answer1, 2),
                    Date = DT4
                });
                
                dbContext.SaveChanges();
                //var Calculator = new Calculator
                //{
                //    Number1 = num1,
                //    Number2 = num2,
                //    Type = division
                //};
                //var calculation = new RESULT
                //{

                //    result = answer1,
                //    Date = DT4,
                //    Calculator = Calculator
                //};
                //dbContext.calculators.Add(Calculator);
                //dbContext.RESULTs.Add(calculation);
                //dbContext.SaveChanges();
                Console.WriteLine("press any key to continue");
                Console.ReadLine();

            }
            catch (Exception) { Console.WriteLine("invlaid input: going back to Main Menu Site."); Console.ReadLine();}
        }

    }
}
