using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Model.Model
{
    [Table("Subjects")]
    public class Subject
    {
        [Key]
        public int IdSubject { get; set; }
        public string? NameSubject { get; set; }
    }
}
