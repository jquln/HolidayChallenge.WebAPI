﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayChallenge.Data
{
    public class Ornament
    {
        [Key]
        public int Id {  get; set; }

        [Required]
        public string Description { get; set; }
        

        public int TreeId { get; set; }
        public virtual Tree Tree { get; set; }
    }
}
