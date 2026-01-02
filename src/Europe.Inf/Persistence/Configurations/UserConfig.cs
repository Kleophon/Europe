using Europe.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Europe.Inf.Persistence.Configurations
{
    public class UserConfig  : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.FirstName)
                   .HasMaxLength(100)
                   .IsRequired(false);


            builder.Property(u => u.LastName)
                .HasMaxLength(50)
                .IsRequired(false);
            builder.Property(u => u.ProfilePictureUrl)
                .HasMaxLength(500);
            builder.Property(u => u.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("GETUTCDATE()");
        }
    }
}
