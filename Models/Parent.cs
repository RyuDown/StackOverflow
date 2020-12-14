using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment.Models
{
    public class Parent
    {
        [Key, Column(Order = 0)]
        public int parentID { get; set; }
        [Required(ErrorMessage = "Name is required to proceed")]
        public String name { get; set; }
        [Required(ErrorMessage = "Gender is required to proceed")]
        public Boolean areTheyMale { get; set; }
        [Required(ErrorMessage = "Address is required to proceed")]
        public String address { get; set; }
        [Required(ErrorMessage = "Contact number is required to proceed")]
        public String contactNumber { get; set; }
        [Required(ErrorMessage = "Email is required to proceed")]
        public String emailAddress { get; set; }
        [Required(ErrorMessage = "Date of birth is required to proceed")]
        public DateTime DoB { get; set; }
        [NotMapped]
        public List<Swimmer> children { get; set; }
    }
}