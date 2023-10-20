using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

    public class YaelRopaContext : DbContext
    {
        public YaelRopaContext(DbContextOptions options) : base(options) { }

        public DbSet<Cargo> cargos { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Color> colores { get; set; }
        public DbSet<Departamento> departamentos { get; set; }
        public DbSet<DetalleOrden> detalleOrdenes { get; set; }
        public DbSet<DetalleVenta> detalleVentas { get; set; }
        public DbSet<Empleado> empleados { get; set; }
        public DbSet<Empresa> empresas { get; set; }
        public DbSet<Estado> estados { get; set; }
        public DbSet<FormaPago> formaPagos { get; set; }
        public DbSet<Genero> generos { get; set; }
        public DbSet<Insumo> insumos { get; set; }
        public DbSet<InsumoPrenda> insumoPrendas { get; set; }
        public DbSet<InsumoProveedor> insumoProveedores { get; set; }
        public DbSet<Inventario> inventarios { get; set; }
        public DbSet<InventarioTalla> inventarioTallas { get; set; }
        public DbSet<Municipo> municipos { get; set; }
        public DbSet<Orden> ordenes { get; set; }
        public DbSet<Pais> pais { get; set; }
        public DbSet<Prenda> prendas { get; set; }
        public DbSet<Proveedor> proveedores { get; set; }
        public DbSet<Talla> tallas { get; set; }
        public DbSet<TipoEstado> tipoEstados { get; set; }
        public DbSet<TipoPersona> tipoPersonas { get; set; }
        public DbSet<TipoProteccion> tipoProtecciones { get; set; }
        public DbSet<Venta> ventas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

