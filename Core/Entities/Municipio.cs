using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Municipio
    {
        public string Nombre { get; set; }
        public int IdDep { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<Empleado> Empleados;
        public ICollection<Empresa> Empresas;
        public ICollection<Cliente> Clientes;

    }
