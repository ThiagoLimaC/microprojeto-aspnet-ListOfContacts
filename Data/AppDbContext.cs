using microprojeto_aspnet_ListOfContacts.Models;
using Microsoft.EntityFrameworkCore;

namespace microprojeto_aspnet_ListOfContacts.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
