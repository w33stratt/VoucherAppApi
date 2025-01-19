using System.Text.Json.Serialization;

namespace VoucherApp.Models
{
    public class Voucher
    {
        public int VoucherId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public decimal CostInPoints { get; set; }
        public DateTime CreatedAt { get; set; }

        public Brand Brand { get; set; }
        [JsonIgnore]
        public ICollection<TransactionVoucher> TransactionVouchers { get; set; }
    }
}
