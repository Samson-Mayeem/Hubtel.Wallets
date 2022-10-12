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
        [Route("api/v1/wallets/addwallet")]
        public Wallet DeleteWallet(int WalletId)
        {
            var save = walletService.DeleteWallet(WalletId);
            return save;
        }
        //[HttpPost]
        //[Route("api/v1/wallets")]
        /*public async Task<IActionResult> SaveToWallets(AddWallet addwallets)
        {
            var wallets = new Wallet()
            {
                UserId = addwallets.UserId,
                Name = addwallets.Name,
                Type = addwallets.Type,
                AccountNumber = addwallets.AccountNumber,
                AccountScheme = addwallets.AccountScheme,
                DateCreatedAt = addwallets.DateCreatedAt,
                AccountOwnerNumber = addwallets.AccountOwnerNumber
            };
            await HubtelDbContext.
            await HubtelDbContext.SaveChangesAsync();


        }*/
    }
}
