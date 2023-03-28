using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.Entites;

namespace WebApi.Data.Configuration
{
    public class FieldConfiguration : IEntityTypeConfiguration<Field>
    {
        public void Configure(EntityTypeBuilder<Field> builder)
        {
            builder.ToTable("Field");
            builder.HasKey(x => x.FieldId);
            builder.Property(x => x.FieldId).UseIdentityColumn();
            builder.Property(x => x.TopHot).HasDefaultValue(-1);
            builder.Property(x => x.IsHot).HasDefaultValue(false);
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);

            builder.HasOne(x => x.GroupField).WithMany(x => x.Fields)
                .HasForeignKey(x => x.GroupFieldForeinKey);
            builder.HasOne(x => x.User).WithMany(x => x.Fields)
                .HasForeignKey(x => x.UserForeignKey);
        }
    }
}
