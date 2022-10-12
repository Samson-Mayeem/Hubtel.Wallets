using Hubtel.Wallets.Api.Data;
using Hubtel.Wallets.Api.IServices;
using Hubtel.Wallets.Api.Models.Domain;
using Hubtel.Wallets.Api.Models.User;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hubtel.Wallets.Api.Services
{
    public class WalletService : IWalletService
    {
        HubtelDbContext _dbContext;

        public WalletService(HubtelDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Wallet AddWallet(Wallet wallet)
        {    
            if(Equals(wallet, null))
            {
                _dbContext.wallets.Add(wallet);
                _dbContext.SaveChanges();
                return wallet;
            }
            return null;
        }

        public Wallet AddWallets(Wallet wallet)
        {
            throw new System.NotImplementedException();
        }

        public Wallet DeleteWallet(int WalletId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Wallet> GetAllWallets()
        {
            var wallets = _dbContext.wallets.ToList();
            return wallets;
        }

        public Wallet GetWalletById(int WalletId)
        {
            throw new System.NotImplementedException();
        }

        public Wallet UpdateWallet(Wallet wallet)
        {
            throw new System.NotImplementedException();
        }
    }
}
