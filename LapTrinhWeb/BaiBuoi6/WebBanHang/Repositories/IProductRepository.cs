using WebBanHang.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebBanHang.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
        Task<Dictionary<int, int>> GetProductCountGroupedByCategoryAsync();
    }
}