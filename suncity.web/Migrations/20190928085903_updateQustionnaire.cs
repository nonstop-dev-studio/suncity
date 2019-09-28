using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace suncity.web.Migrations
{
    public partial class updateQustionnaire : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_Address_AddressRegistrationId",
                table: "Questionnaires");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_Address_AddressResidenceId",
                table: "Questionnaires");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_Contacts_ContactsId",
                table: "Questionnaires");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_Employment_EmploymentId",
                table: "Questionnaires");

            migrationBuilder.DropForeignKey(
                name: "FK_Questionnaires_MaritalStatus_MaritalStatusState",
                table: "Questionnaires");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Employment");

            migrationBuilder.DropTable(
                name: "MaritalStatus");

            migrationBuilder.DropIndex(
                name: "IX_Questionnaires_AddressRegistrationId",
                table: "Questionnaires");

            migrationBuilder.DropIndex(
                name: "IX_Questionnaires_AddressResidenceId",
                table: "Questionnaires");

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
                name: "AddressRegistrationId",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "AddressResidenceId",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "AgreedToMakeReports",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "AgreedToShareMedia",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "AgreedWithLiabilities",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "ConsentProcessingPersonalData",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "ContactsId",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "EmploymentId",
                table: "Questionnaires");

            migrationBuilder.RenameColumn(
                name: "ProgrammInformationSource",
                table: "Questionnaires",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "MaritalStatusState",
                table: "Questionnaires",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Hobbies",
                table: "Questionnaires",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "IsRussianCitizenship",
                table: "Questionnaires",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AddColumn<string>(
                name: "AddressRegistration",
                table: "Questionnaires",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressResidence",
                table: "Questionnaires",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BirthDate",
                table: "Questionnaires",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Questionnaires",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Questionnaires",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "Questionnaires",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressRegistration",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "AddressResidence",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Questionnaires");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "Questionnaires");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Questionnaires",
                newName: "ProgrammInformationSource");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Questionnaires",
                newName: "MaritalStatusState");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Questionnaires",
                newName: "Hobbies");

            migrationBuilder.AlterColumn<bool>(
                name: "IsRussianCitizenship",
                table: "Questionnaires",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressRegistrationId",
                table: "Questionnaires",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressResidenceId",
                table: "Questionnaires",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AgreedToMakeReports",
                table: "Questionnaires",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AgreedToShareMedia",
                table: "Questionnaires",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AgreedWithLiabilities",
                table: "Questionnaires",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ConsentProcessingPersonalData",
                table: "Questionnaires",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ContactsId",
                table: "Questionnaires",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EmploymentId",
                table: "Questionnaires",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

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
                name: "IX_Questionnaires_AddressRegistrationId",
                table: "Questionnaires",
                column: "AddressRegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Questionnaires_AddressResidenceId",
                table: "Questionnaires",
                column: "AddressResidenceId");

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
                name: "FK_Questionnaires_Address_AddressRegistrationId",
                table: "Questionnaires",
                column: "AddressRegistrationId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questionnaires_Address_AddressResidenceId",
                table: "Questionnaires",
                column: "AddressResidenceId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
        }
    }
}
