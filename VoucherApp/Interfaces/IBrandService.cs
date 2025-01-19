using VoucherApp.DTOS;
using VoucherApp.Models;

namespace VoucherApp.Interfaces
{
    public interface IBrandService
    {
        Task<Brand> CreateBrandAsync(BrandDto brandDto);
    }
}
