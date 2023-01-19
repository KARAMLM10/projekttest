using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.calculator.Calculation
{
    public class Addition : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public Addition(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            try 
            { 
                Console.Clear();
                string addition1 = "Addition";
                Console.WriteLine("here you will calculate the Addition mathematical calculatoin: ");
                
                var DT1 = DateTime.UtcNow;
                Console.WriteLine("Mata in Första nummer: ");
                    var num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("MAta in andra nummer: ");
                    var num2 = Convert.ToDouble(Console.ReadLine());
                    double answer1 = Math.Round (num1,2) + Math.Round (num2,2);
                    Console.WriteLine($"the answer of the addition first number {Math.Round(num1,2)}  +  secund number {Math.Round(num2,2)}  is: = {Math.Round(answer1 , 2)}");
                Console.WriteLine($"{DT1}");
                dbContext.calculators.Add(new Calculator
                {
                    Type = addition1,
                    Number1 = Math.Round(num1,2),
                    Number2 = Math.Round(num2,2),
                    result = Math.Round(answer1, 2),
                    Date = DT1
                });
                dbContext.SaveChanges();
                //var calculator = new Calculator
                //{
                //    Number1= num1,
                //    Number2= num2,
                //    Type = addition1
                //};
                ////dbContext.RESULTs.Add(new RESULT 
                ////{
                ////    result = answer1,
                ////    Date = DT1
                ////});
                ////dbContext.SaveChanges
                //var calculation = new RESULT
                //{

                //    result = answer1,
                //    Date = DT1,
                //    Calculator= calculator
                //};
                //dbContext.calculators.Add(calculator);
                //dbContext.RESULTs.Add(calculation);
                //dbContext.SaveChanges();
                Console.WriteLine("press any key to continue");
                    Console.ReadLine();
            }

            catch (Exception){ Console.WriteLine("invalid input: going back to Main Menu Site. "); Console.ReadLine(); }

        }
    }
}
