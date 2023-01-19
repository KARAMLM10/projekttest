using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.calculator
{
    public class deletecalculation : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public deletecalculation(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ta bot en Calculation. ");
                foreach (var cal in dbContext.calculators)
                {
                    Console.WriteLine($" \n CalculatorID \t{cal.calculatorID} \n calculator TYPE \t{cal.Type} \n calculator number1 " +
                        $"\t{cal.Number1} \n Calculator number2 \t{cal.Number2} " + $"\ncalculator datetime {cal.Date}" +
                    $"{cal.calculatorID}");
                }
                //foreach (var cel in dbContext.RESULTs) { Console.WriteLine($"\ncalculator datetime {cel.Date}" +
                //    $"{cel.calculatorID}"); }
                Console.WriteLine("Välje ID på den calculation du vill radera: ");
                var calclulationidtodelete = Convert.ToInt32( Console.ReadLine() );
                var calculationtodelete = dbContext.calculators.First(c=>c.calculatorID == calclulationidtodelete);
                dbContext.calculators.Remove(calculationtodelete);
                dbContext.SaveChanges();
                Console.WriteLine("press any key to continue: ");
                Console.ReadLine();
                

            }
            catch(Exception) { Console.WriteLine("invalid input going back to Main Menu Site."); Console.ReadLine(); }

            
        }

    }
}
