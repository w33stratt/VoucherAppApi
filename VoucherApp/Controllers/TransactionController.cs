using Microsoft.AspNetCore.Mvc;
using VoucherApp.DTOS;
using VoucherApp.Interfaces;

namespace VoucherApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        [HttpPost("redemption")]
        public async Task<ActionResult> MakeRedemption([FromBody] RedemptionDto redemptionDto)
        {
            var result = await _transactionService.MakeRedemptionAsync(redemptionDto);
            return Ok(result);
        }

        [HttpGet("redemption")]
        public async Task<ActionResult<TransactionDetailDto>> GetRedemptionDetail(int transactionId)
        {
            var details = await _transactionService.GetRedemptionDetailAsync(transactionId);
            return Ok(details);
        }
    }

}
