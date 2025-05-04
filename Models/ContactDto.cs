using System.ComponentModel.DataAnnotations;

namespace microprojeto_aspnet_ListOfContacts.Models
{
    public class ContactDto
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, MaxLength(20)]
        public string Phone { get; set; }
        [Required, MaxLength(200)]
        public string Address { get; set; }
        [Required, MaxLength(200)]
        public string City { get; set; }
        public IFormFile? Image { get; set; }

    }
}
