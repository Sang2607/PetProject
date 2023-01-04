using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetProject.Model.Model
{
    [Table("TeacherOfClass")]
    public class TeacherOfClass
    {
        [Key]
        public int Id_Htecher { get; set; }
        public int IdTeacher { get; set; }
        public int IdClass { get; set; }

    }
}
