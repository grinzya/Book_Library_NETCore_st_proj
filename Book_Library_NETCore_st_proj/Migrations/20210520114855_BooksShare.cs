using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Book_Library_NETCore_st_proj.Migrations
{
    public partial class BooksShare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateShared",
                table: "BooksShared",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateShared",
                table: "BooksShared");
        }
    }
}
