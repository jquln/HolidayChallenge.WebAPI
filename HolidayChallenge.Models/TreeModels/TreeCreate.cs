using HolidayChallenge.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayChallenge.Models.TreeModels
{
    public class TreeCreate
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public virtual List<Present> Presents { get; set; }

        [Required]
        public virtual List<Ornament> Ornaments { get; set; }
    }
}
