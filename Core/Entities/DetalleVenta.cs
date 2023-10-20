using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class DetalleVenta : BaseEntity
    {
        public int IdVenta {get; set;}
        public Venta Venta { get; set; }
        public int IdProducto { get; set; }
        public Inventario Inventario { get; set; }
        public int IdTalla { get; set; }
        public Talla talla { get; set; }
        public string Cantidad { get; set; }
        public int ValorUnit { get; set; }
        
        
        

    }
}