using System;
using System.Collections.Generic;

namespace SecondAssingnment.Models
{
    public partial class Airline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Status { get; set; }
        public string ShortCode { get; set; }
    }
}
