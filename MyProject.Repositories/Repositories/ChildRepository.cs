using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Repositories.Repositories
{
    public class ChildRepository : IChildRepository
    {

        private readonly IContext _context;
        public ChildRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Child> AddAsync(Child child)
        {
            var newChild = _context.Children.Add(child);
            await _context.SaveChangesAsync();
            return newChild.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            _context.Children.Remove(await GetByIdAsync(id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.Include(c => c.Father).Include(c => c.Mother).ToListAsync();
        }

        public async Task<Child> GetByIdAsync(int id)
        {
            return await _context.Children.Include(p => p.Father).Include(p => p.Mother).
                FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<Child> GetByIdNumberAsync(string idNumber)
        {
            return await _context.Children.Include(p => p.Father).Include(p => p.Mother).
                FirstOrDefaultAsync(p => p.IdNumber == idNumber);
        }

        public async Task<Child> UpdateAsync(Child child)
        {
            var update = _context.Children.Update(child);
            await _context.SaveChangesAsync();
            return update.Entity;
        }

    }
}
