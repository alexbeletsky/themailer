using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TheMailer.Models;
using TheMailer.Models.Repositories;

namespace TheMailer.Api
{
    public class ContactsController : ApiController
    {
        private readonly ContactsRepository _contactsRepository;

        public ContactsController()
        {
            _contactsRepository = new ContactsRepository();
        }
        public IEnumerable<Contact> GetContacts()
        {
            return _contactsRepository.All;
        }
    }
}
