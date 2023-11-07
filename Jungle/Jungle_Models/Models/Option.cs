using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle_Models.Models
{
    public class Option
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Prix { get; set; }

        [ForeignKey("Travel")]
        public int TravelId { get; set; }

        public Travel Travel { get; set; }





    }
}
