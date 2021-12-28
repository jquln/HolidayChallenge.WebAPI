using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayChallenge.Models.PresentModels
{
    public class PresentDetail
    {
        public int Id { get; set; }

        public enum PresentType { BigBox, SmallBox, BigBag, SmallBag, Stocking, Unwrapped }

        public string Wrapping { get; set; }

        public string Contains { get; set; }

        public List<string> Hints { get; set; }

        public int TimesShaken { get; set; }

        public bool IsWrapped { get; set; }

        public int TreeId { get; set; }

        public string Tree { get; set; }
    }
}
