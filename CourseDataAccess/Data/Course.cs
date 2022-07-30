using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDataAccess.Data
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage ="Price Must be have fill")]
        public decimal CoursePrice { get; set; }

        [Required(ErrorMessage = "Must be selected Is-Active")]
        public bool IsActive { get; set; }

        public string Description { get; set; }

        [Required]
        public string Title { get; set; }

        public string SubTitle { get; set; }

        public double RegularRate { get; set; }

        public string Detaisl { get; set; }
        public string CreateBy { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public string UpdateBy { get; set; }

        public DateTime UpdateDate { get; set; }

        public string ImageUrl { get; set; }






    }
}
