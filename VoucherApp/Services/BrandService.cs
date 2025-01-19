using VoucherApp.Data;
using VoucherApp.DTOS;
using VoucherApp.Interfaces;
using VoucherApp.Models;

namespace VoucherApp.Services
{
    public class BrandService : IBrandService
    {
        private readonly VoucherAppDbContext _context;

        public BrandService(VoucherAppDbContext context)
        {
            _context = context;
        }

        public async Task<Brand> CreateBrandAsync(BrandDto brandDto)
        {
            var brand = new Brand
            {
                Name = brandDto.Name,
                CreatedAt = DateTime.UtcNow
            };

            _context.Brands.Add(brand);
            await _context.SaveChangesAsync();
            return brand;
        }
    }

}
