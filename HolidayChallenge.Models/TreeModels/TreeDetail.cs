using HolidayChallenge.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayChallenge.Models.TreeModels
{
    public class TreeDetail
    {
        [Required]
        public int Id { get; set; }

        public string Description { get; set; }

        public virtual List<Present> Presents { get; set; }

        public virtual List<Ornament> Ornaments { get; set; }
    }
}
