using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetProject.Model.Model
{
    [Table("ListStudent")]
    public class ListStudent
    {
        [Key]
        public int IdStudent { get; set; }
        public string? NameStudent { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int IdClass { get; set; }
        public int IdRank { get; set; }
        public int IdParent { get; set; }


    }
}
