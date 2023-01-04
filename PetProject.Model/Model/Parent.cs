

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetProject.Model.Model
{
    [Table("Parent")]
    public class Parent
    {
        [Key]
        public int IdParent { get; set; }
        public string? Name { get; set; } 
        public DateTime? DateOfBirth { get; set; }
        public int? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public int IdStudent { get; set; }

    }
}
