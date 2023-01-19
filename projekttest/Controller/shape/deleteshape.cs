using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.shape
{
    public class deleteshape : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public deleteshape(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            try { 

            Console.Clear();
            Console.WriteLine("ta bort en shape vilken? : ");
            foreach (var shape in dbContext.shapes)
            {
                Console.WriteLine($"\nshapeid \t{shape.shapeID}  \nshapetype  \t{shape.type} " +
                    $"\nshapearea \t{shape.Area} \nshapeperimeter \t{shape.Perimeter}");
            }
            Console.WriteLine("välj ID på den shape du vill radera: ");
            var shapeidtodelet = Convert.ToInt32(Console.ReadLine());
            var shapetodelet = dbContext.shapes.First(s=>s.shapeID == shapeidtodelet);
            dbContext.shapes.Remove(shapetodelet);
            dbContext.SaveChanges();

            Console.WriteLine("press any key to continue: ");
            Console.ReadLine();
            }
            catch (Exception) { Console.WriteLine("invalid input: going back to Main Menu Site. "); Console.ReadLine(); }
        }
    }
}
