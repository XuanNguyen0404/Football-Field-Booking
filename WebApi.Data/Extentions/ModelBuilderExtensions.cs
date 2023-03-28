using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.Entites;

namespace WebApi.Data.Extentions
{
    public static class ModelBuilderExtensions
    {
        public const string GUID_ADMIN_ROLE = "AB1052CC-E279-465D-A9DF-25D1795CE0F3";
        public const string GUID_OWNER_ROLE = "0D854A38-EA51-4F87-8E05-D7D44DB368E1";
        public const string GUID_USER_ROLE = "45A5286C-02E9-4B43-A81F-BB32DCEECFFD";


        public static void Seed(this ModelBuilder modelBuilder)
        {
            
            var hasher = new PasswordHasher<User>();

            modelBuilder.Entity<GroupField>().HasData(
                new GroupField()
                {
                    Name = "Hoang",
                    Address = "HN",
                    GroupFieldId = 1,
                    Status = true,
                    Description = "Sports facilities are the most valuable asset in the business. " +
                    "has always focused on creating more value for its partners. Our system is built on feedback from sports facilities.",
                    CreatedAt = DateTime.Now,
                    UserForeignKey = new Guid("76D27679-BF33-43CE-ABEB-5C85341CC1B9")
                },

                new GroupField()
                {
                    Name = "VanTam",
                    Address = "HN",
                    GroupFieldId = 2,
                    Status = true,
                    Description = "Sports facilities are the most valuable asset in the business. " +
                    "has always focused on creating more value for its partners. Our system is built on feedback from sports facilities.",
                    CreatedAt = DateTime.Now,
                    UserForeignKey = new Guid("66FB69CA-8A82-46BF-B2CF-4101DB00CCCB")
                });

            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = new Guid("76D27679-BF33-43CE-ABEB-5C85341CC1B9"),
                    FirstName = "Bach Duy",
                    LastName = "Hoang",
                    DoB = new DateTime(1998, 05, 13),
                    PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                    PhoneNumber = "09356248153",
                    Email = "hoangbd@gmail.com",

                },
                new User()
                {
                    Id = new Guid("66FB69CA-8A82-46BF-B2CF-4101DB00CCCB"),
                    FirstName = "Nguyen Van",
                    LastName = "Tam",
                    DoB = new DateTime(2000, 08, 20),
                    PasswordHash = hasher.HashPassword(null, "Abcd1234$"),
                    PhoneNumber = "096589475135",
                    Email = "tamnv@gmail.com",
                });


            modelBuilder.Entity<Field>().HasData(
                new Field()
                {
                    FieldId = 1,
                    Name = "A",
                    Address = "HN",
                    TypeField = 5,
                    CreatedAt = DateTime.Now,
                    IsHot = true,
                    TopHot = 1,
                    GroupFieldForeinKey = 1,
                    UserForeignKey = new Guid("76D27679-BF33-43CE-ABEB-5C85341CC1B9"),
                    Status = true
                },
                new Field()
                {
                    FieldId = 2,
                    Name = "B",
                    Address = "HN",
                    TypeField = 5,
                    CreatedAt = DateTime.Now,
                    IsHot = true,
                    TopHot = 3,
                    GroupFieldForeinKey = 1,
                    UserForeignKey = new Guid("76D27679-BF33-43CE-ABEB-5C85341CC1B9"),
                    Status = true
                },
                new Field()
                {
                    FieldId = 3,
                    Name = "C",
                    Address = "HN",
                    TypeField = 7,
                    CreatedAt = DateTime.Now,
                    IsHot = true,
                    TopHot = 2,
                    GroupFieldForeinKey = 1,
                    UserForeignKey = new Guid("76D27679-BF33-43CE-ABEB-5C85341CC1B9"),
                    Status = true
                },
                new Field()
                {
                    FieldId = 4,
                    Name = "A",
                    Address = "HN",
                    TypeField = 5,

                    CreatedAt = DateTime.Now,
                    IsHot = true,
                    TopHot = 1,
                    GroupFieldForeinKey = 2,
                    UserForeignKey = new Guid("66FB69CA-8A82-46BF-B2CF-4101DB00CCCB"),
                    Status = true
                }, 
                new Field()
                {
                    FieldId = 5,
                    Name = "B",
                    Address = "HN",
                    TypeField = 11,
                    CreatedAt = DateTime.Now,
                    IsHot = true,
                    TopHot = 2,
                    GroupFieldForeinKey = 2,
                    UserForeignKey = new Guid("66FB69CA-8A82-46BF-B2CF-4101DB00CCCB"),
                    Status = true
                });

            modelBuilder.Entity<Role>().HasData(
                new Role()
                {
                    Id = new Guid("AB1052CC-E279-465D-A9DF-25D1795CE0F3"),
                    Name = "ADMIN",
                    Description = "Admin is boss"
                },
                new Role()
                {
                    Id = new Guid("0D854A38-EA51-4F87-8E05-D7D44DB368E1"),
                    Name = "OWNER",
                    Description = "Owner is manager"
                },
                new Role()
                {
                    Id = new Guid("45A5286C-02E9-4B43-A81F-BB32DCEECFFD"),
                    Name = "USER",
                    Description = "User is user"
                });

            modelBuilder.Entity<FieldSchedule>().HasData(
                new FieldSchedule()
                {
                    FieldScheduleID = 1,
                    TimeStart = new DateTime(2021,04,10, 5,00,00),
                    TimeEnd = new DateTime(2021, 04, 10, 23, 00, 00),
                    Status = true,
                    FieldForeignKey = 1
                },
                new FieldSchedule()
                {
                     FieldScheduleID = 2,
                     TimeStart = new DateTime(2021, 04, 10, 5, 00, 00),
                     TimeEnd = new DateTime(2021, 04, 10, 23, 00, 00),
                     Status = true,
                     FieldForeignKey = 2
                },
                new FieldSchedule()
                {
                    FieldScheduleID = 3,
                    TimeStart = new DateTime(2021, 04, 10, 5, 00, 00),
                    TimeEnd = new DateTime(2021, 04, 10, 23, 00, 00),
                    Status = true,
                    FieldForeignKey = 3
                },
                new FieldSchedule()
                {
                    FieldScheduleID = 4,
                    TimeStart = new DateTime(2021, 04, 10, 5, 00, 00),
                    TimeEnd = new DateTime(2021, 04, 10, 23, 00, 00),
                    Status = true,
                    FieldForeignKey = 4
                },
                new FieldSchedule()
                {
                    FieldScheduleID = 5,
                    TimeStart = new DateTime(2021, 04, 10, 5, 00, 00),
                    TimeEnd = new DateTime(2021, 04, 10, 23, 00, 00),
                    Status = true,
                    FieldForeignKey = 5
                });

        }
    }
}
