using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Cargo : BaseEntity
    {
        public string Descripcion { get; set; }
        public string SueldoBase { get; set; }
        public ICollection<Empleado> empleados {get; set;}
        
    }
}