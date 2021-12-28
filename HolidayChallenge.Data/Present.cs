using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayChallenge.Data
{
    public class Present
    {
        [Key]
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


        [ForeignKey(nameof(Tree))]
        public int TreeId { get; set; }
        public virtual Tree Tree { get; set; }

    }
}
