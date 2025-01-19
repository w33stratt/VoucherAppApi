namespace VoucherApp.DTOS
{
    public class RedemptionDto
    {
        public string CustomerId { get; set; }
        public decimal TotalPoints { get; set; }
        public List<VoucherRedemptionDto> Vouchers { get; set; }
    }

    public class VoucherRedemptionDto
    {
        public int VoucherId { get; set; }
        public decimal PointsSpent { get; set; }
    }
}
