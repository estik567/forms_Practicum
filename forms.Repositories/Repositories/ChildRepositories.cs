using forms.Repositories.Interfaces;
using forms.Repositories.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms.Repositories.Repositories
{
    internal class ChildRepositories : IDataRepository<Child>
    {
        private readonly IContext _context;

        public ChildRepositories(IContext context)
        {
            _context = context;
        }

        public async Task<Child> AddAsync(Child entity)
        {
            EntityEntry<Child> newChild = await _context.children.AddAsync(entity);
            await _context.SaveChangesAsync();
            return newChild.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.children.Remove(_context.children.FirstOrDefault(p => p.ChildId == id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.children.ToListAsync();
        }

        public async Task<Child> GetByIdAsync(int id)
        {
            var c = await _context.children.FindAsync(id);
            return c;
        }

        public async Task<Child> UpdateAsync(int id, Child entity)
        {
            entity.ChildId = id;
            var saveChild = _context.children.Update(entity);
            await _context.SaveChangesAsync();
            return saveChild.Entity;
        }
    }
}
