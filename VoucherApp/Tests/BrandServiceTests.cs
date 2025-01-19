using Microsoft.EntityFrameworkCore;
using VoucherApp.Data;
using VoucherApp.DTOS;
using VoucherApp.Interfaces;
using VoucherApp.Services;
using Xunit;

namespace VoucherApp.Tests
{
    public class BrandServiceTests
    {
        private readonly IBrandService _brandService;
        private readonly VoucherAppDbContext _context;

        public BrandServiceTests()
        {
            var options = new DbContextOptionsBuilder<VoucherAppDbContext>()
                .UseInMemoryDatabase("VoucherAppTestDb")
                .Options;

            _context = new VoucherAppDbContext(options);
            _brandService = new BrandService(_context);
        }

        [Fact]
        public async Task CreateBrandAsync_ShouldCreateBrand()
        {
            var brandDto = new BrandDto { Name = "Indomaret" };

            var result = await _brandService.CreateBrandAsync(brandDto);

            Assert.NotNull(result);
            Assert.Equal("Indomaret", result.Name);
        }
    }

}
