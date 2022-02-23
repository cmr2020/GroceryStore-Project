using AccountManagement.Application.Contracts.ContactUs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AccountManagement.Domain.Contacts
{
    public interface IContactUsRepository
    {

        Task CreateContactUs(ContactUs contactUs, string userIp);
        IEnumerable<ContactUsViewModel> GetInformationMaster();

    }
}
