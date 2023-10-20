using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DetalleOrden : BaseEntity
    {
        public int IdOrden { get; set; }
        public Orden Orden { get; set; }
    
        public int IdPrenda { get; set; }
        public Prenda Prenda { get; set; }
        public int IdColor { get; set; }
        public Color Color { get; set; }
        public string CantidadProducida { get; set; }
        public int IdEstado{ get; set;}
        public Estado Estado{ get; set;}
    }
}