using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hubtel.Wallets.Api.Models.Domain
{
    public class Wallet
    {
        [Key]
        public int WalletId { get; set; }
        [Required]
        public long UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public long AccountNumber { get; set; }
        [Required]
        public string AccountScheme { get; set; }
        [Required]
        public DateTime DateCreatedAt{ get; set; }
        [Required]
        public string AccountOwnerNumber { get; set; }
    } 
}