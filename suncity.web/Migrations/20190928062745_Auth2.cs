using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace suncity.web.Migrations
{
    public partial class Auth2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_Contacts_ContactsId",
                table: "Questionnaires");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_Employment_EmploymentId",
                table: "Questionnaires");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_MaritalStatus_MaritalStatusState",
                table: "Questionnaires");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Users_ChildId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Users_MentorId",
                table: "Reports");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Employment");

            migrationBuilder.DropTable(
                name: "MaritalStatus");

            migrationBuilder.DropIndex(
                name: "IX_Reports_ChildId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_MentorId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Questionnaires_ContactsId",
                table: "Questionnaires");

            migrationBuilder.DropIndex(
                name: "IX_Questionnaires_EmploymentId",
                table: "Questionnaires");

            migrationBuilder.DropIndex(
                name: "IX_Questionnaires_MaritalStatusState",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastLogon",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Registered",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ChildId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "MentorId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "ContactsId",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "EmploymentId",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "Hobbies",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "MaritalStatusState",
                table: "Questionnaires");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Users",
                newName: "SecurityStamp");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Users",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "MiddleName",
                table: "Users",
                newName: "NormalizedUserName");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Users",
                nullable: false,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Users",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "EmailConfirmed",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Users",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Users",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Users",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "EmailConfirmed",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "SecurityStamp",
                table: "Users",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Users",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NormalizedUserName",
                table: "Users",
                newName: "MiddleName");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogon",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Registered",
                table: "Users",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ChildId",
                table: "Reports",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MentorId",
                table: "Reports",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactsId",
                table: "Questionnaires",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EmploymentId",
                table: "Questionnaires",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Hobbies",
                table: "Questionnaires",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaritalStatusState",
                table: "Questionnaires",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    EducationLevel = table.Column<int>(nullable: false),
                    EducationalInstitution = table.Column<string>(nullable: true),
                    QuestionnaireId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Education_Questionnaires_QuestionnaireId",
                        column: x => x.QuestionnaireId,
                        principalTable: "Questionnaires",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employment",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyPhoneNumber = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Responsibilities = table.Column<string>(nullable: true),
                    WorkSchedule = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MaritalStatus",
                columns: table => new
                {
                    State = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaritalStatus", x => x.State);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ChildId",
                table: "Reports",
                column: "ChildId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_MentorId",
                table: "Reports",
                column: "MentorId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires_ContactsId",
                table: "Questionnaires",
                column: "ContactsId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires_EmploymentId",
                table: "Questionnaires",
                column: "EmploymentId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires_MaritalStatusState",
                table: "Questionnaires",
                column: "MaritalStatusState");

            migrationBuilder.CreateIndex(
                name: "IX_Education_QuestionnaireId",
                table: "Education",
                column: "QuestionnaireId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaires_Contacts_ContactsId",
                table: "Questionnaires",
                column: "ContactsId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaires_Employment_EmploymentId",
                table: "Questionnaires",
                column: "EmploymentId",
                principalTable: "Employment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaires_MaritalStatus_MaritalStatusState",
                table: "Questionnaires",
                column: "MaritalStatusState",
                principalTable: "MaritalStatus",
                principalColumn: "State",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Users_ChildId",
                table: "Reports",
                column: "ChildId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Users_MentorId",
                table: "Reports",
                column: "MentorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
