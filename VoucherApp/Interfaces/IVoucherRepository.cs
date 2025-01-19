using VoucherApp.Models;

namespace VoucherApp.Interfaces
{
    public interface IVoucherRepository
    {
        Task<Voucher> AddAsync(Voucher voucher);
        Task<Voucher> GetByIdAsync(int voucherId);
        Task<IEnumerable<Voucher>> GetAllByBrandAsync(int brandId);
    }
}
