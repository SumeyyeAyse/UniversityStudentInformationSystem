﻿using API.Models.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Entities.SqlViews
{
    [NotMapped]
    public class V_StudentTable
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Surname { get; set; }
        public int? Age { get; set; }
        public DateTime Birtday { get; set; }
        [MaxLength(150)]
        public string Email { get; set; }
        public ulong? PhoneNumber { get; set; }
        public DateTime YearOfEntry { get; set; }
        public string AcademicTranscript { get; set; }
        public string Gpa { get; set; }
        public enGender Gender { get; set; }
        public int DepartmantId { get; set; }//FK

        public int CourseId { get; set; }//FK
        [MaxLength(50)]
        public string City { get; set; }
        [MaxLength(100)]
        public string Street { get; set; }
        [MaxLength(50)]
        public string Country { get; set; }
        public int? HouseNumber { get; set; }
        public int? ApartmentNumber { get; set; }
        public int StudentId { get; set; }//FK
        [MaxLength(50)]
        public string DepartmantName { get; set; }
        [MaxLength(50)]
        public string CourseName { get; set; }
    }
}
