using Hubtel.Wallets.Api.Models.Domain;
using System.Collections.Generic;

namespace Hubtel.Wallets.Api.Data
{
    public interface IWallet
    {
        List<Wallet> GetAllWallets();
        Wallet AddWallet(Wallet wallet);
        Wallet UpdateWallet(Wallet wallet);
        void DeleteWallet(int WalletId);
        void GetWalletById(int WalletId);
    }
}
