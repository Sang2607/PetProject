using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetProject.Model.Model
{
    [Table("SubjectScore")]
    public class SubjectScore
    {
        [Key]
        public int IdSubjectScore { get; set; }
        public int IdStudent { get; set; }
        public int? Biology { get; set; }
        public int? Chemistry { get; set; }
        public int? Maths { get; set; }
        public int? Physics { get; set; }
        public int? Literature { get; set; }
        public int? Geography { get; set; }
        public int? History { get; set; }
        public int? PhysicalEducation { get; set; }
        public int? English { get; set; }
    }
}
