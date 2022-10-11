using Hubtel.Wallets.Api.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hubtel.Wallets.Api.Data
{
    public class WalletData : IWalletData
    {
       private HubtelDbContext _dbContext;

        public WalletData(HubtelDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        /*public List<Wallet> GetAllWallets()
                {
                    return _hubtelDbContext.wallets.ToList();
                }

                public async Task<Wallet> GetWalletById(int WalletId)
                {
                    var wallet = await _hubtelDbContext.wallets.FindAsync(WalletId);
                    return wallet;
                }*/

        public Wallet AddWallet(Wallet wallet)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteWallet(int WalletId)
        {
            throw new System.NotImplementedException();
        }

        public List<Wallet> GetAllWallets()
        {
            return _dbContext.wallets.ToList();
        }

        public void GetWalletById(int WalletId)
        {
            _dbContext.wallets.Find(WalletId);   
        }

        public Wallet UpdateWallet(Wallet wallet)
        {
            throw new System.NotImplementedException();
        }
    }
}
