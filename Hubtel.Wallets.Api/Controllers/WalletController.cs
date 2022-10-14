using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Hubtel.Wallets.Api;
using Hubtel.Wallets.Api.Controllers;
using Hubtel.Wallets.Api.Repository;
using Hubtel.Wallets.Api.Models.Domain;

namespace Hubtel.Wallets.Api.Controllers
{ 
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class WalletController : Controller
    {
        private readonly IWalletRepository _walletRepository;
        public WalletController(IWalletRepository walletRepository)
        {
            this._walletRepository = walletRepository;
        }

        [HttpGet]
        [Route("action")]
        [Route("api/wallets/get")]
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
        [HttpPut("{walletid}")]
        public async Task<ActionResult<Wallet>> UpdateWallet(long walletid, [FromBody] Wallet wallet)
        {
            if (walletid != wallet.WalletId)
            {
                return BadRequest();
            }
            await _walletRepository.UpdateWallet(wallet);
            return NoContent();
        }
        [HttpDelete]
        public async Task<ActionResult<Wallet>> DeleteWallet(long walletid)
        {
            var deleteWallet = await _walletRepository.Get(walletid);
            if (deleteWallet != null)
            {
                return BadRequest();
            }
            await _walletRepository.DeleteWallet(deleteWallet.WalletId);
            return NoContent();
        }
    }
}
