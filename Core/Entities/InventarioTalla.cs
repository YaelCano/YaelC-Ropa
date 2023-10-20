using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class InventarioTalla :  BaseEntity
    {
        public int IdInv { get; set; }
        public Inventario Inventario { get; set; }
        public string IdTalla { get; set; }
        public Talla Talla { get; set; }
        public string Cantidad {get; set;}
    }
}