using API.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Entities.Concrete
{
    public class Departmant:BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }
        public int FacultyId { get; set; }//FK
        public virtual Faculty Faculty { get; set; }
        public virtual List<Student> Students { get; set; }
    }
}
