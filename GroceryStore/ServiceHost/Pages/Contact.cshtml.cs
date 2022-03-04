using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManagement.Domain.Contacts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ContactModel : PageModel
    {
        private IContactUsRepository _contactUsRepository;

        public ContactModel(IContactUsRepository contactUsRepository)
        {
            _contactUsRepository = contactUsRepository;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(ContactUs contactUs)
        {
            if (ModelState.IsValid)
            {
                var ip = HttpContext.Connection.RemoteIpAddress.ToString();
                 _contactUsRepository.CreateContactUs(contactUs, ip);             
                return RedirectToAction("");
            }
            return RedirectToAction("");
        }
    }
}
