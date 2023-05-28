using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CourseStore.DAL.Migrations
{
    public partial class AddShadowProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseTag_Courses_CoursesId",
                table: "CourseTag");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTag_Tags_TagsId",
                table: "CourseTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseTag",
                table: "CourseTag");

            migrationBuilder.RenameColumn(
                name: "TagsId",
                table: "CourseTag",
                newName: "TagId");

            migrationBuilder.RenameColumn(
                name: "CoursesId",
                table: "CourseTag",
                newName: "CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseTag_TagsId",
                table: "CourseTag",
                newName: "IX_CourseTag_TagId");

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Teachers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Teachers",
                type: "datetime2",
                maxLength: 50,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Teachers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Teachers",
                type: "datetime2",
                maxLength: 50,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Tags",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Tags",
                type: "datetime2",
                maxLength: 50,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Tags",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Tags",
                type: "datetime2",
                maxLength: 50,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Orders",
                type: "datetime2",
                maxLength: 50,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Orders",
                type: "datetime2",
                maxLength: 50,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "CourseTeachers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "CourseTeachers",
                type: "datetime2",
                maxLength: 50,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "CourseTeachers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "CourseTeachers",
                type: "datetime2",
                maxLength: 50,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CourseTag",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "CourseTag",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "CourseTag",
                type: "datetime2",
                maxLength: 50,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "CourseTag",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "CourseTag",
                type: "datetime2",
                maxLength: 50,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "Courses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "Courses",
                type: "datetime2",
                maxLength: 50,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "Courses",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Courses",
                type: "datetime2",
                maxLength: 50,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreateBy",
                table: "CourseComments",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreateDate",
                table: "CourseComments",
                type: "datetime2",
                maxLength: 50,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UpdateBy",
                table: "CourseComments",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "CourseComments",
                type: "datetime2",
                maxLength: 50,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseTag",
                table: "CourseTag",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTag_CourseId",
                table: "CourseTag",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TagId",
                table: "Courses",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Tags_TagId",
                table: "Courses",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTag_Courses_CourseId",
                table: "CourseTag",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTag_Tags_TagId",
                table: "CourseTag",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Tags_TagId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTag_Courses_CourseId",
                table: "CourseTag");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseTag_Tags_TagId",
                table: "CourseTag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseTag",
                table: "CourseTag");

            migrationBuilder.DropIndex(
                name: "IX_CourseTag_CourseId",
                table: "CourseTag");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TagId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "CourseTeachers");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "CourseTeachers");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "CourseTeachers");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "CourseTeachers");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CourseTag");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "CourseTag");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "CourseTag");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "CourseTag");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "CourseTag");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CreateBy",
                table: "CourseComments");

            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "CourseComments");

            migrationBuilder.DropColumn(
                name: "UpdateBy",
                table: "CourseComments");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "CourseComments");

            migrationBuilder.RenameColumn(
                name: "TagId",
                table: "CourseTag",
                newName: "TagsId");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "CourseTag",
                newName: "CoursesId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseTag_TagId",
                table: "CourseTag",
                newName: "IX_CourseTag_TagsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseTag",
                table: "CourseTag",
                columns: new[] { "CoursesId", "TagsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTag_Courses_CoursesId",
                table: "CourseTag",
                column: "CoursesId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseTag_Tags_TagsId",
                table: "CourseTag",
                column: "TagsId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
