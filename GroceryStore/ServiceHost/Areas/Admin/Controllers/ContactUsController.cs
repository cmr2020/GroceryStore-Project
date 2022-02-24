using _0_Framework.Infrastructure;
using AccountMangement.Infrastructure.EFCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceHost.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = Roles.Administrator)]
    public class ContactUsController : Controller
    {

        private readonly AccountContext _context;

        public ContactUsController(AccountContext context)
        {
            _context = context;
        }


       
        public async Task<IActionResult> Index()
        {
            return View(await _context.ContactUses.ToListAsync());
        }
    }
}
