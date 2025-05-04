using microprojeto_aspnet_ListOfContacts.Data;
using Microsoft.AspNetCore.Mvc;

namespace microprojeto_aspnet_ListOfContacts.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            this._context = context;    
        }

        public IActionResult Index()
        {
            var contacts = _context.Contacts.ToList();
            return View(contacts);
        }
    }
}
