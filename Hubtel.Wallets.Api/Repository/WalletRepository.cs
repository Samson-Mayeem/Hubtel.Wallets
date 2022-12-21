using Hubtel.Wallets.Api.Data;
using Hubtel.Wallets.Api;
using Hubtel.Wallets.Api.Models.Domain;
using Hubtel.Wallets.Api.Models.User;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.Metrics;
using Microsoft.AspNetCore.Components.Web;

namespace Hubtel.Wallets.Api.Repository
{
    public class WalletRepository : IWalletRepository
    {
        HubtelDbContext _dbContext;

        public WalletRepository(HubtelDbContext dbContext)
        {
            _dbContext = dbContext;
        }

    
        public async Task AddWallet(Wallet wallet)
        {
            _dbContext.wallets.Add(wallet);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteWallet(long id)
        {
            var walletToDelete = await _dbContext.wallets.FindAsync(id);
             _dbContext.wallets.Remove(walletToDelete);
            await _dbContext.SaveChangesAsync();
        }
    

        public async Task<IEnumerable<Wallet>> GetAll()
        {
            return await _dbContext.wallets.ToListAsync();
        }

        public async Task<Wallet> Get(long WalletId)
        {
            return await _dbContext.wallets.FindAsync(WalletId);
        }

        public async Task UpdateWallet(Wallet wallet)
        {
            _dbContext.Entry(wallet).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
    }
}
