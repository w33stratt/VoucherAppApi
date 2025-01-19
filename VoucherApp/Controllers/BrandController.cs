using Microsoft.AspNetCore.Mvc;
using VoucherApp.DTOS;
using VoucherApp.Interfaces;

namespace VoucherApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        [HttpPost]
        public async Task<ActionResult> CreateBrand([FromBody] BrandDto brandDto)
        {
            var result = await _brandService.CreateBrandAsync(brandDto);
            return Ok(result);
        }
    }

}
