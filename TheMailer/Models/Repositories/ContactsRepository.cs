using System.Collections.Generic;
using TheMailer.Api;

namespace TheMailer.Models.Repositories
{
    public class ContactsRepository
    {
        private static readonly List<Contact> _container;

        static ContactsRepository()
        {
            _container = new List<Contact>
                             {
                                 new Contact
                                     {
                                         FirstName = "Alexander",
                                         LastName = "Beletsky",
                                         Email = "abemail@gmail.com",
                                         PhoneNumber = "55-555-555"
                                     },
                                 new Contact
                                     {
                                         FirstName = "Eugene",
                                         LastName = "Beletsky",
                                         Email = "ebemail@gmail.com"
                                     }
                             };
        }

        public IEnumerable<Contact> All
        {
            get { return _container; }
        }
    }
}