using Microsoft.AspNetCore.Mvc;
using VoucherApp.DTOS;
using VoucherApp.Interfaces;
using VoucherApp.Models;

namespace VoucherApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly IVoucherService _voucherService;

        public VoucherController(IVoucherService voucherService)
        {
            _voucherService = voucherService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateVoucher([FromBody] VoucherDto voucherDto)
        {
            var result = await _voucherService.CreateVoucherAsync(voucherDto);
            return Ok(result);
        }

        [HttpGet("{voucherId}")]
        public async Task<ActionResult<Voucher>> GetVoucher(int voucherId)
        {
            var voucher = await _voucherService.GetVoucherAsync(voucherId);
            if (voucher == null) return NotFound();
            return Ok(voucher);
        }

        [HttpGet("brand")]
        public async Task<ActionResult<IEnumerable<Voucher>>> GetVouchersByBrand(int brandId)
        {
            var vouchers = await _voucherService.GetVouchersByBrandAsync(brandId);
            return Ok(vouchers);
        }
    }

}
