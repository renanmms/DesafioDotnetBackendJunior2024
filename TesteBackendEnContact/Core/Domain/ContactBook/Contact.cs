namespace TesteBackendEnContact.Core.Domain.ContactBook
{
    public class Contact
    {
        public int Id { get; set; }
        public int ContactBookId { get; set; }
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public ContactBook ContactBook { get; set; }
    }
}