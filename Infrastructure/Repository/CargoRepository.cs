using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class CargoRepository : GenericRepository<Cargo>, ICargoRepository
    {
        private readonly YaelRopaContext _context;
        public CargoRepository(YaelRopaContext context) :base(context)
        {
            _context = context;
        }
    }
}