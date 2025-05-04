using microprojeto_aspnet_ListOfContacts.Data;
using microprojeto_aspnet_ListOfContacts.Models;
using Microsoft.AspNetCore.Mvc;

namespace microprojeto_aspnet_ListOfContacts.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment environment;

        public ContactController(AppDbContext context, IWebHostEnvironment environment)
        {
            this._context = context;
            this.environment = environment;
        }

        public IActionResult Index()
        {
            var contacts = _context.Contacts.OrderByDescending(c => c.Id).ToList();
            return View(contacts);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ContactDto contactDto)
        {
            if (contactDto.Image == null)
            {
                ModelState.AddModelError("Image", "The image file is required");
            }

            if (!ModelState.IsValid)
            {
                return View(contactDto);
            }

            // save the image file to the server
            string newFileName = DateTime.Now.ToString("yyyMMddHHmmssfff");
            newFileName += Path.GetExtension(contactDto.Image!.FileName);

            string imageFullPath = environment.WebRootPath + "/contacts/" + newFileName;
            using (var stream = System.IO.File.Create(imageFullPath))
            {
                contactDto.Image.CopyTo(stream);
            }

            // save the contact to the database
            Contact contact = new Contact
            {
                Name = contactDto.Name,
                Email = contactDto.Email,
                Phone = contactDto.Phone,
                Address = contactDto.Address,
                City = contactDto.City,
                ImageFileName = newFileName,
                CreatedAt = DateTime.Now
            };

            _context.Contacts.Add(contact);
            _context.SaveChanges();

            return RedirectToAction("Index", "Contact");
        }
    }
}
