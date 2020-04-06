using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebbLab3.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        [Display(Name = "Seats")]
        public int NumberOfSeats { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd MMM HH:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Time")]
        public DateTime MovieStartTime { get; set; }
    }
}
