using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.calculator
{
    public class readallcalculations : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public readallcalculations(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("här är alla Beräkningar: ");
            foreach (var cal in dbContext.calculators.OrderBy(x => x.calculatorID))
            {
                Console.WriteLine($" \n CalculatorID \t{cal.calculatorID} \n calculator TYPE \t{cal.Type} \n calculator number1 " +
                    $"\t{cal.Number1} \n Calculator number2 \t{cal.Number2} \n calculator datetime  {cal.Date} \n calculation result  {cal.result} ");

                //foreach (var cel in dbContext.RESULTs.OrderBy(s => s.calculatorID))
                //{
                //    Console.WriteLine($" \n calculator datetime  {cel.Date}" + $"\n resultid {cel.RESULTID}" +
                // $" \n calculation result  {cel.result}");
                //}
            }
           
            Console.WriteLine("press any key to continuo");
            Console.ReadLine();

        }
    }
}
