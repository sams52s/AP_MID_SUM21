using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabTask1.Models
{
    public class StudentModel
    {
        [Required(ErrorMessage = "Please put your name")]
        public string Name { get; set; }
        [MaxLength(10, ErrorMessage = "Max Length 10")]
        public string ID { get; set; }
        public string DoB { get; set; }
        public float CGPA { get; set; }
        [Required]
        public int Credit { get; set; }
    }
    public class AdminModel
    {
        [Required(ErrorMessage = "Please put your name")]
        public string Name { get; set; }
        [MaxLength(10, ErrorMessage = "Max Length 10")]
        public string ID { get; set; }
        [Required(ErrorMessage = "Please put your Password")]
        public string Password { get; set; }
    }

}