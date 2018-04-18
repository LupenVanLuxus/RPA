using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VajaMVC.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Display(Name="Ime")]
        [Required(ErrorMessage ="Ime je obvezen podatek")]
        public string StudentName { get; set; }
        [Display(Name = "Starost")]
        [Required(ErrorMessage = "Starost je obvezen podatek")]
        [Range(18,50,ErrorMessage ="Napačna starost")]
        public int Age { get; set; }
    }
}