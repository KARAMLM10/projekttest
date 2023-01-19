using Microsoft.EntityFrameworkCore;

namespace projekttest.Data
{
    public class DataInitializer
    {
       

            public void MigrateAndSeed(ApplicationDBContext dbContext)
            {
                dbContext.Database.Migrate();
                Seedshapes(dbContext);
                Seedcalculators(dbContext);
                dbContext.SaveChanges();
            }

        private void Seedcalculators(ApplicationDBContext dbContext)
        {
            dbContext.calculators.Any(k => k.calculatorID == 1);
        }

        private void Seedshapes(ApplicationDBContext dBContext)
        {
            if (!dBContext.shapes.Any(c => c.shapeID == 1))
            {
                dBContext.shapes.Add(new Shape
                {
                    type = "Rectangle",
                    Area = 5.5,
                    Perimeter= 8.5,
                    Date= DateTime.UtcNow,


                });
            }
            if (!dBContext.shapes.Any(c => c.shapeID == 2))
            {
                dBContext.shapes.Add(new Shape
                {
                    type = "Triangle",
                    Area = 2.6,
                    Perimeter= 4.8,
                    Date= DateTime.UtcNow,
                });
            }
            if (!dBContext.shapes.Any(c => c.shapeID == 3))
            {
                dBContext.shapes.Add(new Shape
                {
                    type = "Parallelogram",
                    Area = 3.2,
                    Perimeter= 4.2,
                    Date= DateTime.UtcNow,
                });
            }
            if (!dBContext.shapes.Any(c => c.shapeID == 4))
            {
                dBContext.shapes.Add(new Shape
                {
                    type = "Diamond",
                    Area = 4.2,
                    Perimeter= 5.4,
                    Date= DateTime.UtcNow,
                });
            }

        }
    }
}