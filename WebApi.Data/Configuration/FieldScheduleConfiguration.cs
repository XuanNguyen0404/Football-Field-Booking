using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.Entites;

namespace WebApi.Data.Configuration
{
    public class FieldScheduleConfiguration : IEntityTypeConfiguration<FieldSchedule>
    {
        public void Configure(EntityTypeBuilder<FieldSchedule> builder)
        {
            builder.ToTable("FieldSchedule");
            builder.HasKey(x => x.FieldScheduleID);
            builder.Property(x => x.FieldScheduleID).UseIdentityColumn();

            builder.HasOne(x => x.Field).WithMany(x => x.FieldSchedules)
                .HasForeignKey(x => x.FieldForeignKey);
        }
    }
}

