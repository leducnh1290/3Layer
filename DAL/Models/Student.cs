namespace DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        public int StudentID { get; set; }

        [Required]
        [StringLength(255)]
        public string FullName { get; set; }

        public int? MajorID { get; set; }

        public double AverageScore { get; set; }

        public virtual Major Major { get; set; }
    }
}
