using Hubtel.Wallets.Api.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hubtel.Wallets.Api.Data
{
    public class WalletData : IWallet
    {
        private HubtelDbContext _hubtelDbContext;

        public WalletData(HubtelDbContext hubtelDbContext)
        {
            _hubtelDbContext = hubtelDbContext;
        }

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
            return _hubtelDbContext.wallets.ToList();
        }

        public void GetWalletById(int WalletId)
        {
            throw new System.NotImplementedException();
        }

        public Wallet UpdateWallet(Wallet wallet)
        {
            throw new System.NotImplementedException();
        }
    }
}
