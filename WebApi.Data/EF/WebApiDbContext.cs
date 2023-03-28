using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.Configuration;
using WebApi.Data.Entites;
using WebApi.Data.Extentions;

namespace WebApi.Data.EF
{
    public class WebApiDbContext : IdentityDbContext<User, Role, Guid>
    {
        public WebApiDbContext(DbContextOptions<WebApiDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuration using Fluent APT
            modelBuilder.ApplyConfiguration(new BookingConfiguration());
            modelBuilder.ApplyConfiguration(new BookingDetailConfiguration());
            modelBuilder.ApplyConfiguration(new FeedBackConfiguration());
            modelBuilder.ApplyConfiguration(new FieldConfiguration());
            modelBuilder.ApplyConfiguration(new FieldScheduleConfiguration());
            modelBuilder.ApplyConfiguration(new GroupFieldConfiguration());
            modelBuilder.ApplyConfiguration(new DiscountConfiguration());
            modelBuilder.ApplyConfiguration(new BookingDiscountConfiguration());

            //Identity
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("UserClaim");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("UserRole")
                .HasKey(x => new { x.UserId, x.RoleId });

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("RoleClaim");

            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("UserLogin")
                .HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("UserToken")
                .HasKey(x => x.UserId);

            //Seeding Data 
            modelBuilder.Seed();

            //base.OnModelCreating(modelBuilder);
        }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<BookingDetail> BookingDetails { get; set; }
        public DbSet<FeedBack> FeedBacks { get; set; }
        public DbSet<GroupField> GroupFields { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<FieldSchedule> FieldSchedules { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<BookingDiscount> BookingDiscounts { get; set; }
    }
}
