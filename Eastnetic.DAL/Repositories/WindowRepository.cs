using Eastnetic.DAL.Domain;
using Eastnetic.DAL.Domain.Entities;
using Eastnetic.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Eastnetic.DAL.Repositories
{
    public class WindowRepository : IWindowRepository
    {
        private readonly EastneticDbContext _context;

        public WindowRepository(EastneticDbContext context)
        {
            _context = context;
        }

        public async Task<List<Window>> GetWindows()
        {
            var result = await _context.Windows.Include(e=>e.Order).Include(e=>e.SubElements).ToListAsync();
            return result;
        }
        public async Task<Window> SaveWindow(Window window)
        {
            var result = await _context.Windows.AddAsync(window);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Window> DeleteById(long id)
        {
            var result = await _context.Windows.Where(e => e.Id == id).FirstOrDefaultAsync();
            _context.Windows.Remove(result);
            await _context.SaveChangesAsync();
            return result;
        }
    } 
}
