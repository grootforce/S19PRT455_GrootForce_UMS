using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Uni_Management_System.DAL
{
    public class Student
    {
        public int ID { get; set; }

        [Display(Name = "Name")]
        public string name { get; set; }

        [Display(Name = "Student Number")]
        public string studentNo { get; set; }

        [Display(Name = "Email Address")]
        public string email { get; set; }

        [Display(Name = "Date of Birth")]
        public string dateOfBirth { get; set; }

        [Display(Name = "Course")]
        public string course { get; set; }

        [Display(Name = "Personality")]
        public string personality { get; set; }
    }

    public class Students
    {
        private int ID;
        private string name;
        private string studentNo;
        private string email;
        private string dateOfBirth;
        private string course;
        private string personality;
    }
}
