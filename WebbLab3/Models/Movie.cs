using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbLab3.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int NumberOfSeats { get; set; }
        public DateTime MovieStartTime { get; set; }
    }
}
