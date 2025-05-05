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

        public IActionResult Edit(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
            {
                return RedirectToAction("Index", "Contact");
            }

            ContactDto contactDto = new ContactDto
            {
                Name = contact.Name,
                Email = contact.Email,
                Phone = contact.Phone,
                Address = contact.Address,
                City = contact.City
            };

            ViewData["ContactId"] = contact.Id;
            ViewData["ImageFileName"] = contact.ImageFileName;
            ViewData["CreatedAt"] = contact.CreatedAt.ToString("MM/dd/yyyy");

            return View(contactDto);
        }

        [HttpPost]
        public IActionResult Edit(int id, ContactDto contactDto)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
            {
                return RedirectToAction("Index", "Contact");
            }

            if (!ModelState.IsValid)
            {
                ViewData["ContactId"] = contact.Id;
                ViewData["ImageFileName"] = contact.ImageFileName;
                ViewData["CreatedAt"] = contact.CreatedAt.ToString("MM/dd/yyyy");

                return View(contactDto);
            }

            // update the file name if a new image is uploaded
            string newFileName = contact.ImageFileName;

            if (contactDto.Image != null)
            {
                newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                newFileName += Path.GetExtension(contactDto.Image.FileName);

                string imageFullPath = environment.WebRootPath + "/contacts/" + newFileName;
                using (var stream = System.IO.File.Create(imageFullPath))
                {
                    contactDto.Image.CopyTo(stream);
                }

                // delete the old image file
                string oldImageFullPath = environment.WebRootPath + "/contacts/" + contact.ImageFileName;
                System.IO.File.Delete(oldImageFullPath);
            }

            // update the contact in the database
            contact.Name = contactDto.Name;
            contact.Email = contactDto.Email;
            contact.Phone = contactDto.Phone;
            contact.Address = contactDto.Address;
            contact.City = contactDto.City;
            contact.ImageFileName = newFileName;

            _context.SaveChanges();

            return RedirectToAction("Index", "Contact");
        }
        
        public IActionResult Delete(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
            {
                return RedirectToAction("Index", "Contact");
            }

            string imageFullPath = environment.WebRootPath + "/contacts/" + contact.ImageFileName;
            System.IO.File.Delete(imageFullPath);

            _context.Contacts.Remove(contact);
            _context.SaveChanges();

            return RedirectToAction("Index", "Contact");
        }
    }
}
