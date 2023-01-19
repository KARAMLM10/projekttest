using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.shape
{
    public class shapeMenu : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public shapeMenu(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {

            var appbuilder = new appbuilder();
            var DbContext = appbuilder.appBuilder();
            // bool Main = true;
            try {

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("Shapes Menu Site ");    
                    Console.WriteLine("==============================");
                    Console.WriteLine("1- create new calculation for shapes from shape calculation menu");
                    Console.WriteLine("2- read all shapes");
                    Console.WriteLine("3- update a shape");
                    Console.WriteLine("4- delet a shape ");
                    Console.WriteLine("0- go back to mainmenu");
                    var sel = Convert.ToInt32(Console.ReadLine());
                    switch (sel)
                    {
                        case 1:
                            var action1 = new createnewcalculationmenu(DbContext);
                            action1.Run();
                            break;
                        case 2:
                            var action2 = new Readallshapes(DbContext);
                            action2.Run();
                            break;
                        case 3:
                            var action3 = new updateshape(DbContext);
                            action3.Run();
                            break;
                        case 4:
                            var action4 = new deleteshape(DbContext);
                            action4.Run();
                            break;


                        default: break;

                    }
                    break;
                }
            }
            catch (Exception) { Console.WriteLine("invalid input: going back to Main Menu Site. "); Console.ReadLine(); }
        }

    }
}
