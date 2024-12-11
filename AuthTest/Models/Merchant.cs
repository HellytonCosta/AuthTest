using System.ComponentModel.DataAnnotations;

namespace AuthTest.Models
{
    public class Merchant
    {
        [Required]
        public string MID { get; set; }
        [Required]
        public string merchantId { get; set; }
    }
}
