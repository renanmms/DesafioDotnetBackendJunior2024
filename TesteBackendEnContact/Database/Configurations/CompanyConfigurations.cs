using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TesteBackendEnContact.Core.Domain.ContactBook;
using TesteBackendEnContact.Core.Domain.ContactBook.Company;

namespace TesteBackendEnContact.Database.Configurations
{
    public class CompanyConfigurations : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder
                .HasKey(c => c.Id);
            
            builder
                .HasOne(c => c.ContactBook)
                .WithOne(c => c.Company)
                .HasForeignKey<ContactBook>(c => c.CompanyId);
        }
    }
}