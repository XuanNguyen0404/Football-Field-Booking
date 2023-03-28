using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.Entites;

namespace WebApi.Data.Configuration
{
    public class GroupFieldConfiguration : IEntityTypeConfiguration<GroupField>
    {
        public void Configure(EntityTypeBuilder<GroupField> builder)
        {
            builder.ToTable("GroupField");
            builder.HasKey(x => x.GroupFieldId);
            builder.Property(x => x.GroupFieldId).UseIdentityColumn();

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Status).HasDefaultValue(true);
        }
    }
}
