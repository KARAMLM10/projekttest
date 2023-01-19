using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.calculator
{
    public class updatecalculator : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public updatecalculator(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("Ändra Befintlig Beräkning: ");
            foreach (var cal in dbContext.calculators.OrderBy(x => x.calculatorID))
            {
                Console.WriteLine($" \n CalculatorID \t{cal.calculatorID} \n calculator TYPE \t{cal.Type} \n calculator number1 " +
                    $"\t{cal.Number1} \n Calculator number2 \t{cal.Number2} \n calculation result \t {cal.result}  \n calculation date time {cal.Date} ");

            }
            //foreach (var cel in dbContext.RESULTs.OrderBy(s=>s.calculatorID)) 
            //    { Console.WriteLine($"  \n calculation result  \t {cel.result} " +
            //        $" \n calculation date time {cel.Date}"); 
            //    }
            
            try
            {
                Console.WriteLine("välje ID på den Beräkningen som du vill uppdatera: ");
                var calcuateidtoupdate = Convert.ToInt32(Console.ReadLine());
                var calculatetoupdate = dbContext.calculators.First(c=>c.calculatorID == calcuateidtoupdate);
                //var  resulidtoupdate = Convert.ToInt32(Console.ReadLine());
                //var resulttoupdate = dbContext.RESULTs.First((x=>x.calculatorID == resulidtoupdate));
                while (calcuateidtoupdate > 0)
                {
                    Console.WriteLine("1- om det Addition tryck på 1");
                    Console.WriteLine("2- om det Subtraction tryck på 2 ");
                    Console.WriteLine("3- om det Multiplication tryck på 3 ");
                    Console.WriteLine("4- om det Division tryck på 4 ");
                    Console.WriteLine("5- om det Square root of tryck på 5 ");
                    Console.WriteLine("6- om det Percent tryck på 6 ");
                    var num = Convert.ToInt32(Console.ReadLine());
                    if (num == 1)
                    {
                        Console.Clear();
                        string addition1 = "Addition";
                        Console.WriteLine("here you will calculate the Addition mathematical calculatoin: ");
                        //Console.WriteLine("write the method (Addition): ");
                        //var type1 = Console.ReadLine().ToLower();
                        var DT1 = DateTime.UtcNow;
                        Console.WriteLine("Mata in Första nummer: ");
                        var num1update = Convert.ToDouble(Console.ReadLine());
                        //var num1updated = dbContext.calculators.First((x=>x.Number1 == num1update));
                        Console.WriteLine("MAta in andra nummer: ");
                        var num2update = Convert.ToDouble(Console.ReadLine());
                        //var num2updated = dbContext.calculators.First(x => x.Number2 == num2update);
                        double answer1update = Math.Round(num1update,2) + Math.Round(num2update,2);
                        Console.WriteLine($"the answer of the addition first number {Math.Round(num1update,2)}  +  secund number {Math.Round(num2update, 2)}  is: = {Math.Round(answer1update,2)}");
                        Console.WriteLine($"{DT1}");
                        calculatetoupdate.Number1 = Math.Round( num1update,2);
                        calculatetoupdate.Number2 = Math.Round(num2update, 2);
                        calculatetoupdate.result = Math.Round(answer1update, 2);
                        calculatetoupdate.Date = DT1;
                       
                        dbContext.SaveChanges();
                        Console.WriteLine("press any key to continue");
                        Console.ReadLine();
                        break;

                    }
                    else if (num == 2)
                    {
                        Console.Clear();
                        string subtraction2 = "Subtraction";
                        var DT2 = DateTime. UtcNow;
                        Console.WriteLine("here you will calculate the Subtraction mathematical calculatoin: ");
                        Console.WriteLine("Mata in Första nummer: ");
                        var num1update = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("MAta in andra nummer: ");
                        var num2update = Convert.ToDouble(Console.ReadLine());
                        double answer1update = Math.Round(num1update,2) - Math.Round(num2update,2);
                        Console.WriteLine($"the answer of the subtraction first number {Math.Round(num1update, 2)}  -  secund number {Math.Round(num2update,2)}  is: = {Math.Round(answer1update,2)}");
                        Console.WriteLine($"{DT2}");
                        calculatetoupdate.Number1 = Math.Round(num1update, 2);
                        calculatetoupdate.Number2 = Math.Round(num2update, 2);
                        calculatetoupdate.Date = DT2;
                        calculatetoupdate.result = Math.Round(answer1update, 2);
                        dbContext.SaveChanges();
                        Console.WriteLine("press any key to contonue");
                        Console.ReadLine(); break;

                    }
                    else if (num == 3)
                    {
                        Console.Clear();
                        string multiplication = "Multiplication";
                        var DT3 = DateTime.UtcNow;
                        Console.WriteLine("here you will calculate the Multiplication mathematical calculatoin: ");
                        Console.WriteLine("Mata in Första nummer: ");
                        var num1update = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("MAta in andra nummer: ");
                        var num2update = Convert.ToDouble(Console.ReadLine());
                        double answer1update = Math.Round(num1update,2) * Math.Round(num2update,2);
                        Console.WriteLine($"the answer of the multiplication first number {Math.Round(num1update, 2)}   *  secund number  {Math.Round(num2update, 2)}   is: =  {Math.Round(answer1update, 2)}");
                        Console.WriteLine($"{DT3}");
                        calculatetoupdate.Number1 = Math.Round(num1update, 2);
                        calculatetoupdate.Number2 = Math.Round(num2update, 2);
                        calculatetoupdate.Date = DT3;
                        calculatetoupdate.result = Math.Round(answer1update, 2);
                        dbContext.SaveChanges();
                        Console.WriteLine("press any key to continue");
                        Console.ReadLine(); break;

                    }
                    else if (num == 4)
                    {
                        Console.Clear();
                        string division = "Division";
                        var DT4 = DateTime.Today;
                        Console.WriteLine("here you will calculate the Division mathematical calculatoin: ");
                        Console.WriteLine("Mata in Första nummer: ");
                        var num1update = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("MAta in andra nummer: ");
                        var num2update = Convert.ToDouble(Console.ReadLine());
                        double answer1update = Math.Round(num1update,2) / Math.Round(num2update,2);
                        Console.WriteLine($"the answer of the division first number {Math.Round(num1update, 2)}  /  secund number {Math.Round(num2update, 2)}  is: = {Math.Round(answer1update,2)}");
                        Console.WriteLine($"{DT4}");
                        calculatetoupdate.Number1 = Math.Round(num1update, 2);
                        calculatetoupdate.Number2 = Math.Round(num2update, 2);
                        calculatetoupdate.Date = DT4;
                        calculatetoupdate.result = Math.Round(answer1update, 2);
                        dbContext.SaveChanges();
                        Console.WriteLine("press any key to continue");
                        Console.ReadLine(); break;

                    }
                    else if (num == 5)
                    {
                        Console.Clear();
                        string type = "Square Root of";
                        Console.WriteLine("here you will calculate the square root of mathematical calculatoin: ");
                        //Console.WriteLine("write the method (Addition): ");
                        //var type1 = Console.ReadLine().ToLower();
                        var DT1 = DateTime.UtcNow;
                        Console.WriteLine("Mata in nummer som du vill ta ruten ur för: ");
                        var num1update = Convert.ToDouble(Console.ReadLine());
                        //Console.WriteLine("MAta in andra nummer: ");
                        //var num2 = Convert.ToDouble(Console.ReadLine());

                        double answer1update = Math.Sqrt(num1update);
                        Console.WriteLine(Math.Round(answer1update, 2));
                        Console.WriteLine($"the answer of the square root of number {Math.Round(num1update, 2)} answer is: = {Math.Round(answer1update,2)}");
                        Console.WriteLine($"{DT1}");
                        calculatetoupdate.Number1 = num1update;
                        calculatetoupdate.Date = DT1;
                        calculatetoupdate.result = Math.Round(answer1update, 2);
                        dbContext.SaveChanges();
                        Console.WriteLine("press any key to continue ");
                        Console.ReadLine(); break;

                    }
                    else if (num == 6)
                    {

                        Console.Clear();

                        string typr1 = "Percent";
                        Console.WriteLine("here you will calculate the percent of number mathematical calculatoin: ");
                        //Console.WriteLine("write the method (Addition): ");
                        //var type1 = Console.ReadLine().ToLower();
                        var DT1 = DateTime.UtcNow;
                        Console.WriteLine("Mata in nummer: ");
                        var num1update = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("MAta in procent: ");
                        var procentupdate = Convert.ToDouble(Console.ReadLine());
                        double answer1update = (Math.Round(num1update,2) * procentupdate) / 100;
                        Console.WriteLine($"the answer  is: =  {Math.Round(answer1update, 2)}% ");
                        Console.WriteLine($"{DT1}");
                        calculatetoupdate.Number1 = Math.Round(num1update, 2);
                        calculatetoupdate.Number2 = procentupdate;
                        calculatetoupdate.Date = DT1;
                        calculatetoupdate.result = Math.Round(answer1update, 2);
                        dbContext.SaveChanges();
                        Console.WriteLine("press any key to continue ");
                        Console.ReadLine(); break;
                    }
                    else break;

                }


            }
            catch (Exception) { Console.WriteLine("invalid input going back to Main Menu Site."); Console.ReadLine();  }

        }
    }
}
