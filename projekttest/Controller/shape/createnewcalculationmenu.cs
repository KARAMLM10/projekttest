using projekttest.Controller.shape.Calculation;
using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.shape
{
    public class createnewcalculationmenu : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public createnewcalculationmenu(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            var appbuilder = new appbuilder();
            var DbContext = appbuilder.appBuilder();
            //Console.Clear();
            //Console.WriteLine("här är alla shapes, välj shapesID ");
            //foreach (var cal in dbContext.shapes.OrderBy(x => x.shapeID))
            //{
            //    Console.WriteLine($"{cal.shapeID} \t {cal.type} ");
            //}

            //Console.WriteLine("ange shape ID");
            //var shapeid = Convert.ToDouble(Console.ReadLine());
            try 
            { 

             while (true)
             {
                Console.Clear();
                Console.WriteLine("Shapes Calculatoin Menu Site ");
                Console.WriteLine("=====================================");
                Console.WriteLine("1- calculate a rectangel");
                Console.WriteLine("2- calculate a triangle");
                Console.WriteLine("3- calculate a parallellogram");
                Console.WriteLine("4- calculate a diamond ");
                Console.WriteLine("5- go back to shapemenu");
                Console.WriteLine("0- go back to mainmenu");
                var sel = Convert.ToInt32(Console.ReadLine());
                switch (sel)
                {
                    case 1:
                        var action1 = new rectangel(DbContext);
                        action1.Run();
                        break;
                    case 2: 
                        var action2 = new triangle(DbContext);
                        action2.Run();
                        break;
                    case 3:
                        var action3 = new parallellogram(DbContext);
                        action3.Run();
                        break;
                    case 4:
                        var action4 = new diamond(DbContext);
                        action4.Run();
                        break;
                        case 5:
                        var action5 = new shapeMenu(dbContext);
                        action5.Run();
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
