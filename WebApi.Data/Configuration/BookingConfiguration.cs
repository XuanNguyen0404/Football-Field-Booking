using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.Entites;

namespace WebApi.Data.Configuration
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable("Booking");
            builder.HasKey(x => x.BookingId);
            builder.Property(x => x.BookingId).UseIdentityColumn();

            builder.HasOne(x => x.User).WithMany(x => x.Bookings)
                .HasForeignKey(x => x.UserForeignKey).IsRequired(false);
        }
    }
}
