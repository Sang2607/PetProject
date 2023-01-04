

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetProject.Model.Model
{
    [Table("Metadate")]
    public class Metadata
    {
        [Key]
        public int Id { get; set; }
        public string? GroundText { get; set; }
        public int Item_Id { get; set; }
        public int Item_Text { get; set; }

    }
}
