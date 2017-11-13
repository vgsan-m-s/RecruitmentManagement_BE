using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace RecruitmentM.EntityFrameworkCore.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSoftDelete",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Applicant");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Applicant",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "MailAddress",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNo",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNo",
                table: "Applicant",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "MailAddress",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "MobileNo",
                table: "Applicant");

            migrationBuilder.DropColumn(
                name: "PhoneNo",
                table: "Applicant");

            migrationBuilder.AddColumn<bool>(
                name: "IsSoftDelete",
                table: "Applicant",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Applicant",
                nullable: true);
        }
    }
}
