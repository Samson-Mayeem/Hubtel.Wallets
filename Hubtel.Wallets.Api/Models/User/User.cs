using System.ComponentModel.DataAnnotations;

namespace Hubtel.Wallets.Api.Models.User
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
