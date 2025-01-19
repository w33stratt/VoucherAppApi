using VoucherApp.Models;

namespace VoucherApp.Interfaces
{
    public interface ITransactionRepository
    {
        Task<Transaction> CreateTransactionAsync(Transaction transaction);
        Task<Transaction> GetTransactionByIdAsync(int transactionId);
    }
}
