using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Cliente : BaseEntity
    {
        public int IdCliente { get; set; }
        public Cliente cliente { get; set; }
        public string Nombre { get; set; }
        public int IdTipoPersona { get; set; }
        public TipoPersona TipoPersona { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdMunicipio { get; set; }
        public Municipo Municipio { get; set; }
        
        
        
        
        
        
        
    }
}