using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace suncity.web.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ZipCode = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true)
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
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Registered = table.Column<DateTime>(nullable: false),
                    LastLogon = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questionnaires",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    AddressResidenceId = table.Column<int>(nullable: true),
                    AddressRegistrationId = table.Column<int>(nullable: true),
                    IsRussianCitizenship = table.Column<bool>(nullable: false),
                    ContactsId = table.Column<int>(nullable: true),
                    Hobbies = table.Column<string>(nullable: true),
                    EmploymentId = table.Column<Guid>(nullable: true),
                    MaritalStatusState = table.Column<string>(nullable: true),
                    AgreedToShareMedia = table.Column<bool>(nullable: false),
                    AgreedToMakeReports = table.Column<bool>(nullable: false),
                    ProgrammInformationSource = table.Column<string>(nullable: true),
                    ConsentProcessingPersonalData = table.Column<bool>(nullable: false),
                    AgreedWithLiabilities = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questionnaires_Address_AddressRegistrationId",
                        column: x => x.AddressRegistrationId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questionnaires_Address_AddressResidenceId",
                        column: x => x.AddressResidenceId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questionnaires_Contacts_ContactsId",
                        column: x => x.ContactsId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questionnaires_Employment_EmploymentId",
                        column: x => x.EmploymentId,
                        principalTable: "Employment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questionnaires_MaritalStatus_MaritalStatusState",
                        column: x => x.MaritalStatusState,
                        principalTable: "MaritalStatus",
                        principalColumn: "State",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    date = table.Column<DateTime>(nullable: false),
                    childId = table.Column<Guid>(nullable: true),
                    mentorId = table.Column<Guid>(nullable: true),
                    status = table.Column<bool>(nullable: false),
                    duration = table.Column<int>(nullable: false),
                    whatDidYouPlanToDoAtTheMeeting = table.Column<string>(nullable: true),
                    whatDidYouEndUpDoing = table.Column<string>(nullable: true),
                    assessTheMoodOfTheChildBeforeAndAfterTheMeeting = table.Column<string>(nullable: true),
                    targetForNextMeeting = table.Column<string>(nullable: true),
                    describeYourMoodAfterTheMeeting = table.Column<string>(nullable: true),
                    additionalComment = table.Column<string>(nullable: true),
                    questions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reports_Users_childId",
                        column: x => x.childId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reports_Users_mentorId",
                        column: x => x.mentorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateIndex(
                name: "IX_Education_QuestionnaireId",
                table: "Education",
                column: "QuestionnaireId");

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
                name: "IX_Reports_childId",
                table: "Reports",
                column: "childId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_mentorId",
                table: "Reports",
                column: "mentorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "Questionnaires");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Employment");

            migrationBuilder.DropTable(
                name: "MaritalStatus");
        }
    }
}
