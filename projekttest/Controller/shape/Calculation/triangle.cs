using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.shape.Calculation
{
    public class triangle : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public triangle(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            try { 

            Console.Clear();
                string triangle1 = "Triangle";
                var DT2 = DateTime.UtcNow;
           // Console.WriteLine("write the shape type it must be like (Triangle)");
           //var shapetype =  Console.ReadLine().ToLower();
            Console.WriteLine("here you can calculate the area and perimeter of triangle");
            Console.WriteLine("here you calculate the area of triangle");
            Console.WriteLine("mata in basen för trinagle");
            var bas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("mata in höjden för triangle");
            var hight = Convert.ToDouble(Console.ReadLine());
            var area2 = (Math.Round(bas, 2) * Math.Round(hight, 2)) / 2;
            Console.WriteLine("the area of the triangle is : " + Math.Round(area2, 2));
            Console.WriteLine("here you calculate the perimeter for the triangle: ");
            Console.WriteLine("mata in sida 1:");
            var sid1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("mata in sida 2:");
            var sid2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("mata in sida 3:");
            var sid3 =  Convert.ToDouble(Console.ReadLine());
            var perimeter2 = Math.Round( sid1,2) + Math.Round(sid2,2) + Math.Round(sid3,2);
            Console.WriteLine("the perimeter of the triangle is: " + Math.Round(perimeter2, 2) );

            dbContext.shapes.Add(new Shape
            {
                Date = DT2,

                type = triangle1,
                Area = Math.Round(area2,2),
                Perimeter = Math.Round(perimeter2, 2)

            });
            dbContext.SaveChanges();
            Console.WriteLine("press any key to continuo");
            Console.ReadLine();
            }
            catch (Exception) { Console.WriteLine("invalid input: going back to Main Menu Site. "); Console.ReadLine(); }
        }

    }
}
