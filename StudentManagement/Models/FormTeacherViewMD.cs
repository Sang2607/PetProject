
using System.ComponentModel;

namespace StudentManagement.Models
{
    public class FormTeacherViewMD
    {
        [DisplayName("Tên giáo viên")]
        public string NameTeacher { get; set; }
        [DisplayName("Số điện thoại")]
        public string PhoneNumber { get; set; }
        [DisplayName("Môn học")]
        public Boolean Status { get; set; }

    }
}
