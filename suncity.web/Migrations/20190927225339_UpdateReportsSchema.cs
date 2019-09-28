using Microsoft.EntityFrameworkCore.Migrations;

namespace suncity.web.Migrations
{
    public partial class UpdateReportsSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Users_childId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Users_mentorId",
                table: "Reports");

            migrationBuilder.RenameColumn(
                name: "whatDidYouPlanToDoAtTheMeeting",
                table: "Reports",
                newName: "WhatDidYouPlanToDoAtTheMeeting");

            migrationBuilder.RenameColumn(
                name: "whatDidYouEndUpDoing",
                table: "Reports",
                newName: "WhatDidYouEndUpDoing");

            migrationBuilder.RenameColumn(
                name: "targetForNextMeeting",
                table: "Reports",
                newName: "TargetForNextMeeting");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "Reports",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "questions",
                table: "Reports",
                newName: "Questions");

            migrationBuilder.RenameColumn(
                name: "mentorId",
                table: "Reports",
                newName: "MentorId");

            migrationBuilder.RenameColumn(
                name: "duration",
                table: "Reports",
                newName: "Duration");

            migrationBuilder.RenameColumn(
                name: "describeYourMoodAfterTheMeeting",
                table: "Reports",
                newName: "DescribeYourMoodAfterTheMeeting");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "Reports",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "childId",
                table: "Reports",
                newName: "ChildId");

            migrationBuilder.RenameColumn(
                name: "assessTheMoodOfTheChildBeforeAndAfterTheMeeting",
                table: "Reports",
                newName: "AssessTheMoodOfTheChildBeforeAndAfterTheMeeting");

            migrationBuilder.RenameColumn(
                name: "additionalComment",
                table: "Reports",
                newName: "AdditionalComment");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_mentorId",
                table: "Reports",
                newName: "IX_Reports_MentorId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_childId",
                table: "Reports",
                newName: "IX_Reports_ChildId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Users_ChildId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Users_MentorId",
                table: "Reports");

            migrationBuilder.RenameColumn(
                name: "WhatDidYouPlanToDoAtTheMeeting",
                table: "Reports",
                newName: "whatDidYouPlanToDoAtTheMeeting");

            migrationBuilder.RenameColumn(
                name: "WhatDidYouEndUpDoing",
                table: "Reports",
                newName: "whatDidYouEndUpDoing");

            migrationBuilder.RenameColumn(
                name: "TargetForNextMeeting",
                table: "Reports",
                newName: "targetForNextMeeting");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Reports",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Questions",
                table: "Reports",
                newName: "questions");

            migrationBuilder.RenameColumn(
                name: "MentorId",
                table: "Reports",
                newName: "mentorId");

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Reports",
                newName: "duration");

            migrationBuilder.RenameColumn(
                name: "DescribeYourMoodAfterTheMeeting",
                table: "Reports",
                newName: "describeYourMoodAfterTheMeeting");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Reports",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "ChildId",
                table: "Reports",
                newName: "childId");

            migrationBuilder.RenameColumn(
                name: "AssessTheMoodOfTheChildBeforeAndAfterTheMeeting",
                table: "Reports",
                newName: "assessTheMoodOfTheChildBeforeAndAfterTheMeeting");

            migrationBuilder.RenameColumn(
                name: "AdditionalComment",
                table: "Reports",
                newName: "additionalComment");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_MentorId",
                table: "Reports",
                newName: "IX_Reports_mentorId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_ChildId",
                table: "Reports",
                newName: "IX_Reports_childId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Users_childId",
                table: "Reports",
                column: "childId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Users_mentorId",
                table: "Reports",
                column: "mentorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
