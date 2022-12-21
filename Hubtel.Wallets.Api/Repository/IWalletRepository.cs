using Hubtel.Wallets.Api.Models.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hubtel.Wallets.Api.Repository
{
    public interface IWalletRepository
    {
        Task<IEnumerable<Wallet>> Get();
        Task<Wallet> AddWallets(Wallet wallet);
        Task UpdateWallet(Wallet wallet);
        Task DeleteWallet(long id);
        Task<Wallet> GetById(long WalletId);
    }
}
