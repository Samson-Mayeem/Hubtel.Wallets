using Hubtel.Wallets.Api.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Hubtel.Wallets.Api.Models.Domain;
using Hubtel.Wallets.Api.Models;
using System.Collections.Generic;
using Hubtel.Wallets.Api.Repository;

namespace Hubtel.Wallets.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : Controller
    {
        private readonly IWalletRepository _walletRepository;

        public WalletController(IWalletRepository walletRepository)
        {
            this._walletRepository = walletRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Wallet>> GetAllWallets()
        {
            return await _walletRepository.Get();
        }

        [HttpGet("{walletid}")]
        public async Task<ActionResult<Wallet>> Get(long walletid)
        {
            return await _walletRepository.Get(walletid);
        }
        [HttpPost]
        public async Task<ActionResult<Wallet>> Get([FromBody] Wallet wallet)
        {
            var newWallet = await _walletRepository.AddWallets(wallet);
            return CreatedAtAction(nameof(GetAllWallets), new { id = newWallet.WalletId }, newWallet);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Wallet>> UpdateWallet(long walletid, [FromBody] Wallet wallet)
        {
            if (walletid != wallet.WalletId)
            {
                return BadRequest();
            }
            await _walletRepository.UpdateWallet(wallet);
            return NoContent();
        }
    }
}
