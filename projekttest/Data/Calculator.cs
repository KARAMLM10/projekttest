using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Data
{
    public class Calculator
    {
        [Key]
        public int calculatorID { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public double Number1 { get; set; }
        [Required]
        public double Number2 { get; set; }
        [Required]
        public double result { get; set; }
        public DateTime Date { get; set; }
    }
}
