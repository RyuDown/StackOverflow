using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class Event
    {
        [Key, Column(Order = 0)]
        public int eventID { get; set; }
        [Key, Column(Order = 1)]
        public int meetingID { get; set; }
        [Range(0, 100)]
        public int minAge { get; set; }
        [Range(0, 100)]
        public int maxAge { get; set; }
        [Required(ErrorMessage = "Event distance is required to proceed")]
        public Double distance { get; set; }
        public String stroke { get; set; }
        [NotMapped]
        public List<eventResult> eventResults { get; set; }
    }
}