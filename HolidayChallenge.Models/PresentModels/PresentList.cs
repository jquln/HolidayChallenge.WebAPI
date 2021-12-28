using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayChallenge.Models.PresentModels
{
    public class PresentList
    {
        public int Id { get; set; }
        public string Wrapping { get; set; }
        public string Contains { get; set; }
        public List<string> Hints { get; set; }
        public int TimeShaken { get; set; }
        public bool IsWrapped { get; set; }
        public int TreeId { get; set; }
    }
}
