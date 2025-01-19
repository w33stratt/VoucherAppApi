using VoucherApp.DTOS;
using VoucherApp.Models;

namespace VoucherApp.Interfaces
{
    public interface ITransactionService
    {
        Task<Transaction> MakeRedemptionAsync(RedemptionDto redemptionDto);
        Task<TransactionDetailDto> GetRedemptionDetailAsync(int transactionId);
    }

    public class TransactionDetailDto
    {
        public int TransactionId { get; set; }
        public string CustomerId { get; set; }
        public List<VoucherDetailDto> Vouchers { get; set; }
    }

    public class VoucherDetailDto
    {
        public int VoucherId { get; set; }
        public string VoucherName { get; set; }
        public decimal PointsSpent { get; set; }
    }
}
