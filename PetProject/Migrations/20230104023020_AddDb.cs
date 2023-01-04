using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PetProject.Migrations
{
    public partial class AddDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HomeroomTeacher",
                columns: table => new
                {
                    Id_Htecher = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<int>(type: "int", nullable: false),
                    NameClass = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeroomTeacher", x => x.Id_Htecher);
                });

            migrationBuilder.CreateTable(
                name: "ListClass",
                columns: table => new
                {
                    IdClass = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Class = table.Column<int>(type: "int", nullable: false),
                    NameClass = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListClass", x => x.IdClass);
                });

            migrationBuilder.CreateTable(
                name: "ListStudent",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStudent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdClass = table.Column<int>(type: "int", nullable: false),
                    IdRank = table.Column<int>(type: "int", nullable: false),
                    IdParent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListStudent", x => x.IdStudent);
                });

            migrationBuilder.CreateTable(
                name: "ListTeacher",
                columns: table => new
                {
                    IdTeacher = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameTeacher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdSubject = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListTeacher", x => x.IdTeacher);
                });

            migrationBuilder.CreateTable(
                name: "Metadate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroundText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Item_Id = table.Column<int>(type: "int", nullable: false),
                    Item_Text = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metadate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parent",
                columns: table => new
                {
                    IdParent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhoneNumber = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdStudent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent", x => x.IdParent);
                });

            migrationBuilder.CreateTable(
                name: "RankStudent",
                columns: table => new
                {
                    IdRank = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Conduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RankStudent", x => x.IdRank);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    IdSubject = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameSubject = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.IdSubject);
                });

            migrationBuilder.CreateTable(
                name: "SubjectScore",
                columns: table => new
                {
                    IdSubjectScore = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdStudent = table.Column<int>(type: "int", nullable: false),
                    Biology = table.Column<int>(type: "int", nullable: true),
                    Chemistry = table.Column<int>(type: "int", nullable: true),
                    Maths = table.Column<int>(type: "int", nullable: true),
                    Physics = table.Column<int>(type: "int", nullable: true),
                    Literature = table.Column<int>(type: "int", nullable: true),
                    Geography = table.Column<int>(type: "int", nullable: true),
                    History = table.Column<int>(type: "int", nullable: true),
                    PhysicalEducation = table.Column<int>(type: "int", nullable: true),
                    English = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectScore", x => x.IdSubjectScore);
                });

            migrationBuilder.CreateTable(
                name: "TeacherOfClass",
                columns: table => new
                {
                    Id_Htecher = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTeacher = table.Column<int>(type: "int", nullable: false),
                    IdClass = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherOfClass", x => x.Id_Htecher);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HomeroomTeacher");

            migrationBuilder.DropTable(
                name: "ListClass");

            migrationBuilder.DropTable(
                name: "ListStudent");

            migrationBuilder.DropTable(
                name: "ListTeacher");

            migrationBuilder.DropTable(
                name: "Metadate");

            migrationBuilder.DropTable(
                name: "Parent");

            migrationBuilder.DropTable(
                name: "RankStudent");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "SubjectScore");

            migrationBuilder.DropTable(
                name: "TeacherOfClass");
        }
    }
}
