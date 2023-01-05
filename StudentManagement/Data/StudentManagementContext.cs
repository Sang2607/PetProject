using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetProject.Model.Model;

namespace StudentManagement.Data
{
    public class StudentManagementContext : DbContext
    {
        public StudentManagementContext (DbContextOptions<StudentManagementContext> options)
            : base(options)
        {
        }

        public DbSet<ListTeacher> ListTeacher { get; set; }
    }
}
