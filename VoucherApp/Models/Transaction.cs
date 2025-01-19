using System.Text.Json.Serialization;

namespace VoucherApp.Models
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public string CustomerId { get; set; }
        public decimal TotalPoints { get; set; }
        public DateTime CreatedAt { get; set; }
        [JsonIgnore]
        public ICollection<TransactionVoucher> TransactionVouchers { get; set; }
    }
}
