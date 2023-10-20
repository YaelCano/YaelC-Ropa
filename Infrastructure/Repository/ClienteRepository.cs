using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;

namespace Infrastructure.Repository
{
    public class ClienteRepository: GenericRepository<Cliente>, IClienteRepository
    {
        private readonly YaelRopaContext _context;
        public ClienteRepository(YaelRopaContext context) :base(context)
        {
            _context = context;
        }
    }
}