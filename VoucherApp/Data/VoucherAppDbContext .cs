using Microsoft.EntityFrameworkCore;
using VoucherApp.Models;

namespace VoucherApp.Data
{
    public class VoucherAppDbContext : DbContext
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionVoucher> TransactionVouchers { get; set; }

        public VoucherAppDbContext(DbContextOptions<VoucherAppDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Voucher>()
                .HasOne(v => v.Brand)
                .WithMany(b => b.Vouchers)
                .HasForeignKey(v => v.BrandId);

            modelBuilder.Entity<TransactionVoucher>()
                .HasOne(tv => tv.Transaction)
                .WithMany(t => t.TransactionVouchers)
                .HasForeignKey(tv => tv.TransactionId);

            modelBuilder.Entity<TransactionVoucher>()
                .HasOne(tv => tv.Voucher)
                .WithMany(v => v.TransactionVouchers)
                .HasForeignKey(tv => tv.VoucherId);
        }
    }

}
