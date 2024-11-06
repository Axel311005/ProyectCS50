﻿using Microsoft.EntityFrameworkCore;
using ProyectCS50.Models;
using ProyectCS50.Repository.IRepository;

namespace ProyectCS50.Repository
{
    public class NominaRepository : Repository<Nomina>, INominaRepository
    {
        private readonly NominaContext _context;


        public NominaRepository(NominaContext context) : base(context)
        {
            _context = context;

        }

       
        public async Task<Nomina> UpdateAsync(Nomina entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
