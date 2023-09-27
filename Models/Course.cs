using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagement.MVC.Models
{
    [Index(nameof(Code), Name = "UQ__Courses__A25C5AA7E741EDD3", IsUnique = true)]
    public partial class Course
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(5)]
        public string Code { get; set; }
        public int? Credits { get; set; }
    }
}
