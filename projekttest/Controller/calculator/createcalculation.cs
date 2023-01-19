using projekttest.Controller.calculator.Calculation;
using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.calculator
{
    public class createcalculation : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public createcalculation(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            var appbuilder = new appbuilder();
            var DbContext = appbuilder.appBuilder();
            try
            {
              while (true)
              { 
                Console.Clear();
                    Console.WriteLine("Mathmatical Calculation Menu Site ");
                    Console.WriteLine("========================================");
                    Console.WriteLine("1- Addition ");
                    Console.WriteLine("2- Subtraction ");
                    Console.WriteLine("3- Multiplication");
                    Console.WriteLine("4- Division");
                    Console.WriteLine("5- Square root of");
                    Console.WriteLine("6- Percent");
                    var sel = Convert.ToInt32(Console.ReadLine());
                    switch (sel)
                    {
                        case 1:
                            var action1 = new Addition(DbContext);
                            action1.Run();
                            break;
                            case 2:
                                var action2 = new Subtraction(DbContext);
                                action2.Run();
                            break;
                            case 3:
                            var action3 = new Multiplication(DbContext);
                            action3.Run();
                            break;
                            case 4:
                            var action4 = new Division(DbContext);
                            action4.Run();
                            break;
                        case 5:
                            var action5 = new squarerootof(DbContext);
                            action5.Run();
                            break;
                        case 6:
                            var action6 = new percent(DbContext);
                            action6.Run();
                            break;

                        default: break;
                    }

                    break;


              }


            }
            catch(Exception) { Console.WriteLine("invalid input: going back to Main Menu Site. "); Console.ReadLine(); }
        }

    }
}
