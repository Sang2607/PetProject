using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetProject.Model.Model
{
    [Table("HomeroomTeacher")]
    public class HomeroomTeacher
    {
        [Key]
        public int Id_Htecher { get; set; }
        public string? NameTeacher { get; set; }
        public int Class { get; set; }
        public string? NameClass { get; set; }

    }
}
