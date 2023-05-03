
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace PetProject.Model.Model
{
    [Table("ListTeacher")]
    public class ListTeacher
    {
        [Key]
        public int IdTeacher { get; set; }
        public string? NameTeacher { get; set; }
        public string? PhoneNumber { get; set; }
        public int? IdSubject { get; set; }
        public bool? Status { get; set; } = true;

    }
}
