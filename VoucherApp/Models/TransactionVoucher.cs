namespace VoucherApp.Models
{
    public class TransactionVoucher
    {
        public int TransactionVoucherId { get; set; }
        public int TransactionId { get; set; }
        public int VoucherId { get; set; }
        public decimal PointsSpent { get; set; }

        public Transaction Transaction { get; set; }
        public Voucher Voucher { get; set; }
    }
}
