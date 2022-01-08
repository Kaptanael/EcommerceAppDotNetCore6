using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Domain
{
    public class User: BaseEntity
    {        

        [Required, StringLength(128)]
        public string Username{ get; set; }        

        [Required, StringLength(64)]
        public string Email { get; set; }

        [Required, StringLength(32)]
        public string Phone { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }
    }
}
