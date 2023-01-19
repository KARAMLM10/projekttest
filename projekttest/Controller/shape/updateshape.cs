using projekttest.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Controller.shape
{
    public class updateshape : Ishape
    {
        public ApplicationDBContext dbContext { get; set; }
        public updateshape(ApplicationDBContext context)
        {
            dbContext = context;
        }
        public void Run()
        {
            Console.Clear();
            Console.WriteLine("ändra befintlig area och omkrets: ");
            foreach (var shape in dbContext.shapes)
            {
                Console.WriteLine($":id \t{shape.shapeID} ");
                Console.WriteLine($":type \t {shape.type} ");
                Console.WriteLine($":area \t {shape.Area} ");
                Console.WriteLine($":perimeter \t {shape.Perimeter} ");
            }

            try { 
            Console.WriteLine("välje id på den shape som du vill uppdatera: ");
            var shapeidtoupdate = Convert.ToInt32( Console.ReadLine() );
            var shapetoupdate = dbContext.shapes.First(s => s.shapeID == shapeidtoupdate);
            
            
            while (shapeidtoupdate > 0)
            {

                //Console.WriteLine("vad vill du uppdatera välj siffra mellan 1-4 : ");
                Console.WriteLine("1-om det rectangle som du vill uppdatera tryck på 1: ");
                Console.WriteLine("2-om det triangle som du vill updateras tryck på 2: ");
                Console.WriteLine("3-om det parallellogram som du vill updateras tryck på 3: ");
                Console.WriteLine("4-om det diamond (Roomb) som du vill updateras tryck på 4: ");
                var num = Convert.ToInt32( Console.ReadLine() );

                if (num == 1)
                {
                    Console.Clear();
                    var dateNow = DateTime.UtcNow;
                    Console.WriteLine("here you can calculate the area and perimeter of rectangel: ");
                    Console.WriteLine("here you calculate th area of rectangel: ");
                    Console.WriteLine($"mata in lenght för rectangel: ");
                    var length = Convert.ToDouble(Console.ReadLine());
                    //double length = 4.5;
                    Console.WriteLine($"mata in width för  rectangel");
                    var width = Convert.ToDouble(Console.ReadLine());
                    //double width = 7.2;
                    double areaupdate1 = Math.Round(length,2) * Math.Round(width,2);
                    Console.WriteLine("The area of the rectangle is: " + Math.Round(areaupdate1, 2) );
                    Console.WriteLine("here you will calculate the perimeter of rectangel: ");

                    Console.WriteLine($"mata in length för  rectangel");
                    var length1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"mata in width för  rectangel");
                    var width1 = Convert.ToDouble(Console.ReadLine());
                    double perimeterupdate1 = 2 * ( Math.Round(length1,2) + Math.Round(width1, 2));
                    Console.WriteLine("the perimeter of the rectangel is: " + Math.Round(perimeterupdate1, 2));
                    shapetoupdate.Area = Math.Round(areaupdate1, 2);
                    shapetoupdate.Perimeter = Math.Round(perimeterupdate1, 2);
                    shapetoupdate.Date = dateNow;
                    dbContext.SaveChanges();
                    Console.WriteLine("press any key to continou");
                    Console.ReadLine();
                    break;
                }
                else if (num == 2)
                {
                    Console.Clear();
                    Console.WriteLine("here you can calculate the area ond perimeter of triangle");
                    Console.WriteLine("here you calculate the area of circle");
                    Console.WriteLine("mata in basen för trinagle");
                    var bas = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("mata in höjden för triangle");
                    var hight = Convert.ToDouble(Console.ReadLine());
                    var areaupdate2 = (Math.Round(bas, 2) * Math.Round(hight, 2)) / 2;
                    Console.WriteLine("the area of the triangle is : " + Math.Round(areaupdate2, 2));
                    Console.WriteLine("here you calculate the perimeter for the triangle: ");
                    Console.WriteLine("mata in sida 1:");
                    var sid1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("mata in sida 2:");
                    var sid2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("mata in sida 3:");
                    var sid3 = Convert.ToDouble(Console.ReadLine());
                    var perimeterupdate2 = Math.Round(sid1, 2) + Math.Round(sid2, 2) + Math.Round(sid3,2);
                    Console.WriteLine("the perimeter of the triangle is: " + Math.Round(perimeterupdate2, 2));
                    var dateNow2 = DateTime.UtcNow;
                    shapetoupdate.Area = Math.Round(areaupdate2, 2);
                    shapetoupdate.Perimeter = Math.Round(perimeterupdate2, 2);
                    shapetoupdate.Date = dateNow2;
                    dbContext.SaveChanges();
                    Console.WriteLine("press any key to continou");
                    Console.ReadLine();
                    break;
                }
                else if (num == 3)
                {
                    Console.Clear();
                    Console.WriteLine("here you can calculate the area and perimeter for parallellogram");
                    Console.WriteLine("calculate the area : ");
                    Console.WriteLine("mata in basen: ");
                    var bas3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("mata in höjden: ");
                    var hight3 = Convert.ToDouble(Console.ReadLine());
                    var areaupdate3 = Math.Round(bas3, 2) * Math.Round(hight3, 2);
                    Console.WriteLine("the area of the parallellogram is: " + Math.Round(areaupdate3, 2));

                    Console.WriteLine("here you calculate the perimeter for parallellogram: ");
                    Console.WriteLine("calculate the perimeter: ");
                    Console.WriteLine("mata in basen: ");
                    var basen3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("mata in length: ");
                    var length3 = Convert.ToDouble(Console.ReadLine());
                    var perimeterupdate3 = Math.Round(basen3, 2) * 2 + Math.Round(length3, 2) * 2;
                    Console.WriteLine("the perimeter of the parrallellogram is: " + Math.Round(perimeterupdate3, 2));
                    var dateNow3 = DateTime.UtcNow;
                    shapetoupdate.Area = Math.Round(areaupdate3, 2);
                    shapetoupdate.Perimeter = Math.Round(perimeterupdate3, 2);
                    shapetoupdate.Date = dateNow3;
                    dbContext.SaveChanges();
                    Console.WriteLine("press any key to continou");
                    Console.ReadLine();
                    break;
                }
                else if (num == 4)
                {
                    Console.Clear();
                    Console.WriteLine("here you calculate the area and perimeter for (romb) diamond: ");
                    //Console.WriteLine("write the shape type for diamond: ");
                    //var shapetype = Console.ReadLine().ToLower();
                    var dateNow4 = DateTime.UtcNow;
                    Console.WriteLine("calculate the perimeter : ");
                    Console.WriteLine("mata in sidlength: ");
                    var sidlenght4 = Convert.ToDouble(Console.ReadLine());
                    var perimeterupdate4 = Math.Round(sidlenght4, 2) * 4;
                    Console.WriteLine("the perimeter for sidlength is : " + Math.Round(perimeterupdate4, 2));
                    Console.WriteLine("mata in basen: ");
                    var basen4 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("mata in hight: ");
                    var hight4 = Convert.ToDouble(Console.ReadLine());
                    var areaupdate4 = Math.Round(basen4, 2) * Math.Round(hight4, 2);
                    Console.WriteLine("the area of the diamond is:  " + Math.Round(areaupdate4, 2));
                    Console.WriteLine(dateNow4);
                    shapetoupdate.Area = Math.Round(perimeterupdate4, 2);
                    shapetoupdate.Perimeter = Math.Round(areaupdate4, 2);
                    shapetoupdate.Date = dateNow4;
                    dbContext.SaveChanges();
                    Console.WriteLine("press any key to continou");
                    Console.ReadLine();
                    break;
                }

                else
                    break;

            }
            }
            catch (Exception) 
            {
                Console.WriteLine("invalid input: going back to Main Menu Site.");

                Console.WriteLine() ;
                Console.ReadLine();
                                                     
            }
            //var shapetoupdate = dbContext.shapes.First(s=>s.shapeID == shapeidtoupdate);
            // Console.Clear() ;
            //Console.WriteLine("skriv in nya type: ");
            //var typeupdate = Console.ReadLine() ;
            //Console.WriteLine("mata in den nya värde för area: ");
            //var areaupdate = Convert.ToDouble( Console.ReadLine());
            //Console.WriteLine("skriv in den nya perimeter: ");
            //var perimeterupdate = Convert.ToDouble(Console.ReadLine());

            // shapetoupdate.type = typeupdate;
            //shapetoupdate.Area = areaupdate;
            //shapetoupdate.Perimeter = perimeterupdate;
            //dbContext.SaveChanges();
            //Console.WriteLine("press any key to continou");
            //Console.ReadLine();

        }

    }
}
