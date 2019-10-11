﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Uni_Management_System.DAL
{
    public class Progress
    {
        public int ID { get; set; }

        public decimal GPA { get; set; }

        [Display(Name = "Credits Completed")]
        public int creditsCompleted { get; set; }

        [Display(Name = "Credits Remaining")]
        public int creditsRemaining { get; set; }
    }
}