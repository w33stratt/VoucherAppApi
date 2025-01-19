using Microsoft.EntityFrameworkCore;
using VoucherApp.Data;
using VoucherApp.DTOS;
using VoucherApp.Interfaces;
using VoucherApp.Models;

namespace VoucherApp.Services
{
    public class VoucherService : IVoucherService
    {
        private readonly VoucherAppDbContext _context;

        public VoucherService(VoucherAppDbContext context)
        {
            _context = context;
        }

        public async Task<Voucher> CreateVoucherAsync(VoucherDto voucherDto)
        {
            var voucher = new Voucher
            {
                BrandId = voucherDto.BrandId,
                Name = voucherDto.Name,
                CostInPoints = voucherDto.CostInPoints,
                CreatedAt = DateTime.UtcNow
            };

            _context.Vouchers.Add(voucher);
            await _context.SaveChangesAsync();
            return voucher;
        }

        public async Task<Voucher> GetVoucherAsync(int voucherId)
        {
            return await _context.Vouchers.FindAsync(voucherId);
        }

        public async Task<IEnumerable<Voucher>> GetVouchersByBrandAsync(int brandId)
        {
            return await _context.Vouchers.Where(v => v.BrandId == brandId).ToListAsync();
        }
    }

}
