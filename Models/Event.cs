using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GreetUp.Models
{
    public class Event
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }
        public int RSVP { get; set; }
    }
}