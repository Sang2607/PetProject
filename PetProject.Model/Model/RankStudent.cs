using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Model.Model
{
    [Table("RankStudent")]
    public class RankStudent
    {
        [Key]
        public int IdRank { get; set; }
        public string? Conduct { get; set; }
        public string? Type { get; set; }
    }
}
