using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using projekttest.Controller;
using projekttest.Controller.calculator;
using projekttest.Controller.shape;
using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest
{
    public class app
    {
        public void Run()
        {
            var appbuilder = new appbuilder();
            var DbContext = appbuilder.appBuilder();

            try { 

             while (true)
             {
                var sel = MainMenu.ShowMenu();
                switch (sel)
                {
                    case 1:
                        var action1 = new shapeMenu(DbContext);
                        action1.Run();
                        break;
                        case 2:
                            var action2 = new calculatormenu(DbContext);
                            action2.Run();
                            break;
                        case 3:
                            var action3 = new RPSgame(DbContext);
                            action3.Run();
                            break;

                            default: break;
                }
             }
            }
            catch (Exception) { Console.WriteLine("invalid input: Shutting down. "); Console.ReadLine(); }
        }
    }
}
