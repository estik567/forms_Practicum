//using System;
//using Microsoft.EntityFrameworkCore.Migrations;

//#nullable disable

//namespace FormDbContext.Migrations
//{
//    /// <inheritdoc />
//    public partial class childIdAsPrimaryKey : Migration
//    {
//        /// <inheritdoc />
//        protected override void Up(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.CreateTable(
//                name: "child",
//                columns: table => new
//                {
//                    childId = table.Column<int>(type: "int", nullable: false),
//                    childName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
//                    childDateBorn = table.Column<DateTime>(type: "date", nullable: false),
//                    ChildTz = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
//                    ParentTz = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_child", x => x.childId);
//                });

//            migrationBuilder.CreateTable(
//                name: "user",
//                columns: table => new
//                {
//                    userId = table.Column<int>(type: "int", nullable: false)
//                        .Annotation("SqlServer:Identity", "1, 1"),
//                    firstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
//                    lastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
//                    tz = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
//                    dateBorn = table.Column<DateTime>(type: "date", nullable: false),
//                    maleOrFemale = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
//                    hmo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
//                },
//                constraints: table =>
//                {
//                    table.PrimaryKey("PK_user", x => x.userId);
//                });
//        }

//        /// <inheritdoc />
//        protected override void Down(MigrationBuilder migrationBuilder)
//        {
//            migrationBuilder.DropTable(
//                name: "child");

//            migrationBuilder.DropTable(
//                name: "user");
//        }
//    }
//}
