using System.ComponentModel.DataAnnotations;

namespace projekttest.Data
{
    public class Shape
    {
        [Key]
        public int shapeID { get; set; }
        [Required]
        public string type { get; set; }
        [Required]
        public double Area { get; set; }
        [Required]
        public double Perimeter { get; set; }
        public DateTime Date { get; set; }
    }
}