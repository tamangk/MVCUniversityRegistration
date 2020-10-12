using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCUniversityRegistration.Models;

namespace MVCUniversityRegistration.Data
{
    public class MVCUniversityRegistrationContext : DbContext
    {
        public MVCUniversityRegistrationContext (DbContextOptions<MVCUniversityRegistrationContext> options)
            : base(options)
        {
        }

        public DbSet<MVCUniversityRegistration.Models.Student> Student { get; set; }

        public DbSet<MVCUniversityRegistration.Models.Course> Course { get; set; }

        public DbSet<MVCUniversityRegistration.Models.CourseAssignment> CourseAssignment { get; set; }

        public DbSet<MVCUniversityRegistration.Models.Department> Department { get; set; }

        public DbSet<MVCUniversityRegistration.Models.Enrollment> Enrollment { get; set; }

        public DbSet<MVCUniversityRegistration.Models.Instructor> Instructor { get; set; }

        public DbSet<MVCUniversityRegistration.Models.OfficeAssignment> OfficeAssignment { get; set; }
    }
}
