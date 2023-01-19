using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.shape.Calculation
{
    public class parallellogram : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public parallellogram(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();
            try 
            { 

            //Console.WriteLine("mata in shape type it must be like (Parallellogram) ");
            //var shapetype=Console.ReadLine().ToLower();
            string parallellogram = "Parallellogram";
                var DT3= DateTime.UtcNow;
            Console.WriteLine("here you can calculate the area and perimeter for parallellogram");
            Console.WriteLine("calculate the area : ");
            Console.WriteLine("mata in basen: ");
            var bas3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("mata in höjden: ");
            var hight3 = Convert.ToDouble(Console.ReadLine());
            var area3 = Math.Round(bas3,2) * Math.Round(hight3,2);
            Console.WriteLine("the area of the parallellogram is: " + Math.Round(area3,2));

            Console.WriteLine("here you calculate the perimeter for parallellogram: ");
            Console.WriteLine("calculate the perimeter: ");
            Console.WriteLine("mata in basen: ");
            var basen3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("mata in length: ");
            var length3 = Convert.ToDouble(Console.ReadLine());
            var perimeter3 = Math.Round(basen3, 2) * 2 + Math.Round(length3, 2) * 2;
            Console.WriteLine("the perimeter of the parrallellogram is: " + Math.Round(perimeter3,2));

            dbContext.shapes.Add(new Shape
            {
                Date = DT3,
                type = parallellogram,
                Area = Math.Round(area3, 2),
                Perimeter = Math.Round(perimeter3, 2)
            });
            dbContext.SaveChanges();
            Console.WriteLine("press any key to contino");
            Console.ReadLine();
            }
            catch (Exception) { Console.WriteLine("invalid input: going back to Main Menu Site. "); Console.ReadLine(); }

        }

    }
}
