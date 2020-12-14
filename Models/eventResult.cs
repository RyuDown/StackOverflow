using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class eventResult
    {
        [Key, Column(Order = 0)]
        public int resultID { get; set; }
        [Key, Column(Order = 1)]
        public int eventID { get; set; }
        [Key, Column(Order = 2)]
        [Required(ErrorMessage = "Swimmer ID is required to proceed")]
        public int swimmerID { get; set; }
        [Required(ErrorMessage = "Swimmer name is required to proceed")]
        public String swimmerName { get; set; }
        [Required(ErrorMessage = "Round is required to proceed")]
        public int round { get; set; }
        [Required(ErrorMessage = "Lane number is required to proceed")]
        public int laneNumber { get; set; }
        [Required(ErrorMessage = "Have they finished field is required to proceed")]
        public Boolean haveTheyFinished { get; set; }
        [Range(0, 59)]
        [Required(ErrorMessage = "Minutes is required to proceed")]
        public int minutes { get; set; }
        [Range(0, 59)]
        [Required(ErrorMessage = "Seconds is required to proceed")]
        public int seconds { get; set; }
        [Range(0, 999)]
        [Required(ErrorMessage = "Miliseconds is required to proceed")]
        public int miliseconds { get; set; }
        public String reason { get; set; }
    }
}