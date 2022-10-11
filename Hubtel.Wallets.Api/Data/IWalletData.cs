using Hubtel.Wallets.Api.Models.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hubtel.Wallets.Api.Data
{
    public interface IWalletData
    {
        List<Wallet> GetAllWallets();
        Wallet AddWallet(Wallet wallet);
        Wallet UpdateWallet(Wallet wallet);
        void DeleteWallet(int WalletId);
        void GetWalletById(int WalletId);
    }
}
