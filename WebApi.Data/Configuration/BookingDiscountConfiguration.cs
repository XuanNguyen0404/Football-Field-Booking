using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.Entites;

namespace WebApi.Data.Configuration
{
    public class BookingDiscountConfiguration : IEntityTypeConfiguration<BookingDiscount>
    {
        public void Configure(EntityTypeBuilder<BookingDiscount> builder)
        {
            builder.ToTable("BookingDiscount");
            builder.HasKey(x => x.BookingDiscountId);
            builder.Property(x => x.BookingDiscountId).UseIdentityColumn();

            builder.HasOne(x => x.Booking).WithMany(x => x.BookingDiscount)
                .HasForeignKey(x => x.BookingForeignKey).IsRequired(false);

            builder.HasOne(x => x.Discount).WithMany(x => x.BookingDiscount)
                .HasForeignKey(x => x.DiscountForeignKey).IsRequired(false);
        }
    }
}
