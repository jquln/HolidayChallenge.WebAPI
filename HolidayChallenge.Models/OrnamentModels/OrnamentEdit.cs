using HolidayChallenge.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayChallenge.Models.OrnamentModels
{
    public class OrnamentEdit
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int TreeId { get; set; }
        public virtual Tree Tree { get; set; }
    }
}
