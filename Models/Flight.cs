using System;
using System.Collections.Generic;

namespace SecondAssingnment.Models
{
    public partial class Flight
    {
        public int Id { get; set; }
        public int? AirlineId { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public DateTime? DepartialDateTime { get; set; }
        public DateTime? ArrivalDateTime { get; set; }
    }
}
