using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller
{
    public class MainMenu
    {
        public static int ShowMenu()
        {

            
            while (true) { 
            Console.Clear();
            Console.WriteLine("MAin Menu Site");
            Console.WriteLine("============================");
            Console.WriteLine("1:shape Menu");
            Console.WriteLine("2:calculator Menu");
            Console.WriteLine("3:sten , sax , påse Menu");

           // Console.WriteLine("0: Exit");

            var sel = Convert.ToInt32(Console.ReadLine());

            return sel;
            }

        }
    }
}
