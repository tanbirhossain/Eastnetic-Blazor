using Eastnetic.DAL.Domain;
using Eastnetic.DAL.Domain.Entities;
using Eastnetic.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Eastnetic.DAL.Repositories
{
    public class ElementRepository : IElementRepository
    {
        private readonly EastneticDbContext _context;

        public ElementRepository(EastneticDbContext context)
        {
            _context = context;
        }

        public async Task<List<SubElement>> GetElements()
        {
            var result = await _context.SubElements.Include(e=>e.Window).ToListAsync();
            return result;
        }
        public async Task<SubElement> SaveElement(SubElement order)
        {
            var result = await _context.SubElements.AddAsync(order);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<SubElement> DeleteById(long id)
        {
            var result = await _context.SubElements.Where(e => e.Id == id).FirstOrDefaultAsync();
            _context.SubElements.Remove(result);
            await _context.SaveChangesAsync();
            return result;
        }
    }
}
