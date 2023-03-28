using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.Entites;

namespace WebApi.Data.Configuration
{
    public class FeedBackConfiguration : IEntityTypeConfiguration<FeedBack>
    {
        public void Configure(EntityTypeBuilder<FeedBack> builder)
        {
            builder.ToTable("FeedBack");
            builder.HasKey(x => x.FeedBackId) ;
            builder.Property(x => x.FeedBackId).UseIdentityColumn();

            builder.HasOne(x => x.User).WithMany(x => x.FeedBacks)
                .HasForeignKey(x => x.UserForeignKey).IsRequired(false);

            builder.HasOne(x => x.BookingDetail).WithMany(x => x.Feedbacks)
                .HasForeignKey(x => x.BookingDetailForeignKey).IsRequired(false);
                
        }
    }
}
