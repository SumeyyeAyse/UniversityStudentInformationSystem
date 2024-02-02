using API.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Entities.Concrete
{
    public class Course:BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(10)]
        public string Code { get; set; }
        [MaxLength(1000)]
        public string Content { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual List<Instructor> Instructors { get; set; }
    }
}
