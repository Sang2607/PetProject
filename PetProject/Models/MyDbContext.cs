using Microsoft.EntityFrameworkCore;
using PetProject.Model.Model;
using PetProject.Models;
namespace PetProject.Models
{
    public class MyDbContext :DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Subject>? subjects { get; set; }
        public DbSet<ListTeacher>? ListTeachers { get; set; }
        public DbSet<ListClass>? listClasses { get; set; }
        public DbSet<ListStudent>? listStudent { get; set; }
        public DbSet<HomeroomTeacher>? homeroomTeachers { get; set; }
        public DbSet<Metadata>? metadatas { get; set; }
        public DbSet<Parent>? Parents { get; set; }
        public DbSet<RankStudent> ?RankStudents { get; set; }
        public DbSet<Subject>? Subjects { get; set; }
        public DbSet<SubjectScore>? SubjectScores { get; set; }
        public DbSet<TeacherOfClass>? TeacherOfClasses { get; set; }

       
    }
}
