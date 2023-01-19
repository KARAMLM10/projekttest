using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.shape.Calculation
{
    public  class rectangel : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public rectangel(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();
            try {
                //Console.WriteLine("mata in shape type it must be like (Rectangle)");
                //var shapetype =Console.ReadLine().ToLower();
                string rectangle1 = "Rectangle";
            var dateNow = DateTime.UtcNow;
            Console.WriteLine("here you can calculate the area and perimeter of rectangel: ");
            Console.WriteLine("here you calculate th area of rectangel: ");
            Console.WriteLine($"mata in lenght för rectangel: ");
            var length = Convert.ToDouble(Console.ReadLine());
            //double length = 4.5;
            Console.WriteLine($"mata in width för  rectangel");
            var width = Convert.ToDouble(Console.ReadLine());
            //double width = 7.2;
            double area = Math.Round(length, 2) * Math.Round(width, 2);
            Console.WriteLine("The area of the rectangle is: " + Math.Round(area, 2));
            Console.WriteLine("here you will calculate the perimeter of rectangel: ");

            Console.WriteLine($"mata in length för  rectangel");
            var length1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"mata in width för  rectangel");
            var width1 = Convert.ToDouble(Console.ReadLine());
            double perimeter = 2 * (Math.Round(length1,2) + Math.Round( width1,2));
            Console.WriteLine("the perimeter of the rectangel is: " + Math.Round(perimeter, 2));
            Console.WriteLine(dateNow);
            dbContext.shapes.Add(new Shape
            {
                //shapeID = shapeid,
                Date = dateNow,
                type = rectangle1,
                Area = Math.Round(area, 2),
                Perimeter = Math.Round(perimeter, 2)

            });
            dbContext.SaveChanges();
            Console.WriteLine("press any key to contino");
            Console.ReadLine();
            }
            catch (Exception) { Console.WriteLine("invalid inpt: going back to Main Menu Site."); Console.ReadLine(); }
        }


    }
}
