using projekttest.Controller.shape;
using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.calculator
{
    public class calculatormenu : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public calculatormenu(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            var appbuilder = new appbuilder();
            var DbContext = appbuilder.appBuilder();
            //bool Main = true;
            try
            {
               
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Calculator Menu Site ");   
                    Console.WriteLine("============================");
                    Console.WriteLine("1- Create new Calculation: ");
                    Console.WriteLine("2- Read All Calculations: ");
                    Console.WriteLine("3- Update a calculation: ");
                    Console.WriteLine("4- Delet a calculation: ");
                    Console.WriteLine("0- go back to Main Menu :");
                    var sel = Convert.ToInt32(Console.ReadLine());
                    
                    switch (sel)
                    {
                        case 1:
                            var action1 = new createcalculation(DbContext);
                            action1.Run();
                            break;
                        case 2:
                            var action2 = new readallcalculations(DbContext);
                            action2.Run();
                            break;
                            case 3:
                                var action3  = new updatecalculator(DbContext);
                                action3.Run();
                            break;
                            case 4:
                                var action4 = new deletecalculation(DbContext);
                            action4.Run();
                            break;

                        default: break;

                    }
                    break;
                }

            }
            catch(Exception) { Console.WriteLine("invalid input: going back to Main Menu "); Console.ReadLine(); }

        }


    }
}
