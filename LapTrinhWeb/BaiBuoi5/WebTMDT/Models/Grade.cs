﻿namespace WebTMDT.Models
{
    public class Grade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
        public List<Student> Students { get; set; }
    }
}
