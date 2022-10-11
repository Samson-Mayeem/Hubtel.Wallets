using System.ComponentModel.DataAnnotations;
using System;

namespace Hubtel.Wallets.Api.Models
{
    public class AddWallet
    {
        [Key]
        public int WalletId { get; set; }
       
        public int UserId { get; set; }
        
        public string Name { get; set; }
   
        public string Type { get; set; }
       
        public int AccountNumber { get; set; }
       
        public string AccountScheme { get; set; }
        
        public DateTime DateCreatedAt { get; set; }
        
        public string AccountOwnerNumber { get; set; }
    }
}
