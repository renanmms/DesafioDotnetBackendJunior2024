using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteBackendEnContact.Core.Domain.ContactBook;

namespace TesteBackendEnContact.Database.Configurations
{
    public class ContactBookConfigurations : IEntityTypeConfiguration<ContactBook>
    {
        public void Configure(EntityTypeBuilder<ContactBook> builder)
        {
            builder
                .HasKey(c => c.Id);

            builder
                .HasMany(c => c.Contacts)
                .WithOne(c => c.ContactBook)
                .HasForeignKey(c => c.ContactBookId);
        }
    }
}