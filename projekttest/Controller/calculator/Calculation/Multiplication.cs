using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.calculator.Calculation
{
    public class Multiplication : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public Multiplication(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();
            try
            {
                string multiplication = "Multiplication";
                var DT3 = DateTime.UtcNow;
                Console.WriteLine("here you will calculate the Multiplication mathematical calculatoin: ");
                Console.WriteLine("Mata in Första nummer: ");
                var num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("MAta in andra nummer: ");
                var num2 = Convert.ToDouble(Console.ReadLine());
                double answer1 = Math.Round( num1,2) * Math.Round( num2,2);
                Console.WriteLine($"the answer of the multiplication first number {Math.Round(num1, 2)}  *  secund number {Math.Round(num2, 2)}  is: = {Math.Round(answer1)}");
                Console.WriteLine($"{DT3}");
                dbContext.calculators.Add(new Calculator
                {
                    Type = multiplication,
                    Number1 = Math.Round(num1, 2),
                    Number2 = Math.Round(num2, 2),
                    result = Math.Round(answer1, 2),
                    Date = DT3
                });
                dbContext.SaveChanges();
               
                Console.WriteLine("press any key to continue");
                Console.ReadLine();

            }

            catch (Exception) { Console.WriteLine("invalid input: going back to Main Menu Site."); }
        }
    }
}
