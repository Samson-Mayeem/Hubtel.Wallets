using Hubtel.Wallets.Api.Models.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hubtel.Wallets.Api.IServices
{
    public interface IWalletService
    {
        IEnumerable<Wallet> GetAllWallets();
        Wallet AddWallets(Wallet wallet);
        Wallet UpdateWallet(Wallet wallet);
        Wallet DeleteWallet(int WalletId);
        Wallet GetWalletById(int WalletId);
    }
}
