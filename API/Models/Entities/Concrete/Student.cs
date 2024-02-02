using API.Models.Entities.Abstract;
using API.Models.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Entities.Concrete
{
    public class Student:BaseEntity
    {
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
        public virtual Departmant Departmant { get; set; }
        public virtual Course Course { get; set; }
        public virtual List<StudentAddress> StudentAddresses { get; set; }
    }
}
