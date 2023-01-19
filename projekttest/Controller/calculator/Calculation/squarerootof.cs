using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.calculator.Calculation
{
    public class squarerootof : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public squarerootof(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();
            try
            {
                string type = "Square Root of";
                Console.WriteLine("here you will calculate the square root of mathematical calculatoin: ");
                //Console.WriteLine("write the method (Addition): ");
                //var type1 = Console.ReadLine().ToLower();
                var DT1 = DateTime.UtcNow;
                Console.WriteLine("Mata in nummer som du vill ta ruten ur för: ");
                var num1 = Convert.ToDouble(Console.ReadLine());
                //Console.WriteLine("MAta in andra nummer: ");
                //var num2 = Convert.ToDouble(Console.ReadLine());
                double answer1 = Math.Sqrt (num1);
                Console.WriteLine(Math.Round(answer1, 2));
                Console.WriteLine($"the answer of the square root of number {num1} answer is: = {Math.Round(answer1, 2)}");
                Console.WriteLine($"{DT1}");
                dbContext.calculators.Add(new Calculator
                {
                    Type = type,
                    Number1 = num1,
                    Number2 = 0,
                    result = Math.Round( answer1,2),
                    Date = DT1
                });
                dbContext.SaveChanges();
                //var Calculator = new Calculator
                //{
                //    Number1 = num1,
                //    Number2 = 0,
                //    Type = type
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
            catch (Exception) { Console.WriteLine("invalid input going back to Main Menu Site.");Console.ReadLine(); }
        }
    }
}
