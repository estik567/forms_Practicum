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
    public class UserRepositories : IDataRepository<User>
    {
        private readonly IContext _context;

        public UserRepositories(IContext context)
        {
            _context = context;
        }

        public async Task<User> AddAsync(User entity)
        {
            EntityEntry<User> newUser = await _context.users.AddAsync(entity);
            await _context.SaveChangesAsync();
            return newUser.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.users.Remove(_context.users.FirstOrDefault(p => p.UserId == id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            var u = await _context.users.FindAsync(id);
            return u;
        }

        public async Task<User> UpdateAsync(int id, User entity)
        {
            entity.UserId = id;
            var saveUser = _context.users.Update(entity);
            await _context.SaveChangesAsync();
            return saveUser.Entity;
        }
    }
}
