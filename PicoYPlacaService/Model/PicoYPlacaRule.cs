using System;
using System.Collections.Generic;
using System.Text;

namespace PicoYPlacaService.Model
{
    public class PicoYPlacaRule
    {
        public int Id { get; set; }
        public int Digit { get; set; }
        public string DayOfWeek { get; set; }
        public int Hour { get; set; }
        public int MinutesStart { get; set; }
        public int MinutesEnd { get; set; }
    }
}
