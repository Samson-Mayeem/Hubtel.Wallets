using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Hubtel.Wallets.Api.Models.Domain
{
    public class Wallet
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}