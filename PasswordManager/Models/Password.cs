using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PasswordManager.Models
{
    public class Password
    {
        public int PasswordId { get; set; }

        [NotMapped]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

        public string Site { get; set; }
        public string SiteUsername { get; set; }
        public string SiteEmail { get; set; }
        public string SitePassword { get; set; }
    }
}
