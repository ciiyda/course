using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace course.Models
{
    public class CourseTraning
    {
        public int Id { get; set; }

        public string CourseName { get; set; }

        public double Price{ get; set; }


        public bool IsActive { get; set; }

    }
}
