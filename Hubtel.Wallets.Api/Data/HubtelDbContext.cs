using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hubtel.Wallets.Api.Models.Domain;
using Hubtel.Wallets.Api.Models.User;

namespace Hubtel.Wallets.Api.Data
{
    public class HubtelDbContext : DbContext
    {
        public HubtelDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Wallet> wallets { get; set; }
        public DbSet<User> users { get; set; }
    }
}
