using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastructure.UnityOfWork;

public class UnityOfWork : IUnitOfWork, IDisposable
{
    private readonly YaelRopaContext _context;
    private CargoRepository _Cargos;
    private ClienteRepository _Clientes;
    private ColorRepository _Colores;
    private DepartamentoRepository _Departamentos;
    private DetalleOrdenRepository _DetalleOrdenes;
    private DetalleVentaRepository _DetalleVentas;
    private EmpleadoRepository _Empleados;
    private EmpresaRepository _empresas;
    private EstadoRepository _estados;
    private FormaPagoRepository _formaPagos;
    private GeneroRepository _Generos;
    private InsumoPrendaRepository _insumoPrendas;
    private InsumoProveedorRepository _insumoproveedores;
    private InsumoRepository _Insumos;
    private InventarioRepository _invemtarios;
    private InventarioTallaRepository _inventarioTallas;
    private MunicipioRepository  _municipios;
    private OrdenRepository _ordenes;
    private PaisRepository _paises;
    private PrendaRepository _prendas;
    private ProveedorRepository _proveedores;
    private TallaRepository _tallas;
    private TipoEstadoRepository _tiposEstados;
    private TipoPersonaRepository _tiposPersonas;
    private TipoProteccionRepository _tiposProtecciones;
    private VentaRepository _ventas;

    public ICargoRepository Auditorias
    {
        get
        {
            if (_Cargos == null)
            {
                _Cargos = new CargoRepository(_context);
            }
            return _Cargos;
        }
    }

    public UnityOfWork(YaelRopaContext context)
    {
        _context = context;
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
