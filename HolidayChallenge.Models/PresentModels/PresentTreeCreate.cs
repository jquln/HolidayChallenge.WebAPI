using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayChallenge.Models.PresentModels
{
    public class PresentTreeCreate
    {
        [Required]
        public int TreeId { get; set; }

        [Required]
        public string Wrapping { get; set; }

        [Required]
        public string Contains { get; set; }

        [Required]
        public List<string> Hints { get; set; }

        
        public int TimeShaken { get; set; }

        
        public bool IsWrapped { get; set; }

    }
}
