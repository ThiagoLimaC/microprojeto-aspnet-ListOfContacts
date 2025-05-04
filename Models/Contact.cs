using System.ComponentModel.DataAnnotations;

namespace microprojeto_aspnet_ListOfContacts.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(200)]
        public string Address { get; set; }
        [MaxLength(200)]
        public string City { get; set; }
        [MaxLength(100)]
        public string ImageFileName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
