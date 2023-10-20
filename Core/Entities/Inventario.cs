using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Inventario : BaseEntity
    {
        public int Idprenda { get; set; }
        public Prenda Prendarenda { get; set; }
        public string ValorVtaCop { get; set; }
        public string ValorVtaUsd { get; set; }
        
        
        
    }
