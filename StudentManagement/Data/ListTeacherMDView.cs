﻿namespace StudentManagement.Data
{
    public class ListTeacherMDView
    {
        public int IdTeacher { get; set; }
        public string NameTeacher { get; set; }
        public string PhoneNumber { get; set; }
        public int IdSubject { get; set; }
        public bool Status { get; set; } = false;
    }
}