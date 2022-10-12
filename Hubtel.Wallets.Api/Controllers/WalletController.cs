using Hubtel.Wallets.Api.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Hubtel.Wallets.Api.Models.Domain;
using Hubtel.Wallets.Api.Models;
using System.Collections.Generic;
using Hubtel.Wallets.Api.IServices;

namespace Hubtel.Wallets.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WalletController : Controller
    {
        private readonly IWalletService walletService;

        public WalletController(IWalletService wallet)
        {
            walletService = wallet;
        }

        [HttpGet]
        [Route("action")]
        [Route("api/v1/wallets/fetchwallets")]
        public IEnumerable<Wallet> GetAllWallets()
        {
            return walletService.GetAllWallets();
        }

        [HttpPost]
        [Route("action")]
        [Route("api/v1/wallets/addwallet")]
        public Wallet AddWallets(Wallet wallet)
        {
            var save =  walletService.AddWallets(wallet);
            return save;
        }
        [HttpPut]
        [Route("action")]
        [Route("api/v1/wallets/updatewallet")]
        public Wallet UpdateWallet(Wallet wallet)
        {
            var save = walletService.UpdateWallet(wallet);
            return save;
        }
        [HttpDelete]
        [Route("action")]
        [Route("api/v1/wallets/deletewallet")]
        public Wallet DeleteWallet(int walletid)
        {
            var del = walletService.DeleteWallet(walletid);
            return del;
        }
    }
}
