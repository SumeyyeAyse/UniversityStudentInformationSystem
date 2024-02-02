using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Entities.SqlViews
{
    [NotMapped]
    public class V_DepartmantTable
    {
        [Key]
        public int Id { get; set; }
        public bool IsActive { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public int FacultyId { get; set; }//FK
        [MaxLength(50)]
        public string FacultyName { get; set; }
    }
}
