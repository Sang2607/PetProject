using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetProject.Model.Model
{
    [Table("ListClass")]
    public class ListClass
    {
        [Key]
        public int IdClass { get; set; }
        public int Class { get; set; }
        public string? NameClass { get; set; }
    }
}
