using Microsoft.EntityFrameworkCore;
using VoucherApp.Data;
using VoucherApp.DTOS;
using VoucherApp.Interfaces;
using VoucherApp.Models;

namespace VoucherApp.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly VoucherAppDbContext _context;

        public TransactionService(VoucherAppDbContext context)
        {
            _context = context;
        }

        public async Task<Transaction> MakeRedemptionAsync(RedemptionDto redemptionDto)
        {
            var transaction = new Transaction
            {
                CustomerId = redemptionDto.CustomerId,
                TotalPoints = redemptionDto.TotalPoints,
                CreatedAt = DateTime.UtcNow
            };

            _context.Transactions.Add(transaction);
            await _context.SaveChangesAsync();

            foreach (var voucherDto in redemptionDto.Vouchers)
            {
                var transactionVoucher = new TransactionVoucher
                {
                    TransactionId = transaction.TransactionId,
                    VoucherId = voucherDto.VoucherId,
                    PointsSpent = voucherDto.PointsSpent
                };

                _context.TransactionVouchers.Add(transactionVoucher);
            }

            await _context.SaveChangesAsync();
            return transaction;
        }

        public async Task<TransactionDetailDto> GetRedemptionDetailAsync(int transactionId)
        {
            var transaction = await _context.Transactions
                .Include(t => t.TransactionVouchers)
                .ThenInclude(tv => tv.Voucher)
                .FirstOrDefaultAsync(t => t.TransactionId == transactionId);

            if (transaction == null)
                return null;

            return new TransactionDetailDto
            {
                TransactionId = transaction.TransactionId,
                CustomerId = transaction.CustomerId,
                Vouchers = transaction.TransactionVouchers.Select(tv => new VoucherDetailDto
                {
                    VoucherId = tv.Voucher.VoucherId,
                    VoucherName = tv.Voucher.Name,
                    PointsSpent = tv.PointsSpent
                }).ToList()
            };
        }
    }

}
