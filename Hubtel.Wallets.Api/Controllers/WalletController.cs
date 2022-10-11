using Hubtel.Wallets.Api.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Hubtel.Wallets.Api.Models.Domain;
using Hubtel.Wallets.Api.Models;

namespace Hubtel.Wallets.Api.Controllers
{
    [ApiController]
    public class WalletController : Controller
    {
        private HubtelDbContext hubtelDbContext;

        public WalletController(HubtelDbContext hubtelDbContext)
        {
            this.hubtelDbContext = hubtelDbContext;
        }
        [HttpGet]
        [Route("api/v1/wallets")]
        public async Task<IActionResult> GetAllWallets()
        {
            var wallets = await hubtelDbContext.wallets.ToListAsync();
            return Json(wallets);

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
