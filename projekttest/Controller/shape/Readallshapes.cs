using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.shape
{
    public class Readallshapes : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public Readallshapes(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();
            //Console.WriteLine("här är alla shapes, välj shapesID ");
            foreach (var cal in dbContext.shapes.OrderBy(x => x.shapeID))
            {
                Console.WriteLine($" \n shapeID \t{cal.shapeID} \n shapeTYPE \t{cal.type} \n shapeAREA " +
                    $"\t{cal.Area} \n shapePERIMETER \t{cal.Perimeter} \nshapedatetime \t{cal.Date} ");
            }
          Console.WriteLine("press any key to continuo");
            Console.ReadLine();
        }

    }
}
