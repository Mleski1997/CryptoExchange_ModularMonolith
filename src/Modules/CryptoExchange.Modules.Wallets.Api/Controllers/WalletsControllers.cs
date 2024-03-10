using CryptoExchange.Modules.Wallets.Core.DTO;
using CryptoExchange.Modules.Wallets.Core.Entities;
using CryptoExchange.Modules.Wallets.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoExchange.Modules.Wallets.Api.Controllers
{
    [Route("api/Wallet")]
    [ApiController]
    public class WalletsControllers : BaseController
    {
        private readonly IWalletService _walletService;

        public WalletsControllers(IWalletService walletService)
        {
            _walletService = walletService;
        }

        [HttpGet]
        public async Task<ActionResult<Wallet>> GetAllAsyncs() => Ok(await _walletService.GetWalletsAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult<Wallet>> GetAsyncs(Guid id) => OkOrNotFound(await _walletService.GetWalletAsync(id));

        [HttpPost]
        public async Task<ActionResult> AddAsync(WalletDto dto)
        {
            await _walletService.AddAsync(dto);
            return CreatedAtAction(nameof(GetAsyncs), new { id = dto.Id }, null);
        }

        [HttpPut("{id:guid}")]
        public async Task<ActionResult> UpdateAsync(Guid id, WalletUpdateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            dto.Id = id;
            await _walletService.UpdateAsync(dto);
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> DeleteAsync(Guid id)
        {
            await _walletService.DeleteAsync(id);
            return NoContent();
        }
    }
}
