using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Data.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_AspNetUsers_UserForeignKey",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBack_AspNetUsers_UserForeignKey",
                table: "FeedBack");

            migrationBuilder.DropForeignKey(
                name: "FK_Field_AspNetUsers_UserForeignKey",
                table: "Field");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupField_AspNetUsers_UserId",
                table: "GroupField");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.DropIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "UserToken");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "UserRole");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "UserLogin");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "UserClaim");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "RoleClaim");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Field",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 5, 13, 48, 18, 88, DateTimeKind.Local).AddTicks(6296),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 4, 20, 41, 13, 665, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserToken",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserToken",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "UserLogin",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "UserLogin",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "Role",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Role",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserToken",
                table: "UserToken",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserLogin",
                table: "UserLogin",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserClaim",
                table: "UserClaim",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoleClaim",
                table: "RoleClaim",
                column: "Id");

            migrationBuilder.InsertData(
                table: "GroupField",
                columns: new[] { "GroupFieldId", "Address", "CreatedAt", "Description", "ImageName", "ImagePath", "Name", "Status", "UserForeignKey", "UserId" },
                values: new object[,]
                {
                    { 1, "HN", new DateTime(2021, 11, 5, 13, 48, 18, 117, DateTimeKind.Local).AddTicks(840), "Sports facilities are the most valuable asset in the business. has always focused on creating more value for its partners. Our system is built on feedback from sports facilities.", null, null, "Hoang", true, new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9"), null },
                    { 2, "HN", new DateTime(2021, 11, 5, 13, 48, 18, 117, DateTimeKind.Local).AddTicks(1628), "Sports facilities are the most valuable asset in the business. has always focused on creating more value for its partners. Our system is built on feedback from sports facilities.", null, null, "VanTam", true, new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb"), null }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("ab1052cc-e279-465d-a9df-25d1795ce0f3"), "c906b459-af99-42cc-a4aa-cf95d03f5c4e", "Admin is boss", "ADMIN", null },
                    { new Guid("0d854a38-ea51-4f87-8e05-d7d44db368e1"), "852a4210-98fc-4156-a724-72f63ebc1f45", "Owner is manager", "OWNER", null },
                    { new Guid("45a5286c-02e9-4b43-a81f-bb32dceecffd"), "b53ad226-f55e-4e04-bc08-1ea2c684d1d1", "User is user", "USER", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9"), 0, "97a515c6-cd30-4726-8b47-344af5f7d71b", new DateTime(1998, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangbd@gmail.com", false, "Bach Duy", "Hoang", false, null, null, null, "AQAAAAEAACcQAAAAELPx09IH6XmbgBfcfhQ40dnRUOAOrnaoafAa7BwWi8pmXLivWb5eHCJ3zPM1EgbCIg==", "09356248153", false, null, false, null },
                    { new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb"), 0, "e9ed1013-69a5-42f8-b6de-164a82cbed3b", new DateTime(2000, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "tamnv@gmail.com", false, "Nguyen Van", "Tam", false, null, null, null, "AQAAAAEAACcQAAAAEKaZw0nyS+ow3kvs/odDOciu5UArxLhg2yRIRz4WfjIjauxNABKY3Q3pI00Ee/roSA==", "096589475135", false, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "Field",
                columns: new[] { "FieldId", "Address", "CreatedAt", "DeletedAt", "GroupFieldForeinKey", "ImageName", "ImagePath", "IsHot", "Name", "Status", "TopHot", "TypeField", "UserForeignKey" },
                values: new object[,]
                {
                    { 1, "HN", new DateTime(2021, 11, 5, 13, 48, 18, 140, DateTimeKind.Local).AddTicks(8059), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, true, "A", true, 1, 5, new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9") },
                    { 2, "HN", new DateTime(2021, 11, 5, 13, 48, 18, 141, DateTimeKind.Local).AddTicks(528), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, true, "B", true, 3, 5, new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9") },
                    { 3, "HN", new DateTime(2021, 11, 5, 13, 48, 18, 141, DateTimeKind.Local).AddTicks(619), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, true, "C", true, 2, 7, new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9") },
                    { 4, "HN", new DateTime(2021, 11, 5, 13, 48, 18, 141, DateTimeKind.Local).AddTicks(641), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, null, true, "A", true, 1, 5, new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb") },
                    { 5, "HN", new DateTime(2021, 11, 5, 13, 48, 18, 141, DateTimeKind.Local).AddTicks(646), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, null, true, "B", true, 2, 11, new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb") }
                });

            migrationBuilder.InsertData(
                table: "FieldSchedule",
                columns: new[] { "FieldScheduleID", "FieldForeignKey", "OriginPrice", "Price", "Status", "TimeEnd", "TimeStart" },
                values: new object[,]
                {
                    { 1, 1, 0m, 0m, true, new DateTime(2021, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 10, 5, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 0m, 0m, true, new DateTime(2021, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 10, 5, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 0m, 0m, true, new DateTime(2021, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 10, 5, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, 0m, 0m, true, new DateTime(2021, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 10, 5, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, 0m, 0m, true, new DateTime(2021, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 10, 5, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_User_UserForeignKey",
                table: "Booking",
                column: "UserForeignKey",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBack_User_UserForeignKey",
                table: "FeedBack",
                column: "UserForeignKey",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Field_User_UserForeignKey",
                table: "Field",
                column: "UserForeignKey",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupField_User_UserId",
                table: "GroupField",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_User_UserForeignKey",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBack_User_UserForeignKey",
                table: "FeedBack");

            migrationBuilder.DropForeignKey(
                name: "FK_Field_User_UserForeignKey",
                table: "Field");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupField_User_UserId",
                table: "GroupField");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserToken",
                table: "UserToken");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRole",
                table: "UserRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserLogin",
                table: "UserLogin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserClaim",
                table: "UserClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoleClaim",
                table: "RoleClaim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DeleteData(
                table: "FieldSchedule",
                keyColumn: "FieldScheduleID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FieldSchedule",
                keyColumn: "FieldScheduleID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FieldSchedule",
                keyColumn: "FieldScheduleID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FieldSchedule",
                keyColumn: "FieldScheduleID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FieldSchedule",
                keyColumn: "FieldScheduleID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0d854a38-ea51-4f87-8e05-d7d44db368e1"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("45a5286c-02e9-4b43-a81f-bb32dceecffd"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ab1052cc-e279-465d-a9df-25d1795ce0f3"));

            migrationBuilder.DeleteData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GroupField",
                keyColumn: "GroupFieldId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GroupField",
                keyColumn: "GroupFieldId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9"));

            migrationBuilder.RenameTable(
                name: "UserToken",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "UserRole",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "UserLogin",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "UserClaim",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "RoleClaim",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "AspNetRoles");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Field",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 4, 20, 41, 13, 665, DateTimeKind.Local).AddTicks(2467),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 5, 13, 48, 18, 88, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedUserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedEmail",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NormalizedName",
                table: "AspNetRoles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetRoles",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_AspNetUsers_UserForeignKey",
                table: "Booking",
                column: "UserForeignKey",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBack_AspNetUsers_UserForeignKey",
                table: "FeedBack",
                column: "UserForeignKey",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Field_AspNetUsers_UserForeignKey",
                table: "Field",
                column: "UserForeignKey",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupField_AspNetUsers_UserId",
                table: "GroupField",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
