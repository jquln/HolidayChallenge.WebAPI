using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayChallenge.Data
{
    public class Tree
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        
        public virtual List<Present> Presents { get; set; }

        public virtual List<Ornament> Ornaments { get; set; }
    }
}
