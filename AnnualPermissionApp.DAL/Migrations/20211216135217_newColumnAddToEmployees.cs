﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace AnnualPermissionApp.DAL.Migrations
{
    public partial class newColumnAddToEmployees : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PermissionLegal",
                table: "Employees",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PermissionLegal",
                table: "Employees");
        }
    }
}
