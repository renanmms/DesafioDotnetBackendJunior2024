using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TesteBackendEnContact.Core.Domain.ContactBook;
using TesteBackendEnContact.Core.Domain.ContactBook.Company;

namespace TesteBackendEnContact.Database
{
    public class ContactDbContext : DbContext
    {
        public ContactDbContext(DbContextOptions<ContactDbContext> options) : base(options)
        {
            
        }     
        
        public DbSet<ContactBook> ContactBooks { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}