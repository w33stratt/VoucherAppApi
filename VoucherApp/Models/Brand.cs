namespace VoucherApp.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<Voucher> Vouchers { get; set; }
    }
}
