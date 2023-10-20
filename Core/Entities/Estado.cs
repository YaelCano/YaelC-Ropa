using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Estado : BaseEntity
    {
        public string Descripcion { get; set; }
        public int IdTipoEstado { get; set; }
        public TipoEstado TipoEstado { get; set; }
        public ICollection<Prenda> prendas;
        public ICollection<DetalleOrden> detalleOrdens;
        public ICollection<Orden> ordens;
        
        
    }
}