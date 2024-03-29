﻿using Microsoft.AspNetCore.Authentication;
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
        [Route("api/v1/wallet")]
        public async Task<IActionResult> GetAllWallets()
        {
            try
            {
                var wallets = await _walletRepository.GetAll();
                return Ok(wallets);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("api/v1/wallet")]
        public async Task<IActionResult> AddWallet([FromBody] Wallet wallet)
        {
            try
            {
                await _walletRepository.UpdateWallet
                    (wallet);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpGet("{id}")]
        [Route("api/v1/wallet")]

        public async Task<ActionResult<Wallet>> Get(long id)
        {
            return await _walletRepository.GetById(id);
        }
        
        
        [HttpPut("{id}")]
        [Route("api/v1/wallet")]
        public async Task<ActionResult<Wallet>> UpdateWallet(long id, [FromBody] Wallet wallet)
        {
            if (id != wallet.WalletId)
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
