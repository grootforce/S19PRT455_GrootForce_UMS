using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Uni_Management_System.DAL
{
    public class Course
    {
        public int ID { get; set; }

        [Display(Name = "Unit")]
        public string unit { get; set; }

        [Display(Name = "Unit Code")]
        public string unitCode { get; set; }

        [Display(Name = "Time")]
        public string time { get; set; }

        [Display(Name = "Location")]
        public string location { get; set; }

    }

    public class Courses
    {
        private int ID;
        private string unit;
        private string unitCode;
        private string time;
        private string location;
    }
}
