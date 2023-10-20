using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class InsumoPrenda : BaseEntity
{
    public int IdInsumo { get; set; }
    public Insumo Insummo { get; set; }
    public int Idprenda { get; set; }
    public Prenda prenda { get; set; }
    public string Cantidad { get; set; }

}
