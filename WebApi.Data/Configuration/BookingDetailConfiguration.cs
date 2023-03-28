using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.Entites;

namespace WebApi.Data.Configuration
{
    public class BookingDetailConfiguration : IEntityTypeConfiguration<BookingDetail>
    {
        public void Configure(EntityTypeBuilder<BookingDetail> builder)
        {
            builder.ToTable("BookingDetail");
            builder.HasKey(x => x.BookingDetailId);
            builder.Property(x => x.BookingDetailId).UseIdentityColumn();

            builder.HasOne(x => x.Booking).WithMany(x => x.BookingDetails)
                  .HasForeignKey(x => x.BookingForeignKey).IsRequired(false);

            builder.HasOne(x => x.FieldSchedule).WithMany(x => x.BookingDetails)
                  .HasForeignKey(x => x.FieldScheduleForeignKey).IsRequired(false);

            builder.HasOne(x => x.Field).WithMany(x => x.BookingDetails)
                   .HasForeignKey(x => x.FieldForeignKey).IsRequired(false);
        }
    }
}
