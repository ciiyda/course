using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseDataAccess.Data
{
    public class CourseContext:IdentityDbContext
    {
        public CourseContext(DbContextOptions<CourseContext>option):base(option)
        {

        }

        public DbSet<Course>Courses { get; set; }
    }
}
