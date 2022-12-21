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
using System;

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
        [Route("api/v1/wallet")]
        public async Task<IEnumerable<Wallet>> GetAllWallets()
        {
            return await _walletRepository.Get();
        }
        [HttpPost]
        public async Task<IActionResult> AddWallet([FromBody] Wallet wallet)
        {
            try
            {
                await _walletRepository.AddWallets(wallet);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{walletid}")]
        public async Task<ActionResult<Wallet>> Get(long walletid)
        {
            return await _walletRepository.Get(walletid);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            try
            {
                var employees = await _walletRepository.Get();
                return Ok(employees);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
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
       
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWallet(int id)
        {
            try
            {
                await _walletRepository.DeleteWallet(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
