using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.shape.Calculation
{
    public class diamond : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public diamond(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();
            try { 

            Console.WriteLine("here you calculate the area and perimeter for (romb) diamond: ");
                //Console.WriteLine("write the shape type for diamond: ");
                //var shapetype = Console.ReadLine().ToLower();
                string diamond = "Diamond";
            var dateNow = DateTime.UtcNow;
            Console.WriteLine("calculate the perimeter : ");
            Console.WriteLine("mata in sidlength: ");
            var sidlenght4 = Convert.ToDouble(Console.ReadLine());
            var perimeter4 = Math.Round( sidlenght4,2) * 4;
            Console.WriteLine("the perimeter for sidlength is : " + Math.Round(perimeter4, 2));
            Console.WriteLine("mata in basen: ");
            var basen4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("mata in hight: ");
            var hight4 = Convert.ToDouble(Console.ReadLine());
            var area4 = Math.Round( basen4,2) * Math.Round( hight4,2);
            Console.WriteLine("the area of the diamond is:  " + Math.Round(area4,2) );
            Console.WriteLine(dateNow);
            dbContext.shapes.Add(new Shape
            {
                Date = dateNow,
                type = diamond,
                Area = Math.Round( area4,2),
                Perimeter = Math.Round(perimeter4,2)

            });
            dbContext.SaveChanges();
            Console.WriteLine("press any key to contino");
            Console.ReadLine();
            }
            catch(Exception) { Console.WriteLine("invalid inpt: going back to Main Menu: "); Console.ReadLine(); }
        }

    }
}
