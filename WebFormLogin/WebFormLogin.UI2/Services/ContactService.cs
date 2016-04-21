using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormLogin.DataAccess.Repositories;


namespace WebFormLogin.UI2.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository contactRepository = new ContactRepository();
        public WebFormLogin.DataAccess.Models.Contact AddContact(WebFormLogin.DataAccess.Models.Contact contact)
        {
            return contactRepository.Insert(contact);
        }
    }
}
