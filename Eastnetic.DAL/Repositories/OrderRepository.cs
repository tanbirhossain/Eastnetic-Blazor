using Eastnetic.DAL.Domain;
using Eastnetic.DAL.Domain.Entities;
using Eastnetic.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eastnetic.DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly EastneticDbContext _context;

        public OrderRepository(EastneticDbContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetOrders()
        {
            var result = await _context.Orders.ToListAsync();
            return result;
        }
        public async Task<Order> SaveOrder(Order order)
        {
            var result = await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<Order> DeleteById(long id)
        {
            var result = await _context.Orders.Where(e => e.Id == id).FirstOrDefaultAsync();
            _context.Orders.Remove(result);
            await _context.SaveChangesAsync();
            return result;
        }
    }
}
