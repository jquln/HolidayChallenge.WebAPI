using HolidayChallenge.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayChallenge.Models.OrnamentModels
{
    public class OrnamentDetail
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public int TreeId { get; set; }
        public virtual Tree Tree { get; set; }
    }
}
