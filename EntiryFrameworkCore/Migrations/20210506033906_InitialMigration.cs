using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntiryFrameworkCore.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Descriptions = table.Column<string>(nullable: true),
                    Date_Created = table.Column<DateTime>(nullable: false),
                    Date_Modify = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    First_Name = table.Column<string>(nullable: true),
                    Last_Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Date_Created = table.Column<DateTime>(nullable: false),
                    Date_Modify = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Date_Created", "Date_Modify", "Descriptions", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 6, 11, 39, 5, 992, DateTimeKind.Local).AddTicks(6523), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Super User is a person from the department who has a profound understanding of internal processes and is responsible for knowledge management inside of the department", "Administrator" },
                    { 2, new DateTime(2021, 5, 6, 11, 39, 5, 996, DateTimeKind.Local).AddTicks(2161), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A simple user is the user who is a daily user based on the settings and authorizations provided by the Super User and has limited access due to that.", "User" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Date_Created", "Date_Modify", "Email", "First_Name", "Last_Name", "Password", "RoleId", "Status", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 6, 11, 39, 5, 996, DateTimeKind.Local).AddTicks(9344), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "kensonza@gmail.com", "Kenneth Isaac", "Sonza", "1234567890", 1, 1, "k.sonza" },
                    { 2, new DateTime(2021, 5, 6, 11, 39, 5, 997, DateTimeKind.Local).AddTicks(296), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "crazykalang@yahoo.com", "Maria Carla", "Franco", "1234567890", 2, 1, "c.kalang" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
