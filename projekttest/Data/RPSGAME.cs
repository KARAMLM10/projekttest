using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekttest.Data
{
    public class RPSGAME
    {
        [Key]
        public int rpsID { get; set; }
        [Required]
        public string Scoure { get; set; }
        [Required]
        public DateTime Date { get; set; }

      


    }
}
