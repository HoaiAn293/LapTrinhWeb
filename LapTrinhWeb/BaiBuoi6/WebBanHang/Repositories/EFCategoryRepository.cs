﻿using Microsoft.EntityFrameworkCore;
using WebBanHang.Models;

namespace WebBanHang.Repositories
{
    public class EFCategoryRepository(ApplicationDbContext context) : ICategoryRepository
    {
        private readonly ApplicationDbContext _context = context;

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _context.Categories
            .Include(p => p.Products)
            .ToListAsync();
        }
        public async Task<Category> GetByIdAsync(int id)
        {
            return await _context.Categories.Include(p =>
            p.Products).FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task AddAsync(Category category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Category category)
        {
            _context.Categories.Update(category);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var catecogy = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(catecogy);
            await _context.SaveChangesAsync();
        }


    }
}
