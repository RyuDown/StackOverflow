using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class Meeting
    {
        [Key, Column(Order = 0)]
        public int meetingID { get; set; }
        [Required(ErrorMessage = "Event name is required to proceed")]
        public String name { get; set; }
        [Required(ErrorMessage = "Event venue is required to proceed")]
        public String venue { get; set; }
        [Required(ErrorMessage = "Event date is required to proceed")]
        public DateTime date { get; set; }
        [Required(ErrorMessage = "Pool length required to proceed")]
        public Double poolLength { get; set; }
        [NotMapped]
        public List<Event> meetingEvents { get; set; }
    }
}