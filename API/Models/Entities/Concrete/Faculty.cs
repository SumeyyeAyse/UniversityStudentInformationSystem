using API.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Entities.Concrete
{
    public class Faculty:BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual List<Departmant> Departmants { get; set; }
    }
}
