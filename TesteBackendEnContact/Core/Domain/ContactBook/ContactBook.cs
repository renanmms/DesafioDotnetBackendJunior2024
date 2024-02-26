using System.Collections.Generic;
using TesteBackendEnContact.Core.Interface.ContactBook;

namespace TesteBackendEnContact.Core.Domain.ContactBook
{
    public class ContactBook : IContactBook
    {
        public int Id { get;  set; }
        public string Name { get;  set; }
        public int CompanyId { get; set; }
        public Company.Company Company { get; set; }

        public ICollection<Contact> Contacts { get; set; }

        public ContactBook(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
