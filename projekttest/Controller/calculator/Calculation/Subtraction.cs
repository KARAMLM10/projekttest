using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.calculator.Calculation
{
    public class Subtraction : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public Subtraction(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();
            try
            {
                string subtraction2 = "Subtraction";
                var DT2 = DateTime.UtcNow;
                Console.WriteLine("here you will calculate the Subtraction mathematical calculatoin: ");
                Console.WriteLine("Mata in Första nummer: ");
                var num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("MAta in andra nummer: ");
                var num2 = Convert.ToDouble(Console.ReadLine());
                double answer1 = Math.Round(num1, 2) - Math.Round(num2, 2);
                Console.WriteLine($"the answer of the subtraction first number {Math.Round(num1, 2)}  -  secund number {Math.Round(num2, 2)}  is: = {Math.Round(answer1,2)}");
                Console.WriteLine($"{DT2}");
                dbContext.calculators.Add(new Calculator
                {
                    Type = subtraction2,
                    Number1 = Math.Round(num1, 2),
                    Number2 = Math.Round(num2, 2),
                    result = Math.Round(answer1, 2),
                    Date = DT2
                });
                dbContext.SaveChanges();
                //var Calculator = new Calculator
                //{
                //    Number1 = num1,
                //    Number2 = num2,
                //    Type = subtraction2
                //};
                //var calculation = new RESULT
                //{

                //    result = answer1,
                //    Date = DT2,
                //    Calculator = Calculator
                //};
                //dbContext.calculators.Add(Calculator);
                //dbContext.RESULTs.Add(calculation);
                //dbContext.SaveChanges();
                Console.WriteLine("press any key to continue");
                Console.ReadLine();


            }
            catch (Exception) { Console.WriteLine("invalid input: going back to Main Menu Site."); }
        }

    }
}
