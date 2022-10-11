using System.ComponentModel.DataAnnotations;
using System;

namespace Hubtel.Wallets.Api.Models
{
    public class AddWallet
    {
        [Key]
        public long WalletId { get; set; }
       
        public long UserId { get; set; }
        
        public string Name { get; set; }
   
        public string Type { get; set; }
       
        public long AccountNumber { get; set; }
       
        public string AccountScheme { get; set; }
        
        public DateTime DateCreatedAt { get; set; }
        
        public string AccountOwnerNumber { get; set; }
    }
}
