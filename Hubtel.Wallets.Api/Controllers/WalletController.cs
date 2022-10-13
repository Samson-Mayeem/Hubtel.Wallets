using Hubtel.Wallets.Api.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Hubtel.Wallets.Api.Models.Domain;
using Hubtel.Wallets.Api.Models;
using System.Collections.Generic;
using Hubtel.Wallets.Api.Repositories;
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
            return await _walletRepository.GetAllWallets();
        }

        [HttpGet("{id}")]
        public Task<ActionResult<Wallet>> GetWalletById(long walletid)
        {
            return _walletRepository.GetWalletById(walletid);

        }
        [HttpPut]
        [Route("action")]
        [Route("api/wallets/updatewallet")]
        public Wallet UpdateWallet(Wallet wallet)
        {
            var save = walletService.UpdateWallet(wallet);
            return save;
        }
        [HttpDelete]
        [Route("action")]
        [Route("api/wallets/deletewallet")]
        public Wallet DeleteWallet(int walletid)
        {
            var del = walletService.DeleteWallet(walletid);
            return del;
        }
    }
}
