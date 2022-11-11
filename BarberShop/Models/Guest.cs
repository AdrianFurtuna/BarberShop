using System.ComponentModel.DataAnnotations;

namespace BarberShop.Models
{
    public class Guest
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name number required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone number required.")]
        public int Phone { get; set; }

        public string Email { get; set; }
    }
}
