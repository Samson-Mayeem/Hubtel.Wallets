using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;

namespace Hubtel.Wallets.Api.Models.Domain
{
    public class Wallet
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public enum Type { Momo, Card }
        [Required]
        public long AccountNumber { get; set; }
        public enum AccountScheme { visa, mastercard, mtn, vodafone, airteltigo  }
        [Required]
        public DateTime DateCreatedAt{ get; set; }
        public string AccountOwnerNumber { get; set; }
    } 
}