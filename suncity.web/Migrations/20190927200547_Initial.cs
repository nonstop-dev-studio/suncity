using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace suncity.web.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ZipCode = table.Column<string>(nullable: true),
                    AddressLine = table.Column<string>(nullable: true)
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
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questionnaires",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questionnaires", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SCUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    MiddleName = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    AddressResidenceId = table.Column<int>(nullable: true),
                    AddressRegistrationId = table.Column<int>(nullable: true),
                    IsRussianCitizenship = table.Column<bool>(nullable: false),
                    ContactsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SCUser_Address_AddressRegistrationId",
                        column: x => x.AddressRegistrationId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SCUser_Address_AddressResidenceId",
                        column: x => x.AddressResidenceId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SCUser_Contacts_ContactsId",
                        column: x => x.ContactsId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Education",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EducationLevel = table.Column<int>(nullable: false),
                    EducationalInstitution = table.Column<string>(nullable: true),
                    SCUserId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Education", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Education_SCUser_SCUserId",
                        column: x => x.SCUserId,
                        principalTable: "SCUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                        name: "FK_Reports_SCUser_childId",
                        column: x => x.childId,
                        principalTable: "SCUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reports_SCUser_mentorId",
                        column: x => x.mentorId,
                        principalTable: "SCUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Education_SCUserId",
                table: "Education",
                column: "SCUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_childId",
                table: "Reports",
                column: "childId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_mentorId",
                table: "Reports",
                column: "mentorId");

            migrationBuilder.CreateIndex(
                name: "IX_SCUser_AddressRegistrationId",
                table: "SCUser",
                column: "AddressRegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_SCUser_AddressResidenceId",
                table: "SCUser",
                column: "AddressResidenceId");

            migrationBuilder.CreateIndex(
                name: "IX_SCUser_ContactsId",
                table: "SCUser",
                column: "ContactsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Education");

            migrationBuilder.DropTable(
                name: "Questionnaires");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "SCUser");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
