using AccountManagement.Application.Contracts.ContactUs;
using AccountManagement.Domain.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountMangement.Infrastructure.EFCore.Repository
{
    public class ContactUsRepository : IContactUsRepository
    {
        private AccountContext _dbset;

        public ContactUsRepository(AccountContext dbset)
        {
            _dbset = dbset;
        }

        public async Task CreateContactUs(ContactUs contactUs, string userIp)
        {
            await _dbset.AddAsync(contactUs);
            await _dbset.SaveChangesAsync();
        }

        public IEnumerable<ContactUsViewModel> GetInformationMaster()
        {
            return _dbset.ContactUses.Select(p => new ContactUsViewModel()
            {
                FullName = p.FullName,
                Email = p.Email,
                Subject = p.Subject,
                Text = p.Text             
            }).ToList();
        }
    }
}
