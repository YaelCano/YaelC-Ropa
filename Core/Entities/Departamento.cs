using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

public class Departamento
{
    public string Nombre { get; set; }
    public int IdPais { get; set; }

    public Pais Pais { get; set; }


}
