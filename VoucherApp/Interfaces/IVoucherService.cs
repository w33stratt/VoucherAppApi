using VoucherApp.DTOS;
using VoucherApp.Models;

namespace VoucherApp.Interfaces
{
    public interface IVoucherService
    {
        Task<Voucher> CreateVoucherAsync(VoucherDto voucherDto);
        Task<Voucher> GetVoucherAsync(int voucherId);
        Task<IEnumerable<Voucher>> GetVouchersByBrandAsync(int brandId);
    }
}
