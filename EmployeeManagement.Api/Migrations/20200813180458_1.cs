using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AccountStartDate",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "AgencyId",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Balance",
                table: "Employees",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Client",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "RefferedAmount",
                table: "Employees",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Employees",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "StatusDate",
                table: "Employees",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentName",
                table: "Departments",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "AccountId", "AccountStartDate", "AgencyId", "Balance", "Client", "DateOfBrith", "Email", "RefferedAmount", "StatusDate" },
                values: new object[] { "200400ARS", new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "003779345", 200.0, "ARMSOL", new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "David@yahoo.com", 300.35000000000002, new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "AccountId", "AccountStartDate", "AgencyId", "Balance", "Client", "Email", "RefferedAmount", "StatusDate" },
                values: new object[] { "200400ARS", new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "003779345", 200.0, "ARMSOL", "Sam@gmail.com", 300.35000000000002, new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "Email",
                value: "mary@armsolutions.com");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "Email",
                value: "sara@cognultsoft.com");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "DepartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AccountStartDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AgencyId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Balance",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Client",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "RefferedAmount",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "StatusDate",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "DepartmentName",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "DateOfBrith", "Email", "PhotoPath" },
                values: new object[] { new DateTime(1980, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "David@pragimtech.com", "images/john.png" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "Email", "PhotoPath" },
                values: new object[] { "Sam@pragimtech.com", "images/sam.jpg" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "Email", "PhotoPath" },
                values: new object[] { "mary@pragimtech.com", "images/mary.png" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                columns: new[] { "Email", "PhotoPath" },
                values: new object[] { "sara@pragimtech.com", "images/sara.png" });
        }
    }
}
