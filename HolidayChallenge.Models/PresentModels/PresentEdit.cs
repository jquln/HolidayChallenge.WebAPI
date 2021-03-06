using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayChallenge.Models.PresentModels
{
    public class PresentEdit
    {
        [Required]
        public int Id { get; set; }

        public enum PresentType { BigBox, SmallBox, BigBag, SmallBag, Stocking, Unwrapped }

        [Required]
        public string Wrapping { get; set; }

        [Required]
        public string Contains { get; set; }

        [Required]
        public List<string> Hints { get; set; }

        [Required]
        public int TimeShaken { get; set; }

        [Required]
        public bool IsWrapped { get; set; }

        [Required]
        public int TreeId { get; set; }

    }
}
    

