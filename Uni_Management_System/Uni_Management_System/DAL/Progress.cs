using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Uni_Management_System.DAL
{
    public class Progress
    {
        public int ID { get; set; }

        public decimal GPA { get; set; }

        public int creditsCompleted { get; set; }

        public int creditsRemaining { get; set; }
    }
}
